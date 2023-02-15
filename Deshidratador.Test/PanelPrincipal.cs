using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Deshidratador.Test {
    public partial class PanelPrincipal : Form {

        float temperatura = 0;
        float humedad = 0;

        public PanelPrincipal() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            _controladorComunicacion.Open();
        }

        private void controladorComunicacion_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) {
            Thread.Sleep(200);

            var respuesta = string.Empty;

            if (_controladorComunicacion.BytesToRead > 0) {
                respuesta = _controladorComunicacion.ReadExisting();

                if (respuesta.Length > 0 && respuesta[0] == '$' && respuesta.Contains("\r")) {
                    var direccion = respuesta.Substring(6, 2);

                    if (direccion != direccionModulo.Value.ToString("00"))
                        return;

                    var datos = respuesta.Substring(8).TrimEnd();

                    /* Procesar comando */
                    switch (datos[0]) {
                        case 'N':
                            _controladorComunicacion.WriteLine($"%AITEC{direccionModulo.Value:00}DHPWM0101\r");
                            break;
                        case 'F':
                            _controladorComunicacion.WriteLine($"%AITEC{direccionModulo.Value:00}DHPFWV0123\r");
                            break;
                        case 'D':
                            _controladorComunicacion.WriteLine($"%AITEC{direccionModulo.Value:00}DS>" +
                                $"{tbTemperatura.Value.ToString("0.0", CultureInfo.InvariantCulture)}>" +
                                $"{tbHumedad.Value.ToString("0.0", CultureInfo.InvariantCulture)}>" +
                                $"01101000>" +
                                $"00000001\r");
                            break;
                        default:
                            break;
                    }

                }
            }
        }
    }
}
