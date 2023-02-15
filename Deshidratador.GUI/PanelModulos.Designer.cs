namespace Deshidratador.GUI {
    partial class PanelModulos {
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("PC", 0, 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelModulos));
            this.layoutBase = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnActualizarModulos = new Guna.UI2.WinForms.Guna2Button();
            this.lbModulos = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.arbolDispositivos = new System.Windows.Forms.TreeView();
            this.iconosArbolModulos = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this._temporizadorActualizacion = new System.Windows.Forms.Timer(this.components);
            this._controladorComunicacion = new System.IO.Ports.SerialPort(this.components);
            this.layoutBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutBase
            // 
            this.layoutBase.ColumnCount = 2;
            this.layoutBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.layoutBase.Controls.Add(this.pictureBox7, 1, 2);
            this.layoutBase.Controls.Add(this.btnActualizarModulos, 0, 4);
            this.layoutBase.Controls.Add(this.lbModulos, 0, 1);
            this.layoutBase.Controls.Add(this.guna2Separator1, 0, 2);
            this.layoutBase.Controls.Add(this.btnCerrar, 0, 5);
            this.layoutBase.Controls.Add(this.pictureBox1, 1, 0);
            this.layoutBase.Controls.Add(this.pictureBox2, 1, 1);
            this.layoutBase.Controls.Add(this.pictureBox3, 1, 3);
            this.layoutBase.Controls.Add(this.pictureBox4, 1, 4);
            this.layoutBase.Controls.Add(this.pictureBox5, 1, 5);
            this.layoutBase.Controls.Add(this.arbolDispositivos, 0, 3);
            this.layoutBase.Controls.Add(this.pictureBox6, 1, 6);
            this.layoutBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutBase.Location = new System.Drawing.Point(0, 0);
            this.layoutBase.Name = "layoutBase";
            this.layoutBase.RowCount = 7;
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.layoutBase.Size = new System.Drawing.Size(317, 505);
            this.layoutBase.TabIndex = 0;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Location = new System.Drawing.Point(312, 38);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(5, 5);
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // btnActualizarModulos
            // 
            this.btnActualizarModulos.BorderRadius = 5;
            this.btnActualizarModulos.CheckedState.Parent = this.btnActualizarModulos;
            this.btnActualizarModulos.CustomImages.Parent = this.btnActualizarModulos;
            this.btnActualizarModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizarModulos.Enabled = false;
            this.btnActualizarModulos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
            this.btnActualizarModulos.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btnActualizarModulos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarModulos.HoverState.Parent = this.btnActualizarModulos;
            this.btnActualizarModulos.Location = new System.Drawing.Point(3, 428);
            this.btnActualizarModulos.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.btnActualizarModulos.Name = "btnActualizarModulos";
            this.btnActualizarModulos.ShadowDecoration.Parent = this.btnActualizarModulos;
            this.btnActualizarModulos.Size = new System.Drawing.Size(304, 29);
            this.btnActualizarModulos.TabIndex = 8;
            this.btnActualizarModulos.Text = "Actualizar módulos conectados";
            this.btnActualizarModulos.Click += new System.EventHandler(this.btnActualizarModulos_Click);
            // 
            // lbModulos
            // 
            this.lbModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbModulos.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModulos.ForeColor = System.Drawing.Color.DimGray;
            this.lbModulos.Location = new System.Drawing.Point(3, 10);
            this.lbModulos.Name = "lbModulos";
            this.lbModulos.Size = new System.Drawing.Size(306, 28);
            this.lbModulos.TabIndex = 5;
            this.lbModulos.Text = "Módulos";
            this.lbModulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Separator1.Location = new System.Drawing.Point(5, 38);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(302, 5);
            this.guna2Separator1.TabIndex = 6;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BorderRadius = 5;
            this.btnCerrar.CheckedState.Parent = this.btnCerrar;
            this.btnCerrar.CustomImages.Parent = this.btnCerrar;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCerrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.HoverState.Parent = this.btnCerrar;
            this.btnCerrar.Location = new System.Drawing.Point(3, 463);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ShadowDecoration.Parent = this.btnCerrar;
            this.btnCerrar.Size = new System.Drawing.Size(304, 29);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(312, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 10);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(312, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(5, 28);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(312, 43);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(5, 382);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(312, 425);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(5, 35);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(312, 460);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(5, 35);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // arbolDispositivos
            // 
            this.arbolDispositivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.arbolDispositivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arbolDispositivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arbolDispositivos.ImageIndex = 0;
            this.arbolDispositivos.ImageList = this.iconosArbolModulos;
            this.arbolDispositivos.Location = new System.Drawing.Point(10, 53);
            this.arbolDispositivos.Margin = new System.Windows.Forms.Padding(10);
            this.arbolDispositivos.Name = "arbolDispositivos";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "nodoPC";
            treeNode1.SelectedImageIndex = 0;
            treeNode1.Text = "PC";
            this.arbolDispositivos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.arbolDispositivos.SelectedImageIndex = 0;
            this.arbolDispositivos.Size = new System.Drawing.Size(292, 362);
            this.arbolDispositivos.TabIndex = 7;
            this.arbolDispositivos.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.arbolDispositivos_NodeMouseClick);
            this.arbolDispositivos.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.arbolDispositivos_NodeMouseDoubleClick);
            // 
            // iconosArbolModulos
            // 
            this.iconosArbolModulos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconosArbolModulos.ImageStream")));
            this.iconosArbolModulos.TransparentColor = System.Drawing.Color.Transparent;
            this.iconosArbolModulos.Images.SetKeyName(0, "computer_16px.png");
            this.iconosArbolModulos.Images.SetKeyName(1, "rs-232_male_16px.png");
            this.iconosArbolModulos.Images.SetKeyName(2, "module_16px.png");
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Location = new System.Drawing.Point(312, 495);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(5, 10);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // _temporizadorActualizacion
            // 
            this._temporizadorActualizacion.Interval = 500;
            this._temporizadorActualizacion.Tick += new System.EventHandler(this.temporizadorActualizacion_Tick);
            // 
            // _controladorComunicacion
            // 
            this._controladorComunicacion.BaudRate = 115200;
            this._controladorComunicacion.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.controladorComunicacion_DataReceived);
            // 
            // PanelModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(317, 505);
            this.Controls.Add(this.layoutBase);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PanelModulos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PanelModulos";
            this.layoutBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutBase;
        private System.Windows.Forms.Label lbModulos;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.TreeView arbolDispositivos;
        private System.Windows.Forms.ImageList iconosArbolModulos;
        private Guna.UI2.WinForms.Guna2Button btnActualizarModulos;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer _temporizadorActualizacion;
        private System.IO.Ports.SerialPort _controladorComunicacion;
    }
}