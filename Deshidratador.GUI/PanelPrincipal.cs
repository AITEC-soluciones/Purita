using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
        Configuracion,
        Datos,
        Modo,
        Automatica,
        Orden
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
        private int _modo = 0;
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

        /// <summary>
        ///     Envía los comandos manuales al controlador tras la modificación del bit correspondiente
        ///     a la acción del componente actual.
        /// </summary>
        private void controlVentilador1_SwitchStatusChange(object sender, EventArgs e) {
            /* Enviar comandos manuales */
            EnviarComandoOrdenManual();
        }

        /// <summary>
        ///     Envía los comandos manuales al controlador tras la modificación del bit correspondiente
        ///     a la acción del componente actual.
        /// </summary>
        private void controlVentilador2_SwitchStatusChange(object sender, EventArgs e) {
            /* Enviar comandos manuales */
            EnviarComandoOrdenManual();
        }

        /// <summary>
        ///     Envía los comandos manuales al controlador tras la modificación del bit correspondiente
        ///     a la acción del componente actual.
        /// </summary>
        private void interruptorR1R2_CheckedChanged(object sender, EventArgs e) {
            /* Enviar comandos manuales */
            EnviarComandoOrdenManual();
        }

        /// <summary>
        ///     Envía los comandos manuales al controlador tras la modificación del bit correspondiente
        ///     a la acción del componente actual.
        /// </summary>
        private void interruptorR3R4_CheckedChanged(object sender, EventArgs e) {
            /* Enviar comandos manuales */
            EnviarComandoOrdenManual();
        }

        /// <summary>
        ///     Envía los comandos manuales al controlador tras la modificación del bit correspondiente
        ///     a la acción del componente actual.
        /// </summary>
        private void interruptorR5R6_CheckedChanged(object sender, EventArgs e) {
            /* Enviar comandos manuales */
            EnviarComandoOrdenManual();
        }

        /// <summary>
        ///     Envía los comandos manuales al controlador tras la modificación del bit correspondiente
        ///     a la acción del componente actual.
        /// </summary>
        private void interruptorR7R8_CheckedChanged(object sender, EventArgs e) {
            /* Enviar comandos manuales */
            EnviarComandoOrdenManual();
        }

        /// <summary>
        ///     Envía los comandos manuales al controlador tras la modificación del bit correspondiente
        ///     a la acción del componente actual.
        /// </summary>
        private void interruptorActuadores_CheckedChanged(object sender, EventArgs e) {
            /* Enviar comandos manuales */
            EnviarComandoOrdenManual();
        }

        /// <summary>
        ///     Envía los comandos manuales al controlador tras la modificación del bit correspondiente
        ///     a la acción del componente actual.
        /// </summary>
        private void btnManual_Click(object sender, EventArgs e) {
            /* Salir si se está efectuando el procesamiento de tramas */
            if (_ultimoId != IdTrama.None)
                return;

            /* Modificar el estado Checked del boton inicio */
            btnInicio.Checked = false;

            /* Enviar comandos estado */
            _ultimoId = IdTrama.Automatica;
            _controladorComunicacion.WriteLine($"$AITEC{_direccionModulo}M0\r");
        }

        /// <summary>
        ///     Envía los comandos manuales al controlador tras la modificación del bit correspondiente
        ///     a la acción del componente actual.
        /// </summary>
        private void btnAutomatico_Click(object sender, EventArgs e) {
            /* Salir si se está efectuando el procesamiento de tramas */
            if (_ultimoId != IdTrama.None)
                return;

            /* Modificar el estado Checked del boton inicio */
            btnInicio.Checked = false;

            /* Enviar comandos estado */
            _ultimoId = IdTrama.Automatica;
            _controladorComunicacion.WriteLine($"$AITEC{_direccionModulo}M1\r");
        }

        /// <summary>
        ///     Envía los comandos manuales al controlador tras la modificación del bit correspondiente
        ///     a la acción del componente actual.
        /// </summary>
        private void btnStop_Click(object sender, EventArgs e) {
            /* Salir si se está efectuando el procesamiento de tramas */
            if (_ultimoId != IdTrama.None)
                return;

            /* Modificar el estado Checked del boton inicio */
            btnInicio.Checked = false;

            /* Enviar comandos estado */
            _ultimoId = IdTrama.Automatica;
            _controladorComunicacion.WriteLine($"$AITEC{_direccionModulo}P0\r");
        }

        /// <summary>
        ///     Envía los comandos manuales al controlador tras la modificación del bit correspondiente
        ///     a la acción del componente actual.
        /// </summary>
        private void btnInicio_Click(object sender, EventArgs e) {
            /* Salir si se está efectuando el procesamiento de tramas */
            if (_ultimoId != IdTrama.None)
                return;

            /* Modificar el estado Checked del boton parada */
            btnStop.Checked = false;

            /* Enviar comandos manuales */
            _ultimoId = IdTrama.Automatica;
            _controladorComunicacion.WriteLine($"$AITEC{_direccionModulo}P1\r");
        }
        
        /// <summary>
        ///     Selecciona un perfil de deshidratación al cambiar el índice de selección en el control correspondiente.
        /// </summary>
        private void cbPerfilDeshidratacion_SelectedIndexChanged(object sender, EventArgs e) {
            /* Obtener el perfil */
            PerfilSeleccionado = Perfiles.Find(p => p.Nombre.Equals(cbPerfilesDeshidratacion.SelectedItem.ToString()));

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
                cbPerfilesDeshidratacion.Items.Add(panelNuevoPerfil.Nombre ?? throw new NoNullAllowedException("El nombre no puede ser nulo"));

                /* Salvar el perfil */
                perfil.Salvar();
            }

            /* Seleccionar el perfil predeterminado */
            cbPerfilesDeshidratacion.SelectedItem = panelNuevoPerfil.Nombre;
        }

        /// <summary>
        ///     Elimina el perfil de deshidratación seleccionado
        /// </summary>
        private void btnEliminarPerfil_Click(object sender, EventArgs e) {
            /* Eliminar perfil de la lista y de archivo */
            PerfilSeleccionado.Eliminar();
            cbPerfilesDeshidratacion.Items.Remove(PerfilSeleccionado.Nombre);
            Perfiles.Remove(PerfilSeleccionado);

            /* Seleccionar el perfil predeterminado */
            cbPerfilesDeshidratacion.SelectedItem = "Predeterminado";
        }

        /// <summary>
        ///     Realiza las operaciones correspondientes de habilitación de componentes al seleccionar la
        ///     edición para un valor de la curva de comportamiento de deshidratación.
        /// </summary>
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

        /// <summary>
        ///     Realiza las operaciones correspondientes al resaltado de valores en la gráfica de comportamiento
        ///     para curva de deshidratación al moverse entre los distintos puntos de la misma.
        /// </summary>
        private void nudValorRelacion_ValueChanged(object sender, EventArgs e) {
            /* Resaltar valor a editar en la grafica */
            var valor = (int)nudValorRelacion.Value;

            curvaDeshidratacion.ValorSeleccionado = valor > -1 && valor < 10
                ? valor
                : curvaDeshidratacion.ValorSeleccionado;
            tbHumedad.Text = PerfilSeleccionado.Relaciones[valor].Humedad.ToString();
            tbTemperatura.Text = PerfilSeleccionado.Relaciones[valor].Temperatura.ToString();
        }

        /// <summary>
        ///     Modifica un valor de la curva de comportamiento de deshidratación y envía al controlador la trama
        ///     de datos correspondiente.
        /// </summary>
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
        ///     Actualiza los elementos de la interfaz cada 2 segundos una vez conectado al controlador.
        /// </summary>
        private void temporizadorActualizacion_Tick(object sender, EventArgs e) {
            /* Parada del temporizador por error en la recepción de datos */
            if (_ultimoId != IdTrama.None) {
                if (_noTrama == 5) {
                    _temporizadorActualizacion.Stop();
                    _noTrama = 0;

                    /* Mostrar el panel de módulos */
                    Invoke(new Action(() => {
                        btnPanelModulos_Click(btnPanelModulos, EventArgs.Empty);
                    }));

                    return;
                } else
                    _noTrama++;

                _poolCounter++;

                Invoke(new Action(() => {
                    lbTrama.Text = $"Trama de datos: TIMEOUT {_noTrama}";
                    lbPoolCounter.Text = $"Pooling data: {_poolCounter}\nInvalid data: {_tramaInvalida}";
                }));

                return;
            }                

            /* Parada del temporizador por desconexión del puerto */
            if (!_controladorComunicacion.IsOpen) {
                _temporizadorActualizacion.Stop();

                return;
            }                

            /* Envío de la trama hacia el controlador para obtener los datos que refrescan la interfaz */
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

            /* Retornar si llega el caracter de error desde el controlador */
            if (respuesta.Contains("error"))
                return;

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
                            var byteEstados = datosSplit[3];

                            /* Actualización del modo seleccionado */
                            _modo = byteEstados[7] == '0' ? 1 : byteEstados[7] == '1' ? 2 : 0;

                            /* Actualizar elementos de la interfaz */
                            controlTemperatura1.ValorActual = temperatura;
                            curvaDeshidratacion.ValorTemperaturaActual = temperatura;
                            controlHumedad1.ValorActual = humedad;
                            curvaDeshidratacion.ValorHumedadActual = humedad;

                            try {
                                /* Periféricos */
                                controlVentilador1.Interruptor = byteEstados[0] == '1';
                                controlVentilador1.ValorActual = byteEstados[0] == '1' ? 50 : 0;
                                controlVentilador2.Interruptor = byteEstados[1] == '1';
                                controlVentilador2.ValorActual = byteEstados[1] == '1' ? 50 : 0;
                                
                                Invoke(new Action(() => {
                                    interruptorR1R2.Checked = byteEstados[2] == '1';
                                    interruptorR3R4.Checked = byteEstados[3] == '1';
                                    interruptorR5R6.Checked = byteEstados[4] == '1';
                                    interruptorR7R8.Checked = byteEstados[5] == '1';
                                    interruptorActuadores.Checked = byteEstados[6] == '1';

                                    /* Estados */
                                    indRegimenCalentamiento.Checked = byteEstados[9] == '1';
                                    indRegimenSecado.Checked = byteEstados[10] == '1';
                                    indRegimenPurga.Checked = byteEstados[11] == '1';
                                    btnInicio.FillColor = byteEstados[8] == '1' ? btnInicio.CheckedState.FillColor : Color.FromArgb(183, 186, 171);
                                    btnStop.FillColor = byteEstados[8] == '0' ? btnStop.CheckedState.FillColor : Color.FromArgb(183, 186, 171);
                                    btnAutomatico.Checked = byteEstados[7] == '1';
                                    btnManual.Checked = byteEstados[7] == '0';                                   
                                   
                                    /* Habilitación de componentes según el modo */
                                    btnStop.Enabled = _modo == 2;
                                    btnInicio.Enabled = _modo == 2;
                                    btnAutomatico.Enabled = byteEstados[8] == '0';
                                    btnManual.Enabled = byteEstados[8] == '0';
                                    layoutPerfilesDeshidratacion.Enabled = _modo == 2 && byteEstados[8] == '0';
                                    layoutValoresPerfilDeshidratacion.Enabled = _modo == 2 && byteEstados[8] == '0';
                                    controlVentilador1.Enabled = _modo == 1;
                                    controlVentilador2.Enabled = _modo == 1;
                                    layoutResistencias.Enabled = _modo == 1;
                                    layoutPurgaAireHumedo.Enabled = _modo == 1;
                                }));                                
                            } catch (Exception) {
                                lbTrama.Text = $"Trama de datos: {respuesta.Trim()} <- ERROR";
                            }

                            /* Limpiar id de trama */
                            _ultimoId = IdTrama.None;
                            break;
                        case IdTrama.Modo:
                        case IdTrama.Automatica:
                        case IdTrama.Orden:
                            if (!datos.Contains("OK"))
                                _tramaInvalida++;

                            /* Limpiar id de trama */
                            _ultimoId = IdTrama.None;
                            break;
                        default:
                            /* Limpiar id de trama */
                            _ultimoId = IdTrama.None;
                            break;
                    }
                } else {
                    _tramaInvalida++;

                    /* Limpiar id de trama */
                    _ultimoId = IdTrama.None;
                }
            }
        }

        #endregion

        #region Funciones :

        /// <summary>
        ///     Obtiene el puerto de comunicación activo y encuesta el controlador en la dirección especificada para
        ///     obtener los datos primarios y comenzar el ciclo de obtención de datos del mismo.
        /// </summary>
        /// <param name="controladorComunicacion">El controlador de comunicación o puerto COM</param>
        /// <param name="direccion">La dirección del módulo</param>
        /// <param name="nombre">El nombre del módulo previamente obtenido</param>
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
        ///     Reune los datos necesarios y ejecuta las órdenes manuales correspondientes.
        /// </summary>
        private void EnviarComandoOrdenManual() {
            /* No ejecutar la orden si el controlador no se encuentra en modo manual */
            if (_modo != 1)
                return;

            /* Salir si se está efectuando el procesamiento de tramas */
            if(_ultimoId != IdTrama.None)
                return;

            _ultimoId = IdTrama.Orden;
            _controladorComunicacion.WriteLine($"$AITEC{_direccionModulo}O" +
                $"{(controlVentilador1.Interruptor ? '1' : '0')}" +
                $"{(controlVentilador2.Interruptor ? '1' : '0')}" +
                $"{(interruptorR1R2.Checked ? '1' : '0')}" +
                $"{(interruptorR3R4.Checked ? '1' : '0')}" +
                $"{(interruptorR5R6.Checked ? '1' : '0')}" +
                $"{(interruptorR7R8.Checked ? '1' : '0')}" +
                $"{(interruptorActuadores.Checked ? '1' : '0')}\r");
        }

        /// <summary>
        ///     Habilita o deshabilita los componentes activos de la interfaz.
        /// </summary>
        /// <param name="habilitar">Indica si deshabilitar o habilitar los componentes correspondientes de la interfaz</param>
        internal void HabilitacionComponentes(bool habilitar) {
            /* Componentes de la columna 1 */
            layoutDistribucionColumna1.Enabled = habilitar;

            if (!habilitar) {
                controlVentilador1.ValorActual = 0;
                controlVentilador1.ValorRealimentacion = 0;
                controlVentilador1.Interruptor = false;
                controlHumedad1.ValorActual = 0;
            }
            
            /* Componentes de la columna 2 */
            layoutDistribucionColumna2.Enabled = habilitar;

            if (!habilitar) {
                controlVentilador2.ValorActual = 0;
                controlVentilador2.ValorRealimentacion = 0;
                controlVentilador2.Interruptor = false;
                controlTemperatura1.ValorActual = 0;
            }

            /* Componentes de la columna 3 */
            layoutDistribucionColumna3.Enabled = habilitar;

            if (!habilitar) {
                interruptorR1R2.Checked = false;
                interruptorR3R4.Checked = false;
                interruptorR5R6.Checked = false;
                interruptorR7R8.Checked = false;
                interruptorActuadores.Checked = false;
                cbPerfilesDeshidratacion.SelectedIndex = 0;
                cbEditarValores.Checked = false;
                curvaDeshidratacion.ValorHumedadActual = 0;
                curvaDeshidratacion.ValorTemperaturaActual = 0;
            }

            /* Componentes de la columna 4 */
            layoutDistribucionColumna4.Enabled = habilitar;

            if (!habilitar) {
                btnManual.Checked = false;
                btnAutomatico.Checked = false;
                btnStop.FillColor = Color.FromArgb(183, 186, 171);
                btnInicio.FillColor = Color.FromArgb(183, 186, 171);
                indRegimenCalentamiento.Checked = false;
                indRegimenSecado.Checked = false;
                indRegimenPurga.Checked = false;
            }
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
                        cbPerfilesDeshidratacion.Items.Add(nombre ?? throw new NoNullAllowedException("El nombre no puede ser nulo"));
                    }
                }
            }

            /* Seleccionar el perfil predeterminado */
            cbPerfilesDeshidratacion.SelectedItem = "Predeterminado";
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
