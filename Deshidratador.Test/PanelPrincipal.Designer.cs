namespace Deshidratador.Test {
    partial class PanelPrincipal {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this._controladorComunicacion = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.direccionModulo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTemperatura = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHumedad = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.direccionModulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTemperatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHumedad)).BeginInit();
            this.SuspendLayout();
            // 
            // _controladorComunicacion
            // 
            this._controladorComunicacion.BaudRate = 115200;
            this._controladorComunicacion.PortName = "COM2";
            this._controladorComunicacion.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.controladorComunicacion_DataReceived);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Abrir puerto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // direccionModulo
            // 
            this.direccionModulo.Location = new System.Drawing.Point(124, 12);
            this.direccionModulo.Name = "direccionModulo";
            this.direccionModulo.Size = new System.Drawing.Size(49, 20);
            this.direccionModulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dirección del módulo";
            // 
            // tbTemperatura
            // 
            this.tbTemperatura.Location = new System.Drawing.Point(85, 56);
            this.tbTemperatura.Maximum = 100;
            this.tbTemperatura.Name = "tbTemperatura";
            this.tbTemperatura.Size = new System.Drawing.Size(357, 45);
            this.tbTemperatura.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temperatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Humedad";
            // 
            // tbHumedad
            // 
            this.tbHumedad.Location = new System.Drawing.Point(85, 109);
            this.tbHumedad.Maximum = 100;
            this.tbHumedad.Name = "tbHumedad";
            this.tbHumedad.Size = new System.Drawing.Size(357, 45);
            this.tbHumedad.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 169);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Manual";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 192);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Auto";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(103, 169);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(51, 17);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Inicio";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(103, 192);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(60, 17);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "Parada";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 328);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHumedad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTemperatura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.direccionModulo);
            this.Controls.Add(this.button1);
            this.Name = "PanelPrincipal";
            this.Text = "Simulador deshidratador";
            ((System.ComponentModel.ISupportInitialize)(this.direccionModulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTemperatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHumedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort _controladorComunicacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown direccionModulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbTemperatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbHumedad;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}

