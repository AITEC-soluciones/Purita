using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using CustomComponents.Lib.Properties;

namespace CustomComponents.Lib {
    public partial class ControlHumedad : UserControl {
        
        private float _valorActual;
        private float _valorMinimo;
        private float _valorMaximo;

        public ControlHumedad() {
            InitializeComponent();

            ValorMinimo = 0;
            ValorMaximo = 100;
            ValorActual = 50;
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

            /* Actualizar valor humedad */
            lbPorcientoHumedad.Text = $@"{ObtenerPorciento(_valorMaximo, _valorMinimo, valorActual)}%";

            canvas.Invalidate();
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

        private void canvas_Paint(object sender, PaintEventArgs e) {
            var g = e.Graphics;

            /* Configurar parametros graficos */
            g.Clear(BackColor);
            g.CompositingMode = CompositingMode.SourceOver;
            g.CompositingQuality = CompositingQuality.HighSpeed;
            g.SmoothingMode = SmoothingMode.HighSpeed;

            /* Dibujar fan */
            g.DrawImageUnscaled(Resources.wet_130px, new Point(canvas.Width / 2 - 65, canvas.Height / 2 - 65));

            /* Dibujar circulo borde */
            g.DrawImageUnscaled(Resources.circled_thin_200px, new Point(canvas.Width / 2 - 100, canvas.Height / 2 - 100));

            /* Dibujar la barra de progreso */
            var rectangulo = new Rectangle(canvas.Width / 2 - 83, canvas.Height / 2 - 83, 166, 166);
            var porciento = ObtenerPorciento(_valorMaximo, _valorMinimo, _valorActual);

            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var progressBarPen = new Pen(Color.FromArgb(58, 137, 182), 10)) {
                progressBarPen.StartCap = LineCap.Round;
                progressBarPen.EndCap = LineCap.Round;

                g.DrawArc(progressBarPen, rectangulo, -90, (int)Math.Round(360.0f / 100 * porciento));
            }

            g.Flush();
        }
    }
}
