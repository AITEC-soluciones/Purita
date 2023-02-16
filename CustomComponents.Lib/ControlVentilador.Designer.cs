namespace CustomComponents.Lib {
    partial class ControlVentilador {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.layoutDistribucion = new System.Windows.Forms.TableLayoutPanel();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.lbPorcientoVelocidad = new System.Windows.Forms.Label();
            this.interruptorEnable = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.timerVelocidad = new System.Windows.Forms.Timer(this.components);
            this.layoutDistribucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutDistribucion
            // 
            this.layoutDistribucion.ColumnCount = 1;
            this.layoutDistribucion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDistribucion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutDistribucion.Controls.Add(this.canvas, 0, 0);
            this.layoutDistribucion.Controls.Add(this.lbPorcientoVelocidad, 0, 1);
            this.layoutDistribucion.Controls.Add(this.interruptorEnable, 0, 2);
            this.layoutDistribucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDistribucion.Location = new System.Drawing.Point(0, 0);
            this.layoutDistribucion.Name = "layoutDistribucion";
            this.layoutDistribucion.RowCount = 3;
            this.layoutDistribucion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.layoutDistribucion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDistribucion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDistribucion.Size = new System.Drawing.Size(200, 260);
            this.layoutDistribucion.TabIndex = 0;
            // 
            // canvas
            // 
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Margin = new System.Windows.Forms.Padding(0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(200, 200);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // lbPorcientoVelocidad
            // 
            this.lbPorcientoVelocidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPorcientoVelocidad.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorcientoVelocidad.ForeColor = System.Drawing.Color.DimGray;
            this.lbPorcientoVelocidad.Location = new System.Drawing.Point(3, 200);
            this.lbPorcientoVelocidad.Name = "lbPorcientoVelocidad";
            this.lbPorcientoVelocidad.Size = new System.Drawing.Size(194, 30);
            this.lbPorcientoVelocidad.TabIndex = 1;
            this.lbPorcientoVelocidad.Text = "0 %";
            this.lbPorcientoVelocidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // interruptorEnable
            // 
            this.interruptorEnable.Animated = true;
            this.interruptorEnable.AutoRoundedCorners = true;
            this.interruptorEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.interruptorEnable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(35)))), ((int)(((byte)(19)))));
            this.interruptorEnable.CheckedState.BorderRadius = 11;
            this.interruptorEnable.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
            this.interruptorEnable.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.interruptorEnable.CheckedState.InnerBorderRadius = 7;
            this.interruptorEnable.CheckedState.InnerColor = System.Drawing.Color.White;
            this.interruptorEnable.CheckedState.Parent = this.interruptorEnable;
            this.interruptorEnable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interruptorEnable.Location = new System.Drawing.Point(70, 233);
            this.interruptorEnable.Margin = new System.Windows.Forms.Padding(70, 3, 70, 3);
            this.interruptorEnable.Name = "interruptorEnable";
            this.interruptorEnable.ShadowDecoration.Parent = this.interruptorEnable;
            this.interruptorEnable.Size = new System.Drawing.Size(60, 24);
            this.interruptorEnable.TabIndex = 2;
            this.interruptorEnable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.interruptorEnable.UncheckedState.BorderRadius = 11;
            this.interruptorEnable.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.interruptorEnable.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.interruptorEnable.UncheckedState.InnerBorderRadius = 7;
            this.interruptorEnable.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.interruptorEnable.UncheckedState.Parent = this.interruptorEnable;
            this.interruptorEnable.CheckedChanged += new System.EventHandler(this.interruptorEnable_CheckedChanged);
            // 
            // timerVelocidad
            // 
            this.timerVelocidad.Tick += new System.EventHandler(this.timerVelocidad_Tick);
            // 
            // ControlVentilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutDistribucion);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(200, 260);
            this.Name = "ControlVentilador";
            this.Size = new System.Drawing.Size(200, 260);
            this.layoutDistribucion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutDistribucion;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Timer timerVelocidad;
        public System.Windows.Forms.Label lbPorcientoVelocidad;
        public Guna.UI2.WinForms.Guna2ToggleSwitch interruptorEnable;
    }
}
