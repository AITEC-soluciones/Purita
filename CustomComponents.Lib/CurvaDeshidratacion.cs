using CustomComponents.Lib.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace CustomComponents.Lib {
    public partial class CurvaDeshidratacion : UserControl {

        private readonly float[] _humedad = new float[10];
        private float _humedadActual = 0;
        private readonly float[] _temperatura = new float[10];
        private float _temperaturaActual = 0;
        private int _valorSeleccionado = -1;

        public CurvaDeshidratacion() {
            InitializeComponent();
        }

        private void CurvaDeshidratacion_Resize(object sender, EventArgs e) {
            canvas.Invalidate();
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 1 de humedad. ")]
        public float ValorHumedad1 {
            get => _humedad[0];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorHumedad(value, 0); }));
                else
                    SetValorHumedad(value, 0);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 2 de humedad. ")]
        public float ValorHumedad2 {
            get => _humedad[1];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorHumedad(value, 1); }));
                else
                    SetValorHumedad(value, 1);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 3 de humedad. ")]
        public float ValorHumedad3 {
            get => _humedad[2];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorHumedad(value, 2); }));
                else
                    SetValorHumedad(value, 2);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 4 de humedad. ")]
        public float ValorHumedad4 {
            get => _humedad[3];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorHumedad(value, 3); }));
                else
                    SetValorHumedad(value, 3);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 5 de humedad. ")]
        public float ValorHumedad5 {
            get => _humedad[4];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorHumedad(value, 4); }));
                else
                    SetValorHumedad(value, 4);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 6 de humedad. ")]
        public float ValorHumedad6 {
            get => _humedad[5];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorHumedad(value, 5); }));
                else
                    SetValorHumedad(value, 5);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 7 de humedad. ")]
        public float ValorHumedad7 {
            get => _humedad[6];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorHumedad(value, 6); }));
                else
                    SetValorHumedad(value, 6);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 8 de humedad. ")]
        public float ValorHumedad8 {
            get => _humedad[7];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorHumedad(value, 7); }));
                else
                    SetValorHumedad(value, 7);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 9 de humedad. ")]
        public float ValorHumedad9 {
            get => _humedad[8];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorHumedad(value, 8); }));
                else
                    SetValorHumedad(value, 8);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 10 de humedad. ")]
        public float ValorHumedad10 {
            get => _humedad[9];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorHumedad(value, 9); }));
                else
                    SetValorHumedad(value, 9);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor de humedad actual. ")]
        public float ValorHumedadActual {
            get => _humedadActual;
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorHumedad(value, -1); }));
                else
                    SetValorHumedad(value, -1);
            }
        }

        /// <summary>
        ///     Interpreta los valores entrados en el campo ValorHumedad y actualiza la variable correspondiente. 
        /// </summary>
        public void SetValorHumedad(float valorHumedad, int posicion) {
            if (posicion == -1)
                _humedadActual = valorHumedad;
            else
                _humedad[posicion] = valorHumedad;

            canvas.Invalidate();
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 1 de temperatura. ")]
        public float ValorTemperatura1 {
            get => _temperatura[0];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorTemperatura(value, 0); }));
                else
                    SetValorTemperatura(value, 0);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 2 de temperatura. ")]
        public float ValorTemperatura2 {
            get => _temperatura[1];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorTemperatura(value, 1); }));
                else
                    SetValorTemperatura(value, 1);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 3 de temperatura. ")]
        public float ValorTemperatura3 {
            get => _temperatura[2];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorTemperatura(value, 2); }));
                else
                    SetValorTemperatura(value, 2);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 4 de temperatura. ")]
        public float ValorTemperatura4 {
            get => _temperatura[3];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorTemperatura(value, 3); }));
                else
                    SetValorTemperatura(value, 3);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 5 de temperatura. ")]
        public float ValorTemperatura5 {
            get => _temperatura[4];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorTemperatura(value, 4); }));
                else
                    SetValorTemperatura(value, 4);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 6 de temperatura. ")]
        public float ValorTemperatura6 {
            get => _temperatura[5];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorTemperatura(value, 5); }));
                else
                    SetValorTemperatura(value, 5);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 7 de temperatura. ")]
        public float ValorTemperatura7 {
            get => _temperatura[6];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorTemperatura(value, 6); }));
                else
                    SetValorTemperatura(value, 6);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 8 de temperatura. ")]
        public float ValorTemperatura8 {
            get => _temperatura[7];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorTemperatura(value, 7); }));
                else
                    SetValorTemperatura(value, 7);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 9 de temperatura. ")]
        public float ValorTemperatura9 {
            get => _temperatura[8];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorTemperatura(value, 8); }));
                else
                    SetValorTemperatura(value, 8);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor 10 de temperatura. ")]
        public float ValorTemperatura10 {
            get => _temperatura[9];
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorTemperatura(value, 9); }));
                else
                    SetValorTemperatura(value, 9);
            }
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor de temperatura actual. ")]
        public float ValorTemperaturaActual {
            get => _temperaturaActual;
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorTemperatura(value, -1); }));
                else
                    SetValorTemperatura(value, -1);
            }
        }

        /// <summary>
        ///     Interpreta los valores entrados en el campo ValorTemperatura y actualiza la variable correspondiente. 
        /// </summary>
        public void SetValorTemperatura(float valorTemperatura, int posicion) {
            if (posicion == -1)
                _temperaturaActual = valorTemperatura;
            else
                _temperatura[posicion] = valorTemperatura;

            canvas.Invalidate();
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor seleccionado. ")]
        public int ValorSeleccionado {
            get => _valorSeleccionado;
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorSeleccionado(value); }));
                else
                    SetValorSeleccionado(value);
            }
        }

        /// <summary>
        ///     Interpreta los valores entrados en el campo ValorSeleccioando y actualiza la variable correspondiente. 
        /// </summary>
        private void SetValorSeleccionado(int valorSeleccioando) {
           _valorSeleccionado = valorSeleccioando;

            canvas.Invalidate();
        }

        private void canvas_Paint(object sender, PaintEventArgs e) {
            var g = e.Graphics;

            /* Configurar parametros graficos */
            g.Clear(BackColor);
            g.CompositingMode = CompositingMode.SourceOver;
            g.CompositingQuality = CompositingQuality.HighSpeed;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            
            /* Dibujar rejilla vertical */
            var distanciaVertical = canvas.Width / 10F;
            var offset_vertical = 0;
            float puntero_vertical = 0;

            for (var i = 0; i < 11; i++) {
                var dimensiones_texto = g.MeasureString($"{i * 10}°C", Font);
                var offset_texto_X = 0;
                var offset_texto_Y = 0;

                g.DrawLine(new Pen(Color.FromArgb(183, 186, 171), 1), 
	                new PointF(puntero_vertical + offset_vertical, 0), 
	                new PointF(puntero_vertical + offset_vertical, canvas.Height));

                if (i > 0)
                    g.DrawString($"{i * 10}°C", Font, Brushes.DimGray, 
	                    new PointF(
		                    puntero_vertical + offset_vertical + offset_texto_X, 
		                    canvas.Height - (int)dimensiones_texto.Height + offset_texto_Y));

                puntero_vertical += distanciaVertical;
            }

            /* Dibujar rejilla horizontal */
            var distanciaHorizontal = canvas.Height / 10F;
            var offset_horizontal = 0;
            float puntero_horizontal = canvas.Height;

            for (var i = 0; i < 11; i++) {
	            var dimensiones_texto = g.MeasureString($"{i * 10}%", Font);
	            var offset_texto_X = 0;
	            var offset_texto_Y = 0;

				g.DrawLine(new Pen(Color.FromArgb(183, 186, 171), 1), 
					new PointF(0, puntero_horizontal + offset_horizontal), 
					new PointF(canvas.Width, puntero_horizontal + offset_horizontal));

                if (i > 0)
                    g.DrawString($"{i * 10}%", Font, Brushes.DimGray, 
	                    new PointF(
		                    offset_texto_X, 
		                    puntero_horizontal - (int)dimensiones_texto.Height + offset_texto_Y));

                puntero_horizontal -= distanciaHorizontal;
            }

			/* Dibujar puntos */
			var ultimoPunto = new PointF(0, 0);

			/* Trazar linea */
			for (var i = 0; i < 10; i++) {
				var punto = new PointF(
					canvas.Width * _temperatura[i] / 100F + offset_vertical,
					canvas.Height - canvas.Height * _humedad[i] / 100F + offset_horizontal);

				if (i > 0)
					g.DrawLine(new Pen(Color.FromArgb(140, 117, 54), 2), ultimoPunto, punto);

				/* Almacenar el valor del ultimo punto */
				ultimoPunto = punto;
			}

			/* Dibujar punto */
			for (var i = 0; i < 10; i++) {
				var punto = new PointF(
					canvas.Width * _temperatura[i] / 100F + offset_vertical,
					canvas.Height - canvas.Height * _humedad[i] / 100F + offset_horizontal);

				g.FillEllipse(new SolidBrush(_valorSeleccionado == i ? BackColor : Color.FromArgb(140, 117, 54)), punto.X - 7, punto.Y - 7, 12, 12);
				g.DrawImageUnscaled(Resources.circled_thin_16px, (int)punto.X - 8, (int)punto.Y - 8);
			}

			ultimoPunto = new PointF(
				canvas.Width * _temperaturaActual / 100F + offset_vertical,
				canvas.Height - canvas.Height * _humedadActual / 100F + offset_horizontal);
			
			/* Dibujar linea de humedad actual */
			using (var penHumedad = new Pen(Color.FromArgb(182, 60, 58), 2)) {
				penHumedad.DashStyle = DashStyle.Dash;

				g.DrawLine(penHumedad, new PointF(ultimoPunto.X, 0), new PointF(ultimoPunto.X, canvas.Height));
			}

			/* Dibujar linea de temperatura actual */
			using (var penTemperatura = new Pen(Color.FromArgb(58, 137, 182), 2)) {
				penTemperatura.DashStyle = DashStyle.Dash;

				g.DrawLine(penTemperatura, new PointF(0, ultimoPunto.Y), new PointF(canvas.Width, ultimoPunto.Y));
			}

			/* Dibujar relacion actual en un punto */
			g.FillEllipse(new SolidBrush(BackColor), ultimoPunto.X - 7, ultimoPunto.Y - 7, 12, 12);
			g.DrawImageUnscaled(Resources.circled_thin_16px, (int)ultimoPunto.X - 8, (int)ultimoPunto.Y - 8);

			/* Dibujar marco */
			g.DrawRectangle(new Pen(Color.FromArgb(183, 186, 171), 2), 0, 0, canvas.Width - 1, canvas.Height - 1);
		}        
    }
}
