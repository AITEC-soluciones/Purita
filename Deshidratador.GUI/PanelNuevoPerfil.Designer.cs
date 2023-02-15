namespace Deshidratador.GUI {
    partial class PanelNuevoPerfil {
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
            this.layoutBase = new System.Windows.Forms.TableLayoutPanel();
            this.layoutTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.TituloPanel = new System.Windows.Forms.Label();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.layoutPerfilesDeshidratacion = new System.Windows.Forms.TableLayoutPanel();
            this.tbNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSeleccionPerfil = new System.Windows.Forms.Label();
            this.btnCrearPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.layoutBase.SuspendLayout();
            this.layoutTitulo.SuspendLayout();
            this.layoutPanel.SuspendLayout();
            this.layoutPerfilesDeshidratacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutBase
            // 
            this.layoutBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.layoutBase.ColumnCount = 1;
            this.layoutBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutBase.Controls.Add(this.layoutTitulo, 0, 0);
            this.layoutBase.Controls.Add(this.layoutPanel, 0, 1);
            this.layoutBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutBase.Location = new System.Drawing.Point(0, 0);
            this.layoutBase.Name = "layoutBase";
            this.layoutBase.RowCount = 2;
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutBase.Size = new System.Drawing.Size(488, 143);
            this.layoutBase.TabIndex = 0;
            // 
            // layoutTitulo
            // 
            this.layoutTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.layoutTitulo.ColumnCount = 3;
            this.layoutTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTitulo.Controls.Add(this.btnCerrar, 2, 0);
            this.layoutTitulo.Controls.Add(this.TituloPanel, 1, 0);
            this.layoutTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTitulo.Location = new System.Drawing.Point(0, 0);
            this.layoutTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.layoutTitulo.Name = "layoutTitulo";
            this.layoutTitulo.RowCount = 1;
            this.layoutTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTitulo.Size = new System.Drawing.Size(488, 35);
            this.layoutTitulo.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Animated = true;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCerrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnCerrar.HoverState.Parent = this.btnCerrar;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(454, 1);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ShadowDecoration.Parent = this.btnCerrar;
            this.btnCerrar.Size = new System.Drawing.Size(33, 33);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // TituloPanel
            // 
            this.TituloPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TituloPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TituloPanel.Location = new System.Drawing.Point(60, 0);
            this.TituloPanel.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.TituloPanel.Name = "TituloPanel";
            this.TituloPanel.Size = new System.Drawing.Size(390, 35);
            this.TituloPanel.TabIndex = 2;
            this.TituloPanel.Text = "Nuevo perfil de deshidratación";
            this.TituloPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // layoutPanel
            // 
            this.layoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.layoutPanel.ColumnCount = 1;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.Controls.Add(this.layoutPerfilesDeshidratacion, 0, 1);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(5, 40);
            this.layoutPanel.Margin = new System.Windows.Forms.Padding(5);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 3;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.Size = new System.Drawing.Size(478, 98);
            this.layoutPanel.TabIndex = 2;
            // 
            // layoutPerfilesDeshidratacion
            // 
            this.layoutPerfilesDeshidratacion.ColumnCount = 3;
            this.layoutPerfilesDeshidratacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.layoutPerfilesDeshidratacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPerfilesDeshidratacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.layoutPerfilesDeshidratacion.Controls.Add(this.tbNombre, 0, 0);
            this.layoutPerfilesDeshidratacion.Controls.Add(this.lbSeleccionPerfil, 0, 0);
            this.layoutPerfilesDeshidratacion.Controls.Add(this.btnCrearPerfil, 2, 0);
            this.layoutPerfilesDeshidratacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPerfilesDeshidratacion.Location = new System.Drawing.Point(0, 31);
            this.layoutPerfilesDeshidratacion.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPerfilesDeshidratacion.Name = "layoutPerfilesDeshidratacion";
            this.layoutPerfilesDeshidratacion.RowCount = 1;
            this.layoutPerfilesDeshidratacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPerfilesDeshidratacion.Size = new System.Drawing.Size(478, 35);
            this.layoutPerfilesDeshidratacion.TabIndex = 11;
            // 
            // tbNombre
            // 
            this.tbNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNombre.DefaultText = "";
            this.tbNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNombre.DisabledState.Parent = this.tbNombre;
            this.tbNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNombre.FocusedState.Parent = this.tbNombre;
            this.tbNombre.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.tbNombre.ForeColor = System.Drawing.Color.Black;
            this.tbNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNombre.HoverState.Parent = this.tbNombre;
            this.tbNombre.Location = new System.Drawing.Point(143, 4);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.PasswordChar = '\0';
            this.tbNombre.PlaceholderText = "";
            this.tbNombre.SelectedText = "";
            this.tbNombre.ShadowDecoration.Parent = this.tbNombre;
            this.tbNombre.Size = new System.Drawing.Size(192, 27);
            this.tbNombre.TabIndex = 7;
            // 
            // lbSeleccionPerfil
            // 
            this.lbSeleccionPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSeleccionPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSeleccionPerfil.Location = new System.Drawing.Point(5, 0);
            this.lbSeleccionPerfil.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lbSeleccionPerfil.Name = "lbSeleccionPerfil";
            this.lbSeleccionPerfil.Size = new System.Drawing.Size(132, 35);
            this.lbSeleccionPerfil.TabIndex = 3;
            this.lbSeleccionPerfil.Text = "Nombre del perfil:";
            this.lbSeleccionPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCrearPerfil
            // 
            this.btnCrearPerfil.BorderRadius = 5;
            this.btnCrearPerfil.CheckedState.Parent = this.btnCrearPerfil;
            this.btnCrearPerfil.CustomImages.Parent = this.btnCrearPerfil;
            this.btnCrearPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrearPerfil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
            this.btnCrearPerfil.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btnCrearPerfil.ForeColor = System.Drawing.Color.White;
            this.btnCrearPerfil.HoverState.Parent = this.btnCrearPerfil;
            this.btnCrearPerfil.Location = new System.Drawing.Point(341, 3);
            this.btnCrearPerfil.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btnCrearPerfil.Name = "btnCrearPerfil";
            this.btnCrearPerfil.ShadowDecoration.Parent = this.btnCrearPerfil;
            this.btnCrearPerfil.Size = new System.Drawing.Size(117, 29);
            this.btnCrearPerfil.TabIndex = 5;
            this.btnCrearPerfil.Text = "Crear";
            this.btnCrearPerfil.Click += new System.EventHandler(this.btnCrearPerfil_Click);
            // 
            // PanelNuevoPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 143);
            this.Controls.Add(this.layoutBase);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PanelNuevoPerfil";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelNuevoPerfil";
            this.layoutBase.ResumeLayout(false);
            this.layoutTitulo.ResumeLayout(false);
            this.layoutPanel.ResumeLayout(false);
            this.layoutPerfilesDeshidratacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutBase;
        internal System.Windows.Forms.TableLayoutPanel layoutTitulo;
        private Guna.UI2.WinForms.Guna2ControlBox btnCerrar;
        private System.Windows.Forms.Label TituloPanel;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.TableLayoutPanel layoutPerfilesDeshidratacion;
        private System.Windows.Forms.Label lbSeleccionPerfil;
        private Guna.UI2.WinForms.Guna2Button btnCrearPerfil;
        private Guna.UI2.WinForms.Guna2TextBox tbNombre;
    }
}