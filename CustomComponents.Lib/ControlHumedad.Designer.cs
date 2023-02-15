namespace CustomComponents.Lib {
    partial class ControlHumedad {
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
            this.layoutDistribucion = new System.Windows.Forms.TableLayoutPanel();
            this.lbPorcientoHumedad = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.layoutDistribucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutDistribucion
            // 
            this.layoutDistribucion.ColumnCount = 1;
            this.layoutDistribucion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDistribucion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutDistribucion.Controls.Add(this.lbPorcientoHumedad, 0, 1);
            this.layoutDistribucion.Controls.Add(this.canvas, 0, 0);
            this.layoutDistribucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDistribucion.Location = new System.Drawing.Point(0, 0);
            this.layoutDistribucion.Margin = new System.Windows.Forms.Padding(0);
            this.layoutDistribucion.Name = "layoutDistribucion";
            this.layoutDistribucion.RowCount = 2;
            this.layoutDistribucion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.layoutDistribucion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDistribucion.Size = new System.Drawing.Size(200, 230);
            this.layoutDistribucion.TabIndex = 0;
            // 
            // lbPorcientoHumedad
            // 
            this.lbPorcientoHumedad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPorcientoHumedad.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorcientoHumedad.ForeColor = System.Drawing.Color.DimGray;
            this.lbPorcientoHumedad.Location = new System.Drawing.Point(3, 200);
            this.lbPorcientoHumedad.Name = "lbPorcientoHumedad";
            this.lbPorcientoHumedad.Size = new System.Drawing.Size(194, 30);
            this.lbPorcientoHumedad.TabIndex = 3;
            this.lbPorcientoHumedad.Text = "0 %";
            this.lbPorcientoHumedad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // canvas
            // 
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Margin = new System.Windows.Forms.Padding(0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(200, 200);
            this.canvas.TabIndex = 2;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // ControlHumedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutDistribucion);
            this.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(200, 230);
            this.Name = "ControlHumedad";
            this.Size = new System.Drawing.Size(200, 230);
            this.layoutDistribucion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutDistribucion;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label lbPorcientoHumedad;
    }
}
