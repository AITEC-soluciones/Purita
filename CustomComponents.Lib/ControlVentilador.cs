using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using CustomComponents.Lib.Properties;
using System.ComponentModel;
using System;
using System.Globalization;

namespace CustomComponents.Lib {
    public partial class ControlVentilador : UserControl {

        private float _valorActual;
        private float _valorMinimo;
        private float _valorMaximo;
        private int _valorVelocidad;
        private int _anguloAspa;

        public ControlVentilador() {
            InitializeComponent();

            ValorMinimo = 0;
            ValorMaximo = 100;
            ValorActual = 50;
            ValorVelocidad = 0;
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor de habilitación del interruotor. ")]
        public bool Interruptor {
            get => interruptorEnable.Checked;
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorInterruptor(value); }));
                else
                    SetValorInterruptor(value);
            }
        }

        /// <summary>
        ///     Interpreta los valores entrados en el campo Interruptor y actualiza la variable correspondiente. 
        /// </summary>
        private void SetValorInterruptor(bool value) {
            interruptorEnable.Checked = value;
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor minimo de la barra de progreso. ")]
        public float ValorRealimentacion {
            get => float.Parse(lbPorcientoVelocidad.Text.Replace(" %", string.Empty), NumberStyles.Float, CultureInfo.InvariantCulture);
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorRealimnentacion(value); }));
                else
                    SetValorRealimnentacion(value);
            }
        }

        /// <summary>
        ///     Interpreta los valores entrados en el campo ValorRealimentacion y actualiza la variable correspondiente. 
        /// </summary>
        private void SetValorRealimnentacion(float value) {
            lbPorcientoVelocidad.Text = $"{value.ToString(CultureInfo.InvariantCulture)} %";
        }

        [Category("CustomComponents")]
        [DefaultValue(0)]
        [Description("El Valor minimo de la barra de progreso. ")]
        public float ValorMinimo {
            get => _valorMinimo;
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorMinimo(value); }));
                else
                    SetValorMinimo(value);
            }
        }

        /// <summary>
        ///     Interpreta los valores entrados en el campo ValorMinimo y actualiza la variable correspondiente. 
        /// </summary>
        private void SetValorMinimo(float valorMinimo) {
            _valorMinimo = valorMinimo;

            canvas.Invalidate();
        }

        [Category("CustomComponents")]
        [DefaultValue(100)]
        [Description("El Valor total de la barra de progreso. ")]
        public float ValorMaximo {
            get => _valorMaximo;
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorMaximo(value); }));
                else
                    SetValorMaximo(value);
            }
        }

        /// <summary>
        ///     Interpreta los valores entrados en el campo ValorMaximo y actualiza la variable correspondiente. 
        /// </summary>
        private void SetValorMaximo(float valorMaximo) {
            _valorMaximo = valorMaximo;

            canvas.Invalidate();
        }

        [Category("CustomComponents")]
        [DefaultValue(50)]
        [Description("El Valor a mostrar en la barra de progreso. ")]
        public float ValorActual {
            get => _valorActual;
            set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorActual(value); }));
                else
                    SetValorActual(value);
            }
        }

        /// <summary>
        ///     Interpreta los valores entrados en el campo ValorActual y actualiza la variable correspondiente.
        /// </summary>
        private void SetValorActual(float valorActual) {
            _valorActual = valorActual;

            /* Cambiar el valor de velocidad de la animacion */
            ValorVelocidad = (int)ObtenerPorciento(_valorMaximo, _valorMinimo, valorActual);

            canvas.Invalidate();
        }

        [Category("CustomComponents")]
        [DefaultValue("0")]
        [Description("El Valor velocidad del fan. ")]
        public int ValorVelocidad {
            get => _valorVelocidad;
            private set {
                if (InvokeRequired)
                    Invoke(new Action(() => { SetValorVelocidad(value); }));
                else
                    SetValorVelocidad(value);
            }
        }

        /// <summary>
        ///     Interpreta los valores entrados en el campo ValorMinimo y actualiza la variable correspondiente. 
        /// </summary>
        private void SetValorVelocidad(int valorVelocidad) {
            if (valorVelocidad > 100)
                _valorVelocidad = 100;
            else if (valorVelocidad < 0)
                _valorVelocidad = 0;
            else
                _valorVelocidad = valorVelocidad;

            /* Cambiar la velocidad de la animacion */
            if (valorVelocidad > 90 && valorVelocidad <= 100)
                timerVelocidad.Interval = 10;
            else
                timerVelocidad.Interval = 100 - valorVelocidad;

            if (valorVelocidad > 0)
                timerVelocidad.Start();
            else
                timerVelocidad.Stop();
        }

        /// <summary>
        ///     Obtiene el porciento segun los datos especificados. 
        /// </summary>
        private float ObtenerPorciento(float maximo, float minimo, float actual) {
            //
            //   P   %
            //  --- --- ~ % = P * 100 / T
            //   T  100
            // 
            var m = 100 / (maximo - minimo);
            var n = 0;
            var x = actual - minimo;
            return m * x + n;
        }

        private Image RotarImagen(Image imgOriginal, float grados) {
            var img = new Bitmap(imgOriginal.Width, imgOriginal.Height);
            var g = Graphics.FromImage(img);

            g.Clear(BackColor);
            g.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);
            g.RotateTransform(grados);
            g.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);
            g.DrawImageUnscaled(imgOriginal, 0, 0);

            return img;
        }

        private void timerVelocidad_Tick(object sender, EventArgs e) {
            if (_anguloAspa == 45)
                _anguloAspa = 0;
            else
                _anguloAspa += 45;

            canvas.Invalidate();
        }

        private void canvas_Paint(object sender, PaintEventArgs e) {
            var g = e.Graphics;

            /* Configurar parametros graficos */
            g.Clear(BackColor);
            g.CompositingMode = CompositingMode.SourceOver;
            g.CompositingQuality = CompositingQuality.HighSpeed;
            g.SmoothingMode = SmoothingMode.HighSpeed;

            /* Dibujar fan */
            g.DrawImageUnscaled(RotarImagen(Resources.fan_speed_150px, _anguloAspa), new Point(canvas.Width / 2 - 75, canvas.Height / 2 - 75));

            /* Dibujar circulo borde */
            g.DrawImageUnscaled(Resources.circled_thin_200px, new Point(canvas.Width / 2 - 100, canvas.Height / 2 - 100));

            /* Dibujar la barra de progreso */
            var rectangulo = new Rectangle(canvas.Width / 2 - 83, canvas.Height / 2 - 83, 166, 166);
            var porciento = ObtenerPorciento(_valorMaximo, _valorMinimo, _valorActual);

            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var progressBarPen = new Pen(Color.FromArgb(140, 117, 54), 10)) {
                progressBarPen.StartCap = LineCap.Round;
                progressBarPen.EndCap = LineCap.Round;

                g.DrawArc(progressBarPen, rectangulo, -90, (int)Math.Round(360.0f / 100 * porciento));
            }

            g.Flush();
        }
    }
}
