using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace Deshidratador.GUI {
    public partial class PanelModulos : Form {
        private string _nombrePuerto = string.Empty;
        private int _timeout = 200;
        private int _direccionAux = 0;

        /// <summary>
		///		Inicializa una nueva instancia de la clase <see cref="PanelModulos"/>.
		/// </summary>
        public PanelModulos() {
            InitializeComponent();
        }

        #region Eventos :

        /// <summary>
        ///     Actualiza la seleccion de puertos desde el arbol de dispositivos
        /// </summary>
        private void arbolDispositivos_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (_temporizadorActualizacion.Enabled)
                return;

            if (e.Node.Text.Contains("COM")) {
                _nombrePuerto = e.Node.Text;

                /* Reconfigurar puerto */
                if (_controladorComunicacion.PortName != _nombrePuerto) {
                    if (_controladorComunicacion.IsOpen)
                        _controladorComunicacion.Close();

                    _controladorComunicacion.PortName = _nombrePuerto;
                }

                if (!_controladorComunicacion.IsOpen)
                    _controladorComunicacion.Open();
            }

            /* Habilitar o deshabilitar el botón de actualizacion de módulos */
            btnActualizarModulos.Enabled = e.Node.Text.Contains("COM");
        }

        /// <summary>
        ///     Actualiza la seleccion de dispositivos desde el arbol de dispositivos
        /// </summary>
        private void arbolDispositivos_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (_temporizadorActualizacion.Enabled)
                return;

            if (e.Node.Text.Contains("(") && e.Node.Text.Contains(")")) {
                /* Ocultar la ventana actual */
                Hide();

                /* Cerrar el puerto de comunicaciones */
                if (_controladorComunicacion.IsOpen)
                    _controladorComunicacion.Close();

                var direccion = e.Node.Text.Substring(1, 2);
                var nombre = e.Node.Text.Substring(5);
                 
                ((PanelPrincipal)Owner).ActualizarParametrosModulo(_controladorComunicacion, direccion, nombre);                
            }
        }

        /// <summary>
        ///     Inicia la actualización de los módulos conectados a la red de comunicaciones.
        /// </summary>
        private void btnActualizarModulos_Click(object sender, EventArgs e) {
            if (_temporizadorActualizacion.Enabled) {
                /* Detener el temporizador */
                _temporizadorActualizacion.Stop();
                _direccionAux = 0;

                btnActualizarModulos.Text = "Actualizar módulos conectados";

                return;
            }

            arbolDispositivos.Nodes["nodoPC"].Nodes[$"{_nombrePuerto}"].Nodes.Clear();
            
            /* Iniciar el temporizador */
            _temporizadorActualizacion.Start();
        }

        /// <summary>
        ///     Encuesta las direcciones para obtener respuesta de los módulos conectados.
        /// </summary>
        private void temporizadorActualizacion_Tick(object sender, EventArgs e) {
            if (!_controladorComunicacion.IsOpen)
                _temporizadorActualizacion.Stop();

            /* Condición de parada */
            if (_direccionAux == 100) {
                _direccionAux = 0;
                _temporizadorActualizacion.Stop();

                Invoke(new Action(() => {
                    btnActualizarModulos.Text = "Actualizar módulos conectados";
                }));

                return;
            }

            Invoke(new Action(() => {
                btnActualizarModulos.Text = $"Escaneando dirección {_direccionAux:00}";
            }));

            _controladorComunicacion.WriteLine($"$AITEC{_direccionAux:00}N\r");
            _direccionAux++;
        }

        /// <summary>
        ///     Procesa los datos recibidos en el puerto serial
        /// </summary>
        private void controladorComunicacion_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            if (!Visible)
                return;

            Thread.Sleep(_timeout);
            
            var respuesta = string.Empty;
                        
            if (_controladorComunicacion.BytesToRead > 0) {
                respuesta = _controladorComunicacion.ReadExisting();

                if (respuesta[0] == '%' && respuesta.Contains("\r")) {
                    var direccion = respuesta.Substring(6, 2);
                    var nombre = respuesta.Substring(8).TrimEnd();

                    Invoke(new Action(() => {
                        arbolDispositivos.Nodes["nodoPC"].Nodes[$"{_nombrePuerto}"].Nodes.Add($"{direccion}", $"({direccion}) {nombre}", 2, 2);
                        arbolDispositivos.Nodes["nodoPC"].Nodes[$"{_nombrePuerto}"].Expand();
                    }));
                }
            }
        }

        /// <summary>
        ///     Cierra la ventana y habilita los componentes del panel principal si existe un modulo seleccionado.
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e) {
            if (_temporizadorActualizacion.Enabled)
                return;

            Hide();
        }

        #endregion

        #region Funciones :

        /// <summary>
        ///     Muestra el panel en la locación y dimensiones correctas.
        /// </summary>
        public void MostrarPanel(PanelPrincipal owner, bool inicio = false) {
            /* Actualizar puertos disponibles en caso de inicio */
            if (inicio)
                ActualizarPuertosDisponibles();

            Location = new Point(owner.Location.X + owner.layoutMenuLateral.Width, owner.Location.Y + owner.layoutTitulo.Height + 1);
            Size = new Size(Width, owner.Height - owner.layoutTitulo.Height - owner.layoutPieAplicacion.Height - 2);

            ShowDialog(owner);
        }

        /// <summary>
        ///     Actualiza la lista de puertos disponibles.
        /// </summary>
        private void ActualizarPuertosDisponibles() {
            /* Limpiar el árbol de dispositivos */
            arbolDispositivos.Nodes["nodoPC"].Nodes.Clear();

            /* Adicionar nodos de puertos serie */
            var puertosDisponibles = SerialPort.GetPortNames();

            foreach(var puerto in puertosDisponibles)
                arbolDispositivos.Nodes["nodoPC"].Nodes.Add(puerto, puerto, 1, 1);

            arbolDispositivos.Nodes["nodoPC"].Expand();
        }

        #endregion        
    }
}
