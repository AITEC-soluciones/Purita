using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Automatizacion.Core;

namespace Deshidratador.GUI {
    internal enum IdTrama {
        None,
        Nombre,
        Firmware,
        Datos
    }

    public partial class PanelPrincipal : Form {
        private readonly string _rutaArchivo = $@"{Environment.CurrentDirectory}\perfiles";
        private SerialPort _controladorComunicacion;
        private string _direccionModulo = string.Empty;
        private string _nombreModulo = string.Empty;
        private int _timeout = 200;
        private int _poolCounter = 0;
        private int _tramaInvalida = 0;
        private int _noTrama = 0;
        private IdTrama _ultimoId = IdTrama.None;

        /// <summary>
        ///		Inicializa una nueva instancia de la clase <see cref="PanelPrincipal"/>.
        /// </summary>
        public PanelPrincipal() {
            /* Inicializar componentes */
            InitializeComponent();

            /* Inicializar variables */
            PanelModulo = new PanelModulos();
            Perfiles = new List<PerfilDeshidratacion>();

            /* Carga de datos */
            CargarPerfiles();
        }

        #region Propiedades :

        /// <summary>
        ///     Panel de módulos de la aplicación. Contiene el controlador de comunicaciones.
        /// </summary>
        public PanelModulos PanelModulo { get; private set; }

        /// <summary>
        ///		Perfiles de deshidratación
        /// </summary>
        public List<PerfilDeshidratacion> Perfiles { get; private set; }

        /// <summary>
        ///		El perfil seleccionado desde la interfaz
        /// </summary>
        public PerfilDeshidratacion PerfilSeleccionado { get; private set; }

        #endregion

        #region Eventos :

        /// <summary>
        ///     Muestra el panel de dispositivos al abrir por primera vez la interfaz.
        /// </summary>
        private void PanelPrincipal_Load(object sender, EventArgs e) {
            /* Deshabilitar componentes */
            HabilitacionComponentes(false);

            /* Mostrar el panel de módulos */
            PanelModulo.MostrarPanel(this, true);
        }

        /// <summary>
        ///     Invoca al panel de módulos para buscar y seleccionar el módulo activo.
        /// </summary>
        private void btnPanelModulos_Click(object sender, EventArgs e) {
            /* Deshabilitar componentes */
            HabilitacionComponentes(false);

            /* Eliminar enlace al evento de recepción de datos del puerto */
            if (_controladorComunicacion != null) {
                _controladorComunicacion.DataReceived -= controladorComunicacion_DataReceived;
                _controladorComunicacion?.Close();
            }

            /* Mostrar el panel de módulos */
            PanelModulo.MostrarPanel(this);
        }

        private void btnInicio_Click(object sender, EventArgs e) {

        }

        private void btnStop_Click(object sender, EventArgs e) {

        }

        private void cbPerfilDeshidratacion_SelectedIndexChanged(object sender, EventArgs e) {
            /* Obtener el perfil */
            PerfilSeleccionado = Perfiles.Find(p => p.Nombre.Equals(PerfilesDeshidratacion.SelectedItem.ToString()));

            /* Habilitar el botoón de eliminación */
            btnEliminarPerfil.Enabled = PerfilSeleccionado.Nombre != "Predeterminado";

            /* Actualizar */
            ActualizarCurvaTrabajo();
        }

        /// <summary>
        ///     Crea un nuevo perfil de deshidratación
        /// </summary>
        private void btnCrearPerfil_Click(object sender, EventArgs e) {
            var panelNuevoPerfil = new PanelNuevoPerfil();

            /* Crear un nuevo perfil */
            if (panelNuevoPerfil.ShowDialog(this) == DialogResult.OK) {
                var perfil = new PerfilDeshidratacion(panelNuevoPerfil.Nombre);

                /* Adicionar el nuevo perfil */
                Perfiles.Add(perfil);
                PerfilesDeshidratacion.Items.Add(panelNuevoPerfil.Nombre ?? throw new NoNullAllowedException("El nombre no puede ser nulo"));

                /* Salvar el perfil */
                perfil.Salvar();
            }

            /* Seleccionar el perfil predeterminado */
            PerfilesDeshidratacion.SelectedItem = panelNuevoPerfil.Nombre;
        }

        /// <summary>
        ///     Elimina el perfil de deshidratación seleccionado
        /// </summary>
        private void btnEliminarPerfil_Click(object sender, EventArgs e) {
            /* Eliminar perfil de la lista y de archivo */
            PerfilSeleccionado.Eliminar();
            PerfilesDeshidratacion.Items.Remove(PerfilSeleccionado.Nombre);
            Perfiles.Remove(PerfilSeleccionado);

            /* Seleccionar el perfil predeterminado */
            PerfilesDeshidratacion.SelectedItem = "Predeterminado";
        }

        private void cbEditarValores_CheckedChanged(object sender, EventArgs e) {
            /* Habilitacion de componentes */
            nudValorRelacion.Enabled = cbEditarValores.Checked;
            tbHumedad.Enabled = cbEditarValores.Checked;
            tbTemperatura.Enabled = cbEditarValores.Checked;
            btnModificar.Enabled = cbEditarValores.Checked;

            /* Resaltar valor a editar en la grafica */
            var valor = (int)nudValorRelacion.Value;

            curvaDeshidratacion.ValorSeleccionado = cbEditarValores.Checked
                ? valor
                : -1;
            tbHumedad.Text = cbEditarValores.Checked
                ? PerfilSeleccionado.Relaciones[valor].Humedad.ToString()
                : string.Empty;
            tbTemperatura.Text = cbEditarValores.Checked
                ? PerfilSeleccionado.Relaciones[valor].Temperatura.ToString()
                : string.Empty;

        }

        private void nudValorRelacion_ValueChanged(object sender, EventArgs e) {
            /* Resaltar valor a editar en la grafica */
            var valor = (int)nudValorRelacion.Value;

            curvaDeshidratacion.ValorSeleccionado = valor > -1 && valor < 10
                ? valor
                : curvaDeshidratacion.ValorSeleccionado;
            tbHumedad.Text = PerfilSeleccionado.Relaciones[valor].Humedad.ToString();
            tbTemperatura.Text = PerfilSeleccionado.Relaciones[valor].Temperatura.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            /* Actualizar valor en la grafica */
            var posicion = (int)nudValorRelacion.Value;

            PerfilSeleccionado.Relaciones[posicion].Humedad = int.TryParse(tbHumedad.Text, out var humedad) ? humedad : 0;
            PerfilSeleccionado.Relaciones[posicion].Temperatura = int.TryParse(tbTemperatura.Text, out var temperatura) ? temperatura : 0;
            PerfilSeleccionado.Salvar();

            /* Actualizar */
            ActualizarCurvaTrabajo();
        }

        /// <summary>
        ///     Actualiza los elementos de la interfaz
        /// </summary>
        private void temporizadorActualizacion_Tick(object sender, EventArgs e) {
            if (_ultimoId != IdTrama.None) {
                if (_noTrama == 3) {
                    _temporizadorActualizacion.Stop();
                    _noTrama = 0;
                } else
                    _noTrama++;

                _poolCounter++;

                Invoke(new Action(() => {
                    lbTrama.Text = $"Trama de datos: TIMEOUT {_noTrama}";
                    lbPoolCounter.Text = $"Pooling data: {_poolCounter}\nInvalid data: {_tramaInvalida}";
                }));

                return;
            }                

            /* Parada del temporizador */
            if (!_controladorComunicacion.IsOpen) {
                _temporizadorActualizacion.Stop();

                return;
            }                

            _poolCounter++;
            _ultimoId = IdTrama.Datos;
            _controladorComunicacion.WriteLine($"$AITEC{_direccionModulo}D\r");

            Invoke(new Action(() => {
                lbPoolCounter.Text = $"Pooling data: {_poolCounter}\nInvalid data: {_tramaInvalida}";
            }));
        }

        /// <summary>
        ///     Procesa los datos recibidos en el puerto serial
        /// </summary>
        private void controladorComunicacion_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            Thread.Sleep(_timeout);

            var respuesta = string.Empty;

            if (_controladorComunicacion.BytesToRead > 0) {
                respuesta = _controladorComunicacion.ReadExisting();

                Invoke(new Action(() => {
                    lbTrama.Text = $"Trama de datos: {respuesta.Trim()}";
                }));

                if (respuesta.Length > 0 && respuesta[0] == '%' && respuesta.Contains("\r")) {
                    var direccion = respuesta.Substring(6, 2);
                    var datos = respuesta.Substring(8).TrimEnd();
                    
                    switch (_ultimoId) {
                        case IdTrama.Firmware:
                            /* Actualizar elementos de la interfaz */
                            Invoke(new Action(() => {
                                lbModulo.Text = $"Módulo: {_nombreModulo}";
                                lbVersionFirmware.Text = $"Versión del Firmware: {datos.Replace("DHPFWV", string.Empty)}";

                                /* Iniciar el temporizador de actualización */
                                _temporizadorActualizacion.Start();
                            }));

                            /* Limpiar id de trama */
                            _ultimoId = IdTrama.None;                            
                            break;
                        case IdTrama.Datos:
                            /* Clasificar datos de trama */
                            var datosSplit = datos.Split('>');
                            var id = datosSplit[0];
                            var temperatura = float.Parse(datosSplit[1], NumberStyles.Float, CultureInfo.InvariantCulture);
                            var humedad = float.Parse(datosSplit[2], NumberStyles.Float, CultureInfo.InvariantCulture);
                            var bytePerifericos = datosSplit[3];
                            var byteActivacion = datosSplit[4];

                            /* Actualizar elementos de la interfaz */
                            controlTemperatura1.ValorActual = temperatura;
                            curvaDeshidratacion.ValorTemperaturaActual = temperatura;
                            controlHumedad1.ValorActual = humedad;
                            curvaDeshidratacion.ValorHumedadActual = humedad;

                            try {
                                controlVentilador1.Interruptor = bytePerifericos[0] == '1';
                                controlVentilador1.ValorActual = bytePerifericos[0] == '1' ? 50 : 0;
                                controlVentilador2.Interruptor = bytePerifericos[1] == '1';
                                controlVentilador2.ValorActual = bytePerifericos[1] == '1' ? 50 : 0;

                                Invoke(new Action(() => {
                                    interruptorR1R2.Checked = bytePerifericos[2] == '1';
                                    interruptorR3R4.Checked = bytePerifericos[3] == '1';
                                    interruptorR5R6.Checked = bytePerifericos[4] == '1';
                                    interruptorR7R8.Checked = bytePerifericos[5] == '1';
                                }));                                
                            } catch (Exception) {
                                throw;
                            }                            

                            /* Limpiar id de trama */
                            _ultimoId = IdTrama.None;
                            break;
                        default:
                            break;
                    }

                } else {
                    _tramaInvalida++;

                    Invoke(new Action(() => {
                        lbPoolCounter.Text = $"Pooling data: {_poolCounter}\nInvalid data: {_tramaInvalida}";
                    }));

                    /* Limpiar id de trama */
                    _ultimoId = IdTrama.None;
                }
            }
        }

        #endregion

        #region Funciones :

        /// <summary>
        /// 
        /// </summary>
        /// <param name="controladorComunicacion"></param>
        /// <param name="direccion"></param>
        /// <param name="nombre"></param>
        internal void ActualizarParametrosModulo(SerialPort controladorComunicacion, string direccion, string nombre) {
            _controladorComunicacion = controladorComunicacion;
            _direccionModulo = direccion;
            _nombreModulo = nombre;

            /* Crear enlace al ewvento de recepción de datos del puerto */
            _controladorComunicacion.DataReceived += controladorComunicacion_DataReceived;

            /* Abrir puerto serie */
            if (!_controladorComunicacion.IsOpen)
                _controladorComunicacion.Open();

            _ultimoId = IdTrama.Firmware;
            _controladorComunicacion.WriteLine($"$AITEC{direccion}F\r");

            /* Habilita los componentes */
            HabilitacionComponentes(true);
        }

        /// <summary>
        ///     Habilita o deshabilita los componentes activos de la interfaz.
        /// </summary>
        /// <param name="habilitar">Indica si deshabilitar o habilitar los componentes correspondientes de la interfaz</param>
        internal void HabilitacionComponentes(bool habilitar) {
            layoutDistribucionColumna1.Enabled = habilitar;
            layoutDistribucionColumna2.Enabled = habilitar;
            layoutDistribucionVariables.Enabled = habilitar;
            layoutDistribucionProceso.Enabled = habilitar;
        }

        /// <summary>
        ///		Carga los perfiles de la curva para la deshidratación desde archivo.
        /// </summary>
        private void CargarPerfiles() {
            var rutasPerfiles = Directory.GetFiles(_rutaArchivo, "*.pd");

            /* Leer los archivos */
            foreach (var rutaPerfil in rutasPerfiles) {
                using (var fs = new FileStream(rutaPerfil, FileMode.Open)) {
                    using (var sr = new StreamReader(fs, Encoding.ASCII)) {
                        var nombre = sr.ReadLine();
                        var perfil = new PerfilDeshidratacion(nombre);

                        /* Actualizar valores de las relaciones */
                        for (var i = 0; i < 10; i++) {
                            var relacionSplit = sr.ReadLine().Split('|');
                            var humedad = int.Parse(relacionSplit[0].Trim());
                            var temperatura = int.Parse(relacionSplit[1].Trim());

                            perfil.ModificarRelacion(humedad, temperatura, i);
                        }

                        /* Adicionar el perfil cargado */
                        Perfiles.Add(perfil);
                        PerfilesDeshidratacion.Items.Add(nombre ?? throw new NoNullAllowedException("El nombre no puede ser nulo"));
                    }
                }
            }

            /* Seleccionar el perfil predeterminado */
            PerfilesDeshidratacion.SelectedItem = "Predeterminado";
        }

        /// <summary>
        ///		Actualiza la curva de trabajo según el perfil seleccionado.
        /// </summary>
        private void ActualizarCurvaTrabajo() {
            for (var i = 0; i < PerfilSeleccionado.Relaciones.Length; i++) {
                var relacion = PerfilSeleccionado.Relaciones[i];

                curvaDeshidratacion.SetValorHumedad(relacion.Humedad, i);
                curvaDeshidratacion.SetValorTemperatura(relacion.Temperatura, i);
            }
        }

        #endregion

    }
}
