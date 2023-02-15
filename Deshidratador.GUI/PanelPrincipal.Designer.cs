namespace Deshidratador.GUI {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPrincipal));
            this.EstiloPanel = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.layoutBase = new System.Windows.Forms.TableLayoutPanel();
            this.layoutDistribucionBase = new System.Windows.Forms.TableLayoutPanel();
            this.layoutTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.btnMaximizarRestaurar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.TituloApp = new System.Windows.Forms.Label();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.layoutPieAplicacion = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbVersionFirmware = new System.Windows.Forms.Label();
            this.lbModulo = new System.Windows.Forms.Label();
            this.lbPoolCounter = new System.Windows.Forms.Label();
            this.lbTrama = new System.Windows.Forms.Label();
            this.layoutAplicacion = new System.Windows.Forms.TableLayoutPanel();
            this.layoutDistribucionComponentes = new System.Windows.Forms.TableLayoutPanel();
            this.layoutDistribucionColumna2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTemperatura = new System.Windows.Forms.Label();
            this.lbVentilador2 = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.layoutDistribucionProceso = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Separator9 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbInicio = new System.Windows.Forms.Label();
            this.indRegimenSecado = new Guna.UI2.WinForms.Guna2Button();
            this.btnInicio = new Guna.UI2.WinForms.Guna2Button();
            this.indRegimenCalentamiento = new Guna.UI2.WinForms.Guna2Button();
            this.btnStop = new Guna.UI2.WinForms.Guna2Button();
            this.lbRegimenes = new System.Windows.Forms.Label();
            this.guna2Separator8 = new Guna.UI2.WinForms.Guna2Separator();
            this.indRegimenDrenado = new Guna.UI2.WinForms.Guna2Button();
            this.layoutDistribucionColumna1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbHumedad = new System.Windows.Forms.Label();
            this.lbVentilador1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.layoutDistribucionVariables = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Separator7 = new Guna.UI2.WinForms.Guna2Separator();
            this.layoutEntradaSalidaAire = new System.Windows.Forms.TableLayoutPanel();
            this.lbMotorDrenaje = new System.Windows.Forms.Label();
            this.interruptorExclusaAire = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.interruptorMotorDrenaje = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lbActuadorExclusa = new System.Windows.Forms.Label();
            this.lbDrenajeAireHumedo = new System.Windows.Forms.Label();
            this.lbCurvaTrabajo = new System.Windows.Forms.Label();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.layoutPerfilesDeshidratacion = new System.Windows.Forms.TableLayoutPanel();
            this.lbSeleccionPerfil = new System.Windows.Forms.Label();
            this.btnCrearPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.PerfilesDeshidratacion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnEliminarPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.layoutValoresPerfil = new System.Windows.Forms.TableLayoutPanel();
            this.lbGrados = new System.Windows.Forms.Label();
            this.lbPorciento = new System.Windows.Forms.Label();
            this.cbEditarValores = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.tbTemperatura = new Guna.UI2.WinForms.Guna2TextBox();
            this.nudValorRelacion = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tbHumedad = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbResistencias = new System.Windows.Forms.Label();
            this.guna2Separator6 = new Guna.UI2.WinForms.Guna2Separator();
            this.layoutResistencias = new System.Windows.Forms.TableLayoutPanel();
            this.lbR7R8 = new System.Windows.Forms.Label();
            this.lbR5R6 = new System.Windows.Forms.Label();
            this.lbR3R4 = new System.Windows.Forms.Label();
            this.interruptorR1R2 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.interruptorR3R4 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.interruptorR5R6 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.interruptorR7R8 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lbR1R2 = new System.Windows.Forms.Label();
            this.layoutMenuLateral = new System.Windows.Forms.TableLayoutPanel();
            this.btnPanelModulos = new Guna.UI2.WinForms.Guna2Button();
            this.ArrastrePanel = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this._temporizadorActualizacion = new System.Windows.Forms.Timer(this.components);
            this.controlTemperatura1 = new CustomComponents.Lib.ControlTemperatura();
            this.controlHumedad1 = new CustomComponents.Lib.ControlHumedad();
            this.curvaDeshidratacion = new CustomComponents.Lib.CurvaDeshidratacion();
            this.controlVentilador1 = new CustomComponents.Lib.ControlVentilador();
            this.controlVentilador2 = new CustomComponents.Lib.ControlVentilador();
            this.layoutBase.SuspendLayout();
            this.layoutDistribucionBase.SuspendLayout();
            this.layoutTitulo.SuspendLayout();
            this.layoutPieAplicacion.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.layoutAplicacion.SuspendLayout();
            this.layoutDistribucionComponentes.SuspendLayout();
            this.layoutDistribucionColumna2.SuspendLayout();
            this.layoutDistribucionProceso.SuspendLayout();
            this.layoutDistribucionColumna1.SuspendLayout();
            this.layoutDistribucionVariables.SuspendLayout();
            this.layoutEntradaSalidaAire.SuspendLayout();
            this.layoutPerfilesDeshidratacion.SuspendLayout();
            this.layoutValoresPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorRelacion)).BeginInit();
            this.layoutResistencias.SuspendLayout();
            this.layoutMenuLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // EstiloPanel
            // 
            this.EstiloPanel.ContainerControl = this;
            // 
            // layoutBase
            // 
            this.layoutBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(35)))), ((int)(((byte)(19)))));
            this.layoutBase.ColumnCount = 1;
            this.layoutBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutBase.Controls.Add(this.layoutDistribucionBase, 0, 0);
            this.layoutBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutBase.Location = new System.Drawing.Point(0, 0);
            this.layoutBase.Margin = new System.Windows.Forms.Padding(1);
            this.layoutBase.Name = "layoutBase";
            this.layoutBase.RowCount = 1;
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutBase.Size = new System.Drawing.Size(1300, 740);
            this.layoutBase.TabIndex = 0;
            // 
            // layoutDistribucionBase
            // 
            this.layoutDistribucionBase.ColumnCount = 1;
            this.layoutDistribucionBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDistribucionBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutDistribucionBase.Controls.Add(this.layoutTitulo, 0, 0);
            this.layoutDistribucionBase.Controls.Add(this.layoutPieAplicacion, 0, 2);
            this.layoutDistribucionBase.Controls.Add(this.layoutAplicacion, 0, 1);
            this.layoutDistribucionBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDistribucionBase.Location = new System.Drawing.Point(1, 1);
            this.layoutDistribucionBase.Margin = new System.Windows.Forms.Padding(1, 1, 2, 1);
            this.layoutDistribucionBase.Name = "layoutDistribucionBase";
            this.layoutDistribucionBase.RowCount = 3;
            this.layoutDistribucionBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutDistribucionBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDistribucionBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.layoutDistribucionBase.Size = new System.Drawing.Size(1297, 738);
            this.layoutDistribucionBase.TabIndex = 0;
            // 
            // layoutTitulo
            // 
            this.layoutTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.layoutTitulo.ColumnCount = 5;
            this.layoutTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutTitulo.Controls.Add(this.btnMaximizarRestaurar, 3, 0);
            this.layoutTitulo.Controls.Add(this.btnCerrar, 4, 0);
            this.layoutTitulo.Controls.Add(this.TituloApp, 1, 0);
            this.layoutTitulo.Controls.Add(this.btnMinimizar, 2, 0);
            this.layoutTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTitulo.Location = new System.Drawing.Point(0, 0);
            this.layoutTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.layoutTitulo.Name = "layoutTitulo";
            this.layoutTitulo.RowCount = 1;
            this.layoutTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTitulo.Size = new System.Drawing.Size(1297, 35);
            this.layoutTitulo.TabIndex = 0;
            // 
            // btnMaximizarRestaurar
            // 
            this.btnMaximizarRestaurar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMaximizarRestaurar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaximizarRestaurar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnMaximizarRestaurar.HoverState.Parent = this.btnMaximizarRestaurar;
            this.btnMaximizarRestaurar.IconColor = System.Drawing.Color.White;
            this.btnMaximizarRestaurar.Location = new System.Drawing.Point(1228, 1);
            this.btnMaximizarRestaurar.Margin = new System.Windows.Forms.Padding(1);
            this.btnMaximizarRestaurar.Name = "btnMaximizarRestaurar";
            this.btnMaximizarRestaurar.ShadowDecoration.Parent = this.btnMaximizarRestaurar;
            this.btnMaximizarRestaurar.Size = new System.Drawing.Size(33, 33);
            this.btnMaximizarRestaurar.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Animated = true;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCerrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnCerrar.HoverState.Parent = this.btnCerrar;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1263, 1);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ShadowDecoration.Parent = this.btnCerrar;
            this.btnCerrar.Size = new System.Drawing.Size(33, 33);
            this.btnCerrar.TabIndex = 0;
            // 
            // TituloApp
            // 
            this.TituloApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TituloApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TituloApp.Location = new System.Drawing.Point(60, 0);
            this.TituloApp.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.TituloApp.Name = "TituloApp";
            this.TituloApp.Size = new System.Drawing.Size(1129, 35);
            this.TituloApp.TabIndex = 2;
            this.TituloApp.Text = "Software de supervisión para deshidratadores v0.1Beta";
            this.TituloApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinimizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnMinimizar.HoverState.Parent = this.btnMinimizar;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(1193, 1);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.ShadowDecoration.Parent = this.btnMinimizar;
            this.btnMinimizar.Size = new System.Drawing.Size(33, 33);
            this.btnMinimizar.TabIndex = 3;
            // 
            // layoutPieAplicacion
            // 
            this.layoutPieAplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(35)))), ((int)(((byte)(19)))));
            this.layoutPieAplicacion.ColumnCount = 5;
            this.layoutPieAplicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutPieAplicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPieAplicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 622F));
            this.layoutPieAplicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.layoutPieAplicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutPieAplicacion.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.layoutPieAplicacion.Controls.Add(this.lbPoolCounter, 3, 0);
            this.layoutPieAplicacion.Controls.Add(this.lbTrama, 2, 0);
            this.layoutPieAplicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPieAplicacion.Location = new System.Drawing.Point(0, 668);
            this.layoutPieAplicacion.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPieAplicacion.Name = "layoutPieAplicacion";
            this.layoutPieAplicacion.RowCount = 1;
            this.layoutPieAplicacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPieAplicacion.Size = new System.Drawing.Size(1297, 70);
            this.layoutPieAplicacion.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbVersionFirmware, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbModulo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(415, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbVersionFirmware
            // 
            this.lbVersionFirmware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVersionFirmware.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVersionFirmware.Location = new System.Drawing.Point(10, 32);
            this.lbVersionFirmware.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lbVersionFirmware.Name = "lbVersionFirmware";
            this.lbVersionFirmware.Size = new System.Drawing.Size(402, 32);
            this.lbVersionFirmware.TabIndex = 4;
            this.lbVersionFirmware.Text = "Versión del Firmware:";
            // 
            // lbModulo
            // 
            this.lbModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbModulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbModulo.Location = new System.Drawing.Point(10, 0);
            this.lbModulo.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lbModulo.Name = "lbModulo";
            this.lbModulo.Size = new System.Drawing.Size(402, 32);
            this.lbModulo.TabIndex = 3;
            this.lbModulo.Text = "Módulo:";
            this.lbModulo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbPoolCounter
            // 
            this.lbPoolCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPoolCounter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbPoolCounter.Location = new System.Drawing.Point(1103, 0);
            this.lbPoolCounter.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lbPoolCounter.Name = "lbPoolCounter";
            this.lbPoolCounter.Size = new System.Drawing.Size(141, 70);
            this.lbPoolCounter.TabIndex = 4;
            this.lbPoolCounter.Text = "Pooling data: 0";
            this.lbPoolCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTrama
            // 
            this.lbTrama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTrama.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTrama.Location = new System.Drawing.Point(481, 0);
            this.lbTrama.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lbTrama.Name = "lbTrama";
            this.lbTrama.Size = new System.Drawing.Size(609, 70);
            this.lbTrama.TabIndex = 5;
            this.lbTrama.Text = "Trama de datos: -";
            this.lbTrama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // layoutAplicacion
            // 
            this.layoutAplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.layoutAplicacion.ColumnCount = 3;
            this.layoutAplicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutAplicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutAplicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutAplicacion.Controls.Add(this.layoutDistribucionComponentes, 1, 0);
            this.layoutAplicacion.Controls.Add(this.layoutMenuLateral, 0, 0);
            this.layoutAplicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutAplicacion.Location = new System.Drawing.Point(0, 35);
            this.layoutAplicacion.Margin = new System.Windows.Forms.Padding(0);
            this.layoutAplicacion.Name = "layoutAplicacion";
            this.layoutAplicacion.RowCount = 1;
            this.layoutAplicacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutAplicacion.Size = new System.Drawing.Size(1297, 633);
            this.layoutAplicacion.TabIndex = 2;
            // 
            // layoutDistribucionComponentes
            // 
            this.layoutDistribucionComponentes.ColumnCount = 5;
            this.layoutDistribucionComponentes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.layoutDistribucionComponentes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.layoutDistribucionComponentes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutDistribucionComponentes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 632F));
            this.layoutDistribucionComponentes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDistribucionComponentes.Controls.Add(this.layoutDistribucionColumna2, 1, 0);
            this.layoutDistribucionComponentes.Controls.Add(this.layoutDistribucionProceso, 4, 0);
            this.layoutDistribucionComponentes.Controls.Add(this.layoutDistribucionColumna1, 0, 0);
            this.layoutDistribucionComponentes.Controls.Add(this.layoutDistribucionVariables, 3, 0);
            this.layoutDistribucionComponentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDistribucionComponentes.Location = new System.Drawing.Point(51, 1);
            this.layoutDistribucionComponentes.Margin = new System.Windows.Forms.Padding(1);
            this.layoutDistribucionComponentes.Name = "layoutDistribucionComponentes";
            this.layoutDistribucionComponentes.RowCount = 1;
            this.layoutDistribucionComponentes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDistribucionComponentes.Size = new System.Drawing.Size(1195, 631);
            this.layoutDistribucionComponentes.TabIndex = 0;
            // 
            // layoutDistribucionColumna2
            // 
            this.layoutDistribucionColumna2.ColumnCount = 1;
            this.layoutDistribucionColumna2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDistribucionColumna2.Controls.Add(this.lbTemperatura, 0, 5);
            this.layoutDistribucionColumna2.Controls.Add(this.lbVentilador2, 0, 1);
            this.layoutDistribucionColumna2.Controls.Add(this.guna2Separator2, 0, 2);
            this.layoutDistribucionColumna2.Controls.Add(this.guna2Separator5, 0, 6);
            this.layoutDistribucionColumna2.Controls.Add(this.controlTemperatura1, 0, 7);
            this.layoutDistribucionColumna2.Controls.Add(this.controlVentilador2, 0, 3);
            this.layoutDistribucionColumna2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDistribucionColumna2.Location = new System.Drawing.Point(200, 0);
            this.layoutDistribucionColumna2.Margin = new System.Windows.Forms.Padding(0);
            this.layoutDistribucionColumna2.Name = "layoutDistribucionColumna2";
            this.layoutDistribucionColumna2.RowCount = 9;
            this.layoutDistribucionColumna2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.layoutDistribucionColumna2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutDistribucionColumna2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.layoutDistribucionColumna2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.layoutDistribucionColumna2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDistribucionColumna2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutDistribucionColumna2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.layoutDistribucionColumna2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.layoutDistribucionColumna2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.layoutDistribucionColumna2.Size = new System.Drawing.Size(200, 631);
            this.layoutDistribucionColumna2.TabIndex = 1;
            // 
            // lbTemperatura
            // 
            this.lbTemperatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTemperatura.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemperatura.ForeColor = System.Drawing.Color.DimGray;
            this.lbTemperatura.Location = new System.Drawing.Point(3, 346);
            this.lbTemperatura.Name = "lbTemperatura";
            this.lbTemperatura.Size = new System.Drawing.Size(194, 28);
            this.lbTemperatura.TabIndex = 6;
            this.lbTemperatura.Text = "Temperatura";
            this.lbTemperatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVentilador2
            // 
            this.lbVentilador2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVentilador2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentilador2.ForeColor = System.Drawing.Color.DimGray;
            this.lbVentilador2.Location = new System.Drawing.Point(3, 10);
            this.lbVentilador2.Name = "lbVentilador2";
            this.lbVentilador2.Size = new System.Drawing.Size(194, 28);
            this.lbVentilador2.TabIndex = 5;
            this.lbVentilador2.Text = "Ventilador 2";
            this.lbVentilador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Separator2.Location = new System.Drawing.Point(5, 38);
            this.guna2Separator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(190, 5);
            this.guna2Separator2.TabIndex = 7;
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Separator5.Location = new System.Drawing.Point(5, 374);
            this.guna2Separator5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(190, 5);
            this.guna2Separator5.TabIndex = 11;
            // 
            // layoutDistribucionProceso
            // 
            this.layoutDistribucionProceso.ColumnCount = 1;
            this.layoutDistribucionProceso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDistribucionProceso.Controls.Add(this.guna2Separator9, 0, 8);
            this.layoutDistribucionProceso.Controls.Add(this.lbInicio, 0, 7);
            this.layoutDistribucionProceso.Controls.Add(this.indRegimenSecado, 0, 4);
            this.layoutDistribucionProceso.Controls.Add(this.btnInicio, 0, 9);
            this.layoutDistribucionProceso.Controls.Add(this.indRegimenCalentamiento, 0, 3);
            this.layoutDistribucionProceso.Controls.Add(this.btnStop, 0, 10);
            this.layoutDistribucionProceso.Controls.Add(this.lbRegimenes, 0, 1);
            this.layoutDistribucionProceso.Controls.Add(this.guna2Separator8, 0, 2);
            this.layoutDistribucionProceso.Controls.Add(this.indRegimenDrenado, 0, 5);
            this.layoutDistribucionProceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDistribucionProceso.Location = new System.Drawing.Point(1057, 0);
            this.layoutDistribucionProceso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 10);
            this.layoutDistribucionProceso.Name = "layoutDistribucionProceso";
            this.layoutDistribucionProceso.RowCount = 11;
            this.layoutDistribucionProceso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.layoutDistribucionProceso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutDistribucionProceso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.layoutDistribucionProceso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.layoutDistribucionProceso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.layoutDistribucionProceso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.layoutDistribucionProceso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.layoutDistribucionProceso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutDistribucionProceso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.layoutDistribucionProceso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDistribucionProceso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDistribucionProceso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutDistribucionProceso.Size = new System.Drawing.Size(133, 621);
            this.layoutDistribucionProceso.TabIndex = 1;
            // 
            // guna2Separator9
            // 
            this.guna2Separator9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Separator9.Location = new System.Drawing.Point(5, 360);
            this.guna2Separator9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.guna2Separator9.Name = "guna2Separator9";
            this.guna2Separator9.Size = new System.Drawing.Size(123, 5);
            this.guna2Separator9.TabIndex = 12;
            // 
            // lbInicio
            // 
            this.lbInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInicio.ForeColor = System.Drawing.Color.DimGray;
            this.lbInicio.Location = new System.Drawing.Point(3, 332);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(127, 28);
            this.lbInicio.TabIndex = 12;
            this.lbInicio.Text = "Inicio";
            this.lbInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // indRegimenSecado
            // 
            this.indRegimenSecado.BorderRadius = 5;
            this.indRegimenSecado.CheckedState.Parent = this.indRegimenSecado;
            this.indRegimenSecado.CustomImages.Parent = this.indRegimenSecado;
            this.indRegimenSecado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indRegimenSecado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.indRegimenSecado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.indRegimenSecado.ForeColor = System.Drawing.Color.White;
            this.indRegimenSecado.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.indRegimenSecado.HoverState.Parent = this.indRegimenSecado;
            this.indRegimenSecado.Image = ((System.Drawing.Image)(resources.GetObject("indRegimenSecado.Image")));
            this.indRegimenSecado.ImageSize = new System.Drawing.Size(80, 80);
            this.indRegimenSecado.Location = new System.Drawing.Point(3, 139);
            this.indRegimenSecado.Name = "indRegimenSecado";
            this.indRegimenSecado.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.indRegimenSecado.ShadowDecoration.Parent = this.indRegimenSecado;
            this.indRegimenSecado.Size = new System.Drawing.Size(127, 87);
            this.indRegimenSecado.TabIndex = 2;
            // 
            // btnInicio
            // 
            this.btnInicio.BorderRadius = 5;
            this.btnInicio.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnInicio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(113)))));
            this.btnInicio.CheckedState.Parent = this.btnInicio;
            this.btnInicio.CustomImages.Parent = this.btnInicio;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.HoverState.Parent = this.btnInicio;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageSize = new System.Drawing.Size(80, 80);
            this.btnInicio.Location = new System.Drawing.Point(3, 368);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.ShadowDecoration.Parent = this.btnInicio;
            this.btnInicio.Size = new System.Drawing.Size(127, 122);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // indRegimenCalentamiento
            // 
            this.indRegimenCalentamiento.BorderRadius = 5;
            this.indRegimenCalentamiento.CheckedState.Parent = this.indRegimenCalentamiento;
            this.indRegimenCalentamiento.CustomImages.Parent = this.indRegimenCalentamiento;
            this.indRegimenCalentamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indRegimenCalentamiento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.indRegimenCalentamiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.indRegimenCalentamiento.ForeColor = System.Drawing.Color.White;
            this.indRegimenCalentamiento.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.indRegimenCalentamiento.HoverState.Parent = this.indRegimenCalentamiento;
            this.indRegimenCalentamiento.Image = ((System.Drawing.Image)(resources.GetObject("indRegimenCalentamiento.Image")));
            this.indRegimenCalentamiento.ImageSize = new System.Drawing.Size(80, 80);
            this.indRegimenCalentamiento.Location = new System.Drawing.Point(3, 46);
            this.indRegimenCalentamiento.Name = "indRegimenCalentamiento";
            this.indRegimenCalentamiento.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.indRegimenCalentamiento.ShadowDecoration.Parent = this.indRegimenCalentamiento;
            this.indRegimenCalentamiento.Size = new System.Drawing.Size(127, 87);
            this.indRegimenCalentamiento.TabIndex = 1;
            // 
            // btnStop
            // 
            this.btnStop.BorderRadius = 5;
            this.btnStop.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStop.Checked = true;
            this.btnStop.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.btnStop.CheckedState.Parent = this.btnStop;
            this.btnStop.CustomImages.Parent = this.btnStop;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.HoverState.Parent = this.btnStop;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageSize = new System.Drawing.Size(80, 80);
            this.btnStop.Location = new System.Drawing.Point(3, 496);
            this.btnStop.Name = "btnStop";
            this.btnStop.ShadowDecoration.Parent = this.btnStop;
            this.btnStop.Size = new System.Drawing.Size(127, 122);
            this.btnStop.TabIndex = 1;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbRegimenes
            // 
            this.lbRegimenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRegimenes.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegimenes.ForeColor = System.Drawing.Color.DimGray;
            this.lbRegimenes.Location = new System.Drawing.Point(3, 10);
            this.lbRegimenes.Name = "lbRegimenes";
            this.lbRegimenes.Size = new System.Drawing.Size(127, 28);
            this.lbRegimenes.TabIndex = 8;
            this.lbRegimenes.Text = "Regímen";
            this.lbRegimenes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator8
            // 
            this.guna2Separator8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Separator8.Location = new System.Drawing.Point(5, 38);
            this.guna2Separator8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.guna2Separator8.Name = "guna2Separator8";
            this.guna2Separator8.Size = new System.Drawing.Size(123, 5);
            this.guna2Separator8.TabIndex = 9;
            // 
            // indRegimenDrenado
            // 
            this.indRegimenDrenado.BorderRadius = 5;
            this.indRegimenDrenado.CheckedState.Parent = this.indRegimenDrenado;
            this.indRegimenDrenado.CustomImages.Parent = this.indRegimenDrenado;
            this.indRegimenDrenado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indRegimenDrenado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.indRegimenDrenado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.indRegimenDrenado.ForeColor = System.Drawing.Color.White;
            this.indRegimenDrenado.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.indRegimenDrenado.HoverState.Parent = this.indRegimenDrenado;
            this.indRegimenDrenado.Image = ((System.Drawing.Image)(resources.GetObject("indRegimenDrenado.Image")));
            this.indRegimenDrenado.ImageSize = new System.Drawing.Size(80, 80);
            this.indRegimenDrenado.Location = new System.Drawing.Point(3, 232);
            this.indRegimenDrenado.Name = "indRegimenDrenado";
            this.indRegimenDrenado.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.indRegimenDrenado.ShadowDecoration.Parent = this.indRegimenDrenado;
            this.indRegimenDrenado.Size = new System.Drawing.Size(127, 87);
            this.indRegimenDrenado.TabIndex = 10;
            // 
            // layoutDistribucionColumna1
            // 
            this.layoutDistribucionColumna1.ColumnCount = 1;
            this.layoutDistribucionColumna1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDistribucionColumna1.Controls.Add(this.lbHumedad, 0, 5);
            this.layoutDistribucionColumna1.Controls.Add(this.lbVentilador1, 0, 1);
            this.layoutDistribucionColumna1.Controls.Add(this.guna2Separator1, 0, 2);
            this.layoutDistribucionColumna1.Controls.Add(this.guna2Separator4, 0, 6);
            this.layoutDistribucionColumna1.Controls.Add(this.controlHumedad1, 0, 7);
            this.layoutDistribucionColumna1.Controls.Add(this.controlVentilador1, 0, 3);
            this.layoutDistribucionColumna1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDistribucionColumna1.Location = new System.Drawing.Point(0, 0);
            this.layoutDistribucionColumna1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutDistribucionColumna1.Name = "layoutDistribucionColumna1";
            this.layoutDistribucionColumna1.RowCount = 9;
            this.layoutDistribucionColumna1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.layoutDistribucionColumna1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutDistribucionColumna1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.layoutDistribucionColumna1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.layoutDistribucionColumna1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDistribucionColumna1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutDistribucionColumna1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.layoutDistribucionColumna1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.layoutDistribucionColumna1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.layoutDistribucionColumna1.Size = new System.Drawing.Size(200, 631);
            this.layoutDistribucionColumna1.TabIndex = 0;
            // 
            // lbHumedad
            // 
            this.lbHumedad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHumedad.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHumedad.ForeColor = System.Drawing.Color.DimGray;
            this.lbHumedad.Location = new System.Drawing.Point(3, 346);
            this.lbHumedad.Name = "lbHumedad";
            this.lbHumedad.Size = new System.Drawing.Size(194, 28);
            this.lbHumedad.TabIndex = 5;
            this.lbHumedad.Text = "Humedad";
            this.lbHumedad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVentilador1
            // 
            this.lbVentilador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVentilador1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentilador1.ForeColor = System.Drawing.Color.DimGray;
            this.lbVentilador1.Location = new System.Drawing.Point(3, 10);
            this.lbVentilador1.Name = "lbVentilador1";
            this.lbVentilador1.Size = new System.Drawing.Size(194, 28);
            this.lbVentilador1.TabIndex = 4;
            this.lbVentilador1.Text = "Ventilador 1";
            this.lbVentilador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Separator1.Location = new System.Drawing.Point(5, 38);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(190, 5);
            this.guna2Separator1.TabIndex = 6;
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Separator4.Location = new System.Drawing.Point(5, 374);
            this.guna2Separator4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(190, 5);
            this.guna2Separator4.TabIndex = 10;
            // 
            // layoutDistribucionVariables
            // 
            this.layoutDistribucionVariables.ColumnCount = 1;
            this.layoutDistribucionVariables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDistribucionVariables.Controls.Add(this.guna2Separator7, 0, 6);
            this.layoutDistribucionVariables.Controls.Add(this.layoutEntradaSalidaAire, 0, 7);
            this.layoutDistribucionVariables.Controls.Add(this.lbDrenajeAireHumedo, 0, 5);
            this.layoutDistribucionVariables.Controls.Add(this.lbCurvaTrabajo, 0, 9);
            this.layoutDistribucionVariables.Controls.Add(this.guna2Separator3, 0, 10);
            this.layoutDistribucionVariables.Controls.Add(this.layoutPerfilesDeshidratacion, 0, 11);
            this.layoutDistribucionVariables.Controls.Add(this.layoutValoresPerfil, 0, 12);
            this.layoutDistribucionVariables.Controls.Add(this.lbResistencias, 0, 1);
            this.layoutDistribucionVariables.Controls.Add(this.guna2Separator6, 0, 2);
            this.layoutDistribucionVariables.Controls.Add(this.layoutResistencias, 0, 3);
            this.layoutDistribucionVariables.Controls.Add(this.curvaDeshidratacion, 0, 14);
            this.layoutDistribucionVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDistribucionVariables.Location = new System.Drawing.Point(420, 0);
            this.layoutDistribucionVariables.Margin = new System.Windows.Forms.Padding(0);
            this.layoutDistribucionVariables.Name = "layoutDistribucionVariables";
            this.layoutDistribucionVariables.RowCount = 16;
            this.layoutDistribucionVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.layoutDistribucionVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutDistribucionVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.layoutDistribucionVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.layoutDistribucionVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.layoutDistribucionVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutDistribucionVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.layoutDistribucionVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.layoutDistribucionVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.layoutDistribucionVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutDistribucionVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.layoutDistribucionVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutDistribucionVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutDistribucionVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.layoutDistribucionVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDistribucionVariables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.layoutDistribucionVariables.Size = new System.Drawing.Size(632, 631);
            this.layoutDistribucionVariables.TabIndex = 2;
            // 
            // guna2Separator7
            // 
            this.guna2Separator7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Separator7.Location = new System.Drawing.Point(5, 134);
            this.guna2Separator7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.guna2Separator7.Name = "guna2Separator7";
            this.guna2Separator7.Size = new System.Drawing.Size(622, 5);
            this.guna2Separator7.TabIndex = 9;
            // 
            // layoutEntradaSalidaAire
            // 
            this.layoutEntradaSalidaAire.ColumnCount = 4;
            this.layoutEntradaSalidaAire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layoutEntradaSalidaAire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutEntradaSalidaAire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layoutEntradaSalidaAire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutEntradaSalidaAire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutEntradaSalidaAire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutEntradaSalidaAire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutEntradaSalidaAire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutEntradaSalidaAire.Controls.Add(this.lbMotorDrenaje, 3, 0);
            this.layoutEntradaSalidaAire.Controls.Add(this.interruptorExclusaAire, 0, 0);
            this.layoutEntradaSalidaAire.Controls.Add(this.interruptorMotorDrenaje, 2, 0);
            this.layoutEntradaSalidaAire.Controls.Add(this.lbActuadorExclusa, 1, 0);
            this.layoutEntradaSalidaAire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutEntradaSalidaAire.Location = new System.Drawing.Point(5, 139);
            this.layoutEntradaSalidaAire.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.layoutEntradaSalidaAire.Name = "layoutEntradaSalidaAire";
            this.layoutEntradaSalidaAire.RowCount = 1;
            this.layoutEntradaSalidaAire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutEntradaSalidaAire.Size = new System.Drawing.Size(622, 32);
            this.layoutEntradaSalidaAire.TabIndex = 13;
            // 
            // lbMotorDrenaje
            // 
            this.lbMotorDrenaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMotorDrenaje.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotorDrenaje.ForeColor = System.Drawing.Color.DimGray;
            this.lbMotorDrenaje.Location = new System.Drawing.Point(374, 0);
            this.lbMotorDrenaje.Name = "lbMotorDrenaje";
            this.lbMotorDrenaje.Size = new System.Drawing.Size(245, 32);
            this.lbMotorDrenaje.TabIndex = 8;
            this.lbMotorDrenaje.Text = "Motor de drenaje";
            this.lbMotorDrenaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // interruptorExclusaAire
            // 
            this.interruptorExclusaAire.Animated = true;
            this.interruptorExclusaAire.AutoRoundedCorners = true;
            this.interruptorExclusaAire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.interruptorExclusaAire.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(35)))), ((int)(((byte)(19)))));
            this.interruptorExclusaAire.CheckedState.BorderRadius = 12;
            this.interruptorExclusaAire.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
            this.interruptorExclusaAire.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.interruptorExclusaAire.CheckedState.InnerBorderRadius = 8;
            this.interruptorExclusaAire.CheckedState.InnerColor = System.Drawing.Color.White;
            this.interruptorExclusaAire.CheckedState.Parent = this.interruptorExclusaAire;
            this.interruptorExclusaAire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interruptorExclusaAire.Location = new System.Drawing.Point(0, 3);
            this.interruptorExclusaAire.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.interruptorExclusaAire.Name = "interruptorExclusaAire";
            this.interruptorExclusaAire.ShadowDecoration.Parent = this.interruptorExclusaAire;
            this.interruptorExclusaAire.Size = new System.Drawing.Size(60, 26);
            this.interruptorExclusaAire.TabIndex = 3;
            this.interruptorExclusaAire.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.interruptorExclusaAire.UncheckedState.BorderRadius = 12;
            this.interruptorExclusaAire.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.interruptorExclusaAire.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.interruptorExclusaAire.UncheckedState.InnerBorderRadius = 8;
            this.interruptorExclusaAire.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.interruptorExclusaAire.UncheckedState.Parent = this.interruptorExclusaAire;
            // 
            // interruptorMotorDrenaje
            // 
            this.interruptorMotorDrenaje.Animated = true;
            this.interruptorMotorDrenaje.AutoRoundedCorners = true;
            this.interruptorMotorDrenaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.interruptorMotorDrenaje.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(35)))), ((int)(((byte)(19)))));
            this.interruptorMotorDrenaje.CheckedState.BorderRadius = 12;
            this.interruptorMotorDrenaje.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
            this.interruptorMotorDrenaje.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.interruptorMotorDrenaje.CheckedState.InnerBorderRadius = 8;
            this.interruptorMotorDrenaje.CheckedState.InnerColor = System.Drawing.Color.White;
            this.interruptorMotorDrenaje.CheckedState.Parent = this.interruptorMotorDrenaje;
            this.interruptorMotorDrenaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interruptorMotorDrenaje.Location = new System.Drawing.Point(311, 3);
            this.interruptorMotorDrenaje.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.interruptorMotorDrenaje.Name = "interruptorMotorDrenaje";
            this.interruptorMotorDrenaje.ShadowDecoration.Parent = this.interruptorMotorDrenaje;
            this.interruptorMotorDrenaje.Size = new System.Drawing.Size(60, 26);
            this.interruptorMotorDrenaje.TabIndex = 4;
            this.interruptorMotorDrenaje.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.interruptorMotorDrenaje.UncheckedState.BorderRadius = 12;
            this.interruptorMotorDrenaje.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.interruptorMotorDrenaje.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.interruptorMotorDrenaje.UncheckedState.InnerBorderRadius = 8;
            this.interruptorMotorDrenaje.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.interruptorMotorDrenaje.UncheckedState.Parent = this.interruptorMotorDrenaje;
            // 
            // lbActuadorExclusa
            // 
            this.lbActuadorExclusa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbActuadorExclusa.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActuadorExclusa.ForeColor = System.Drawing.Color.DimGray;
            this.lbActuadorExclusa.Location = new System.Drawing.Point(63, 0);
            this.lbActuadorExclusa.Name = "lbActuadorExclusa";
            this.lbActuadorExclusa.Size = new System.Drawing.Size(245, 32);
            this.lbActuadorExclusa.TabIndex = 7;
            this.lbActuadorExclusa.Text = "Exclusa de aire";
            this.lbActuadorExclusa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDrenajeAireHumedo
            // 
            this.lbDrenajeAireHumedo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDrenajeAireHumedo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrenajeAireHumedo.ForeColor = System.Drawing.Color.DimGray;
            this.lbDrenajeAireHumedo.Location = new System.Drawing.Point(3, 106);
            this.lbDrenajeAireHumedo.Name = "lbDrenajeAireHumedo";
            this.lbDrenajeAireHumedo.Size = new System.Drawing.Size(626, 28);
            this.lbDrenajeAireHumedo.TabIndex = 7;
            this.lbDrenajeAireHumedo.Text = "Drenaje de aire húmedo";
            this.lbDrenajeAireHumedo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCurvaTrabajo
            // 
            this.lbCurvaTrabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCurvaTrabajo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurvaTrabajo.ForeColor = System.Drawing.Color.DimGray;
            this.lbCurvaTrabajo.Location = new System.Drawing.Point(3, 202);
            this.lbCurvaTrabajo.Name = "lbCurvaTrabajo";
            this.lbCurvaTrabajo.Size = new System.Drawing.Size(626, 28);
            this.lbCurvaTrabajo.TabIndex = 7;
            this.lbCurvaTrabajo.Text = "Curva de trabajo para la deshidratación del producto";
            this.lbCurvaTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Separator3.Location = new System.Drawing.Point(5, 230);
            this.guna2Separator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(622, 5);
            this.guna2Separator3.TabIndex = 9;
            // 
            // layoutPerfilesDeshidratacion
            // 
            this.layoutPerfilesDeshidratacion.ColumnCount = 4;
            this.layoutPerfilesDeshidratacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.layoutPerfilesDeshidratacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPerfilesDeshidratacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.layoutPerfilesDeshidratacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutPerfilesDeshidratacion.Controls.Add(this.lbSeleccionPerfil, 0, 0);
            this.layoutPerfilesDeshidratacion.Controls.Add(this.btnCrearPerfil, 2, 0);
            this.layoutPerfilesDeshidratacion.Controls.Add(this.PerfilesDeshidratacion, 1, 0);
            this.layoutPerfilesDeshidratacion.Controls.Add(this.btnEliminarPerfil, 3, 0);
            this.layoutPerfilesDeshidratacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPerfilesDeshidratacion.Location = new System.Drawing.Point(0, 235);
            this.layoutPerfilesDeshidratacion.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPerfilesDeshidratacion.Name = "layoutPerfilesDeshidratacion";
            this.layoutPerfilesDeshidratacion.RowCount = 1;
            this.layoutPerfilesDeshidratacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPerfilesDeshidratacion.Size = new System.Drawing.Size(632, 35);
            this.layoutPerfilesDeshidratacion.TabIndex = 10;
            // 
            // lbSeleccionPerfil
            // 
            this.lbSeleccionPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSeleccionPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSeleccionPerfil.Location = new System.Drawing.Point(5, 0);
            this.lbSeleccionPerfil.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lbSeleccionPerfil.Name = "lbSeleccionPerfil";
            this.lbSeleccionPerfil.Size = new System.Drawing.Size(172, 35);
            this.lbSeleccionPerfil.TabIndex = 3;
            this.lbSeleccionPerfil.Text = "Seleccione un perfil rápido";
            this.lbSeleccionPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnCrearPerfil.Location = new System.Drawing.Point(435, 3);
            this.btnCrearPerfil.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.btnCrearPerfil.Name = "btnCrearPerfil";
            this.btnCrearPerfil.ShadowDecoration.Parent = this.btnCrearPerfil;
            this.btnCrearPerfil.Size = new System.Drawing.Size(157, 29);
            this.btnCrearPerfil.TabIndex = 5;
            this.btnCrearPerfil.Text = "Nuevo perfil";
            this.btnCrearPerfil.Click += new System.EventHandler(this.btnCrearPerfil_Click);
            // 
            // PerfilesDeshidratacion
            // 
            this.PerfilesDeshidratacion.BackColor = System.Drawing.Color.Transparent;
            this.PerfilesDeshidratacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PerfilesDeshidratacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PerfilesDeshidratacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PerfilesDeshidratacion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
            this.PerfilesDeshidratacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
            this.PerfilesDeshidratacion.FocusedState.Parent = this.PerfilesDeshidratacion;
            this.PerfilesDeshidratacion.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.PerfilesDeshidratacion.ForeColor = System.Drawing.Color.Black;
            this.PerfilesDeshidratacion.HoverState.Parent = this.PerfilesDeshidratacion;
            this.PerfilesDeshidratacion.ItemHeight = 24;
            this.PerfilesDeshidratacion.ItemsAppearance.Parent = this.PerfilesDeshidratacion;
            this.PerfilesDeshidratacion.Location = new System.Drawing.Point(183, 3);
            this.PerfilesDeshidratacion.Name = "PerfilesDeshidratacion";
            this.PerfilesDeshidratacion.ShadowDecoration.Parent = this.PerfilesDeshidratacion;
            this.PerfilesDeshidratacion.Size = new System.Drawing.Size(246, 30);
            this.PerfilesDeshidratacion.TabIndex = 4;
            this.PerfilesDeshidratacion.SelectedIndexChanged += new System.EventHandler(this.cbPerfilDeshidratacion_SelectedIndexChanged);
            // 
            // btnEliminarPerfil
            // 
            this.btnEliminarPerfil.BorderRadius = 5;
            this.btnEliminarPerfil.CheckedState.Parent = this.btnEliminarPerfil;
            this.btnEliminarPerfil.CustomImages.Parent = this.btnEliminarPerfil;
            this.btnEliminarPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminarPerfil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
            this.btnEliminarPerfil.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btnEliminarPerfil.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPerfil.HoverState.Parent = this.btnEliminarPerfil;
            this.btnEliminarPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarPerfil.Image")));
            this.btnEliminarPerfil.ImageSize = new System.Drawing.Size(16, 16);
            this.btnEliminarPerfil.Location = new System.Drawing.Point(600, 3);
            this.btnEliminarPerfil.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.btnEliminarPerfil.Name = "btnEliminarPerfil";
            this.btnEliminarPerfil.ShadowDecoration.Parent = this.btnEliminarPerfil;
            this.btnEliminarPerfil.Size = new System.Drawing.Size(27, 29);
            this.btnEliminarPerfil.TabIndex = 6;
            this.btnEliminarPerfil.Click += new System.EventHandler(this.btnEliminarPerfil_Click);
            // 
            // layoutValoresPerfil
            // 
            this.layoutValoresPerfil.ColumnCount = 7;
            this.layoutValoresPerfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.layoutValoresPerfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.layoutValoresPerfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutValoresPerfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.layoutValoresPerfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutValoresPerfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.layoutValoresPerfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.layoutValoresPerfil.Controls.Add(this.lbGrados, 5, 0);
            this.layoutValoresPerfil.Controls.Add(this.lbPorciento, 3, 0);
            this.layoutValoresPerfil.Controls.Add(this.cbEditarValores, 0, 0);
            this.layoutValoresPerfil.Controls.Add(this.btnModificar, 6, 0);
            this.layoutValoresPerfil.Controls.Add(this.tbTemperatura, 4, 0);
            this.layoutValoresPerfil.Controls.Add(this.nudValorRelacion, 1, 0);
            this.layoutValoresPerfil.Controls.Add(this.tbHumedad, 2, 0);
            this.layoutValoresPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutValoresPerfil.Location = new System.Drawing.Point(0, 270);
            this.layoutValoresPerfil.Margin = new System.Windows.Forms.Padding(0);
            this.layoutValoresPerfil.Name = "layoutValoresPerfil";
            this.layoutValoresPerfil.RowCount = 1;
            this.layoutValoresPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutValoresPerfil.Size = new System.Drawing.Size(632, 35);
            this.layoutValoresPerfil.TabIndex = 1;
            // 
            // lbGrados
            // 
            this.lbGrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbGrados.Location = new System.Drawing.Point(406, 0);
            this.lbGrados.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lbGrados.Name = "lbGrados";
            this.lbGrados.Size = new System.Drawing.Size(23, 35);
            this.lbGrados.TabIndex = 5;
            this.lbGrados.Text = "°C";
            this.lbGrados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPorciento
            // 
            this.lbPorciento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPorciento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPorciento.Location = new System.Drawing.Point(307, 0);
            this.lbPorciento.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lbPorciento.Name = "lbPorciento";
            this.lbPorciento.Size = new System.Drawing.Size(23, 35);
            this.lbPorciento.TabIndex = 4;
            this.lbPorciento.Text = "%";
            this.lbPorciento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbEditarValores
            // 
            this.cbEditarValores.AutoSize = true;
            this.cbEditarValores.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
            this.cbEditarValores.CheckedState.BorderRadius = 0;
            this.cbEditarValores.CheckedState.BorderThickness = 0;
            this.cbEditarValores.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
            this.cbEditarValores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEditarValores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbEditarValores.Location = new System.Drawing.Point(8, 3);
            this.cbEditarValores.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.cbEditarValores.Name = "cbEditarValores";
            this.cbEditarValores.Size = new System.Drawing.Size(169, 29);
            this.cbEditarValores.TabIndex = 0;
            this.cbEditarValores.Text = "Editar valores actuales";
            this.cbEditarValores.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.cbEditarValores.UncheckedState.BorderRadius = 0;
            this.cbEditarValores.UncheckedState.BorderThickness = 0;
            this.cbEditarValores.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.cbEditarValores.CheckedChanged += new System.EventHandler(this.cbEditarValores_CheckedChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.BorderRadius = 5;
            this.btnModificar.CheckedState.Parent = this.btnModificar;
            this.btnModificar.CustomImages.Parent = this.btnModificar;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificar.Enabled = false;
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.HoverState.Parent = this.btnModificar;
            this.btnModificar.Location = new System.Drawing.Point(435, 3);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ShadowDecoration.Parent = this.btnModificar;
            this.btnModificar.Size = new System.Drawing.Size(192, 29);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tbTemperatura
            // 
            this.tbTemperatura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTemperatura.DefaultText = "";
            this.tbTemperatura.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTemperatura.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTemperatura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTemperatura.DisabledState.Parent = this.tbTemperatura;
            this.tbTemperatura.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTemperatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTemperatura.Enabled = false;
            this.tbTemperatura.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTemperatura.FocusedState.Parent = this.tbTemperatura;
            this.tbTemperatura.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.tbTemperatura.ForeColor = System.Drawing.Color.Black;
            this.tbTemperatura.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTemperatura.HoverState.Parent = this.tbTemperatura;
            this.tbTemperatura.Location = new System.Drawing.Point(336, 4);
            this.tbTemperatura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTemperatura.Name = "tbTemperatura";
            this.tbTemperatura.PasswordChar = '\0';
            this.tbTemperatura.PlaceholderText = "T";
            this.tbTemperatura.SelectedText = "";
            this.tbTemperatura.ShadowDecoration.Parent = this.tbTemperatura;
            this.tbTemperatura.Size = new System.Drawing.Size(67, 27);
            this.tbTemperatura.TabIndex = 7;
            this.tbTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudValorRelacion
            // 
            this.nudValorRelacion.BackColor = System.Drawing.Color.Transparent;
            this.nudValorRelacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudValorRelacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudValorRelacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudValorRelacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudValorRelacion.DisabledState.Parent = this.nudValorRelacion;
            this.nudValorRelacion.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudValorRelacion.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudValorRelacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudValorRelacion.Enabled = false;
            this.nudValorRelacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudValorRelacion.FocusedState.Parent = this.nudValorRelacion;
            this.nudValorRelacion.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.nudValorRelacion.ForeColor = System.Drawing.Color.Black;
            this.nudValorRelacion.Location = new System.Drawing.Point(183, 4);
            this.nudValorRelacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudValorRelacion.Name = "nudValorRelacion";
            this.nudValorRelacion.ShadowDecoration.Parent = this.nudValorRelacion;
            this.nudValorRelacion.Size = new System.Drawing.Size(48, 27);
            this.nudValorRelacion.TabIndex = 5;
            this.nudValorRelacion.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
            this.nudValorRelacion.ValueChanged += new System.EventHandler(this.nudValorRelacion_ValueChanged);
            // 
            // tbHumedad
            // 
            this.tbHumedad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHumedad.DefaultText = "";
            this.tbHumedad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbHumedad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbHumedad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbHumedad.DisabledState.Parent = this.tbHumedad;
            this.tbHumedad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbHumedad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHumedad.Enabled = false;
            this.tbHumedad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbHumedad.FocusedState.Parent = this.tbHumedad;
            this.tbHumedad.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.tbHumedad.ForeColor = System.Drawing.Color.Black;
            this.tbHumedad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbHumedad.HoverState.Parent = this.tbHumedad;
            this.tbHumedad.Location = new System.Drawing.Point(237, 4);
            this.tbHumedad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbHumedad.Name = "tbHumedad";
            this.tbHumedad.PasswordChar = '\0';
            this.tbHumedad.PlaceholderText = "H";
            this.tbHumedad.SelectedText = "";
            this.tbHumedad.ShadowDecoration.Parent = this.tbHumedad;
            this.tbHumedad.Size = new System.Drawing.Size(67, 27);
            this.tbHumedad.TabIndex = 6;
            this.tbHumedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbResistencias
            // 
            this.lbResistencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResistencias.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResistencias.ForeColor = System.Drawing.Color.DimGray;
            this.lbResistencias.Location = new System.Drawing.Point(3, 10);
            this.lbResistencias.Name = "lbResistencias";
            this.lbResistencias.Size = new System.Drawing.Size(626, 28);
            this.lbResistencias.TabIndex = 6;
            this.lbResistencias.Text = "Resistencias";
            this.lbResistencias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator6
            // 
            this.guna2Separator6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Separator6.Location = new System.Drawing.Point(5, 38);
            this.guna2Separator6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.guna2Separator6.Name = "guna2Separator6";
            this.guna2Separator6.Size = new System.Drawing.Size(622, 5);
            this.guna2Separator6.TabIndex = 8;
            // 
            // layoutResistencias
            // 
            this.layoutResistencias.ColumnCount = 8;
            this.layoutResistencias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layoutResistencias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutResistencias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layoutResistencias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutResistencias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layoutResistencias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutResistencias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layoutResistencias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutResistencias.Controls.Add(this.lbR7R8, 7, 0);
            this.layoutResistencias.Controls.Add(this.lbR5R6, 5, 0);
            this.layoutResistencias.Controls.Add(this.lbR3R4, 3, 0);
            this.layoutResistencias.Controls.Add(this.interruptorR1R2, 0, 0);
            this.layoutResistencias.Controls.Add(this.interruptorR3R4, 2, 0);
            this.layoutResistencias.Controls.Add(this.interruptorR5R6, 4, 0);
            this.layoutResistencias.Controls.Add(this.interruptorR7R8, 6, 0);
            this.layoutResistencias.Controls.Add(this.lbR1R2, 1, 0);
            this.layoutResistencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutResistencias.Location = new System.Drawing.Point(5, 43);
            this.layoutResistencias.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.layoutResistencias.Name = "layoutResistencias";
            this.layoutResistencias.RowCount = 1;
            this.layoutResistencias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutResistencias.Size = new System.Drawing.Size(622, 32);
            this.layoutResistencias.TabIndex = 12;
            // 
            // lbR7R8
            // 
            this.lbR7R8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbR7R8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR7R8.ForeColor = System.Drawing.Color.DimGray;
            this.lbR7R8.Location = new System.Drawing.Point(528, 0);
            this.lbR7R8.Name = "lbR7R8";
            this.lbR7R8.Size = new System.Drawing.Size(91, 32);
            this.lbR7R8.TabIndex = 8;
            this.lbR7R8.Text = "R7 | R8";
            this.lbR7R8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbR5R6
            // 
            this.lbR5R6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbR5R6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR5R6.ForeColor = System.Drawing.Color.DimGray;
            this.lbR5R6.Location = new System.Drawing.Point(373, 0);
            this.lbR5R6.Name = "lbR5R6";
            this.lbR5R6.Size = new System.Drawing.Size(89, 32);
            this.lbR5R6.TabIndex = 8;
            this.lbR5R6.Text = "R5 | R6";
            this.lbR5R6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbR3R4
            // 
            this.lbR3R4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbR3R4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR3R4.ForeColor = System.Drawing.Color.DimGray;
            this.lbR3R4.Location = new System.Drawing.Point(218, 0);
            this.lbR3R4.Name = "lbR3R4";
            this.lbR3R4.Size = new System.Drawing.Size(89, 32);
            this.lbR3R4.TabIndex = 8;
            this.lbR3R4.Text = "R3 | R4";
            this.lbR3R4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // interruptorR1R2
            // 
            this.interruptorR1R2.Animated = true;
            this.interruptorR1R2.AutoRoundedCorners = true;
            this.interruptorR1R2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.interruptorR1R2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(35)))), ((int)(((byte)(19)))));
            this.interruptorR1R2.CheckedState.BorderRadius = 12;
            this.interruptorR1R2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
            this.interruptorR1R2.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.interruptorR1R2.CheckedState.InnerBorderRadius = 8;
            this.interruptorR1R2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.interruptorR1R2.CheckedState.Parent = this.interruptorR1R2;
            this.interruptorR1R2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interruptorR1R2.Location = new System.Drawing.Point(0, 3);
            this.interruptorR1R2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.interruptorR1R2.Name = "interruptorR1R2";
            this.interruptorR1R2.ShadowDecoration.Parent = this.interruptorR1R2;
            this.interruptorR1R2.Size = new System.Drawing.Size(60, 26);
            this.interruptorR1R2.TabIndex = 3;
            this.interruptorR1R2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.interruptorR1R2.UncheckedState.BorderRadius = 12;
            this.interruptorR1R2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.interruptorR1R2.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.interruptorR1R2.UncheckedState.InnerBorderRadius = 8;
            this.interruptorR1R2.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.interruptorR1R2.UncheckedState.Parent = this.interruptorR1R2;
            // 
            // interruptorR3R4
            // 
            this.interruptorR3R4.Animated = true;
            this.interruptorR3R4.AutoRoundedCorners = true;
            this.interruptorR3R4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.interruptorR3R4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(35)))), ((int)(((byte)(19)))));
            this.interruptorR3R4.CheckedState.BorderRadius = 12;
            this.interruptorR3R4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
            this.interruptorR3R4.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.interruptorR3R4.CheckedState.InnerBorderRadius = 8;
            this.interruptorR3R4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.interruptorR3R4.CheckedState.Parent = this.interruptorR3R4;
            this.interruptorR3R4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interruptorR3R4.Location = new System.Drawing.Point(155, 3);
            this.interruptorR3R4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.interruptorR3R4.Name = "interruptorR3R4";
            this.interruptorR3R4.ShadowDecoration.Parent = this.interruptorR3R4;
            this.interruptorR3R4.Size = new System.Drawing.Size(60, 26);
            this.interruptorR3R4.TabIndex = 4;
            this.interruptorR3R4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.interruptorR3R4.UncheckedState.BorderRadius = 12;
            this.interruptorR3R4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.interruptorR3R4.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.interruptorR3R4.UncheckedState.InnerBorderRadius = 8;
            this.interruptorR3R4.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.interruptorR3R4.UncheckedState.Parent = this.interruptorR3R4;
            // 
            // interruptorR5R6
            // 
            this.interruptorR5R6.Animated = true;
            this.interruptorR5R6.AutoRoundedCorners = true;
            this.interruptorR5R6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.interruptorR5R6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(35)))), ((int)(((byte)(19)))));
            this.interruptorR5R6.CheckedState.BorderRadius = 12;
            this.interruptorR5R6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
            this.interruptorR5R6.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.interruptorR5R6.CheckedState.InnerBorderRadius = 8;
            this.interruptorR5R6.CheckedState.InnerColor = System.Drawing.Color.White;
            this.interruptorR5R6.CheckedState.Parent = this.interruptorR5R6;
            this.interruptorR5R6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interruptorR5R6.Location = new System.Drawing.Point(310, 3);
            this.interruptorR5R6.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.interruptorR5R6.Name = "interruptorR5R6";
            this.interruptorR5R6.ShadowDecoration.Parent = this.interruptorR5R6;
            this.interruptorR5R6.Size = new System.Drawing.Size(60, 26);
            this.interruptorR5R6.TabIndex = 5;
            this.interruptorR5R6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.interruptorR5R6.UncheckedState.BorderRadius = 12;
            this.interruptorR5R6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.interruptorR5R6.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.interruptorR5R6.UncheckedState.InnerBorderRadius = 8;
            this.interruptorR5R6.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.interruptorR5R6.UncheckedState.Parent = this.interruptorR5R6;
            // 
            // interruptorR7R8
            // 
            this.interruptorR7R8.Animated = true;
            this.interruptorR7R8.AutoRoundedCorners = true;
            this.interruptorR7R8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.interruptorR7R8.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(35)))), ((int)(((byte)(19)))));
            this.interruptorR7R8.CheckedState.BorderRadius = 12;
            this.interruptorR7R8.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
            this.interruptorR7R8.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.interruptorR7R8.CheckedState.InnerBorderRadius = 8;
            this.interruptorR7R8.CheckedState.InnerColor = System.Drawing.Color.White;
            this.interruptorR7R8.CheckedState.Parent = this.interruptorR7R8;
            this.interruptorR7R8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interruptorR7R8.Location = new System.Drawing.Point(465, 3);
            this.interruptorR7R8.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.interruptorR7R8.Name = "interruptorR7R8";
            this.interruptorR7R8.ShadowDecoration.Parent = this.interruptorR7R8;
            this.interruptorR7R8.Size = new System.Drawing.Size(60, 26);
            this.interruptorR7R8.TabIndex = 6;
            this.interruptorR7R8.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.interruptorR7R8.UncheckedState.BorderRadius = 12;
            this.interruptorR7R8.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.interruptorR7R8.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.interruptorR7R8.UncheckedState.InnerBorderRadius = 8;
            this.interruptorR7R8.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.interruptorR7R8.UncheckedState.Parent = this.interruptorR7R8;
            // 
            // lbR1R2
            // 
            this.lbR1R2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbR1R2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR1R2.ForeColor = System.Drawing.Color.DimGray;
            this.lbR1R2.Location = new System.Drawing.Point(63, 0);
            this.lbR1R2.Name = "lbR1R2";
            this.lbR1R2.Size = new System.Drawing.Size(89, 32);
            this.lbR1R2.TabIndex = 7;
            this.lbR1R2.Text = "R1 | R2";
            this.lbR1R2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // layoutMenuLateral
            // 
            this.layoutMenuLateral.ColumnCount = 1;
            this.layoutMenuLateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMenuLateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutMenuLateral.Controls.Add(this.btnPanelModulos, 0, 0);
            this.layoutMenuLateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.layoutMenuLateral.Margin = new System.Windows.Forms.Padding(0);
            this.layoutMenuLateral.Name = "layoutMenuLateral";
            this.layoutMenuLateral.RowCount = 2;
            this.layoutMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMenuLateral.Size = new System.Drawing.Size(50, 633);
            this.layoutMenuLateral.TabIndex = 1;
            // 
            // btnPanelModulos
            // 
            this.btnPanelModulos.BorderRadius = 5;
            this.btnPanelModulos.CheckedState.Parent = this.btnPanelModulos;
            this.btnPanelModulos.CustomImages.Parent = this.btnPanelModulos;
            this.btnPanelModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPanelModulos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.btnPanelModulos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPanelModulos.ForeColor = System.Drawing.Color.White;
            this.btnPanelModulos.HoverState.Parent = this.btnPanelModulos;
            this.btnPanelModulos.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelModulos.Image")));
            this.btnPanelModulos.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPanelModulos.Location = new System.Drawing.Point(2, 2);
            this.btnPanelModulos.Margin = new System.Windows.Forms.Padding(2);
            this.btnPanelModulos.Name = "btnPanelModulos";
            this.btnPanelModulos.ShadowDecoration.Parent = this.btnPanelModulos;
            this.btnPanelModulos.Size = new System.Drawing.Size(46, 46);
            this.btnPanelModulos.TabIndex = 0;
            this.btnPanelModulos.Click += new System.EventHandler(this.btnPanelModulos_Click);
            // 
            // ArrastrePanel
            // 
            this.ArrastrePanel.ContainerControl = this;
            this.ArrastrePanel.TargetControl = this.TituloApp;
            // 
            // _temporizadorActualizacion
            // 
            this._temporizadorActualizacion.Interval = 2000;
            this._temporizadorActualizacion.Tick += new System.EventHandler(this.temporizadorActualizacion_Tick);
            // 
            // controlTemperatura1
            // 
            this.controlTemperatura1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlTemperatura1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.controlTemperatura1.Location = new System.Drawing.Point(1, 380);
            this.controlTemperatura1.Margin = new System.Windows.Forms.Padding(1);
            this.controlTemperatura1.MinimumSize = new System.Drawing.Size(200, 230);
            this.controlTemperatura1.Name = "controlTemperatura1";
            this.controlTemperatura1.Size = new System.Drawing.Size(200, 240);
            this.controlTemperatura1.TabIndex = 13;
            this.controlTemperatura1.ValorActual = 0F;
            this.controlTemperatura1.ValorMaximo = 100F;
            this.controlTemperatura1.ValorMinimo = 0F;
            // 
            // controlHumedad1
            // 
            this.controlHumedad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlHumedad1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.controlHumedad1.Location = new System.Drawing.Point(1, 380);
            this.controlHumedad1.Margin = new System.Windows.Forms.Padding(1);
            this.controlHumedad1.MinimumSize = new System.Drawing.Size(200, 230);
            this.controlHumedad1.Name = "controlHumedad1";
            this.controlHumedad1.Size = new System.Drawing.Size(200, 240);
            this.controlHumedad1.TabIndex = 12;
            this.controlHumedad1.ValorActual = 0F;
            this.controlHumedad1.ValorMaximo = 100F;
            this.controlHumedad1.ValorMinimo = 0F;
            // 
            // curvaDeshidratacion
            // 
            this.curvaDeshidratacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curvaDeshidratacion.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.curvaDeshidratacion.Location = new System.Drawing.Point(1, 311);
            this.curvaDeshidratacion.Margin = new System.Windows.Forms.Padding(1);
            this.curvaDeshidratacion.Name = "curvaDeshidratacion";
            this.curvaDeshidratacion.Size = new System.Drawing.Size(630, 309);
            this.curvaDeshidratacion.TabIndex = 14;
            this.curvaDeshidratacion.ValorHumedad1 = 0F;
            this.curvaDeshidratacion.ValorHumedad10 = 0F;
            this.curvaDeshidratacion.ValorHumedad2 = 0F;
            this.curvaDeshidratacion.ValorHumedad3 = 0F;
            this.curvaDeshidratacion.ValorHumedad4 = 0F;
            this.curvaDeshidratacion.ValorHumedad5 = 0F;
            this.curvaDeshidratacion.ValorHumedad6 = 0F;
            this.curvaDeshidratacion.ValorHumedad7 = 0F;
            this.curvaDeshidratacion.ValorHumedad8 = 0F;
            this.curvaDeshidratacion.ValorHumedad9 = 0F;
            this.curvaDeshidratacion.ValorHumedadActual = 0F;
            this.curvaDeshidratacion.ValorSeleccionado = -1;
            this.curvaDeshidratacion.ValorTemperatura1 = 0F;
            this.curvaDeshidratacion.ValorTemperatura10 = 0F;
            this.curvaDeshidratacion.ValorTemperatura2 = 0F;
            this.curvaDeshidratacion.ValorTemperatura3 = 0F;
            this.curvaDeshidratacion.ValorTemperatura4 = 0F;
            this.curvaDeshidratacion.ValorTemperatura5 = 0F;
            this.curvaDeshidratacion.ValorTemperatura6 = 0F;
            this.curvaDeshidratacion.ValorTemperatura7 = 0F;
            this.curvaDeshidratacion.ValorTemperatura8 = 0F;
            this.curvaDeshidratacion.ValorTemperatura9 = 0F;
            this.curvaDeshidratacion.ValorTemperaturaActual = 0F;
            // 
            // controlVentilador1
            // 
            this.controlVentilador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlVentilador1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.controlVentilador1.Interruptor = false;
            this.controlVentilador1.Location = new System.Drawing.Point(1, 44);
            this.controlVentilador1.Margin = new System.Windows.Forms.Padding(1);
            this.controlVentilador1.MinimumSize = new System.Drawing.Size(200, 260);
            this.controlVentilador1.Name = "controlVentilador1";
            this.controlVentilador1.Size = new System.Drawing.Size(200, 260);
            this.controlVentilador1.TabIndex = 13;
            this.controlVentilador1.ValorActual = 0F;
            this.controlVentilador1.ValorMaximo = 100F;
            this.controlVentilador1.ValorMinimo = 0F;
            this.controlVentilador1.ValorRealimentacion = 0F;
            // 
            // controlVentilador2
            // 
            this.controlVentilador2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlVentilador2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.controlVentilador2.Interruptor = false;
            this.controlVentilador2.Location = new System.Drawing.Point(1, 44);
            this.controlVentilador2.Margin = new System.Windows.Forms.Padding(1);
            this.controlVentilador2.MinimumSize = new System.Drawing.Size(200, 260);
            this.controlVentilador2.Name = "controlVentilador2";
            this.controlVentilador2.Size = new System.Drawing.Size(200, 260);
            this.controlVentilador2.TabIndex = 14;
            this.controlVentilador2.ValorActual = 0F;
            this.controlVentilador2.ValorMaximo = 100F;
            this.controlVentilador2.ValorMinimo = 0F;
            this.controlVentilador2.ValorRealimentacion = 0F;
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 740);
            this.Controls.Add(this.layoutBase);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PanelPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelPrincipal";
            this.Load += new System.EventHandler(this.PanelPrincipal_Load);
            this.layoutBase.ResumeLayout(false);
            this.layoutDistribucionBase.ResumeLayout(false);
            this.layoutTitulo.ResumeLayout(false);
            this.layoutPieAplicacion.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.layoutAplicacion.ResumeLayout(false);
            this.layoutDistribucionComponentes.ResumeLayout(false);
            this.layoutDistribucionColumna2.ResumeLayout(false);
            this.layoutDistribucionProceso.ResumeLayout(false);
            this.layoutDistribucionColumna1.ResumeLayout(false);
            this.layoutDistribucionVariables.ResumeLayout(false);
            this.layoutEntradaSalidaAire.ResumeLayout(false);
            this.layoutPerfilesDeshidratacion.ResumeLayout(false);
            this.layoutValoresPerfil.ResumeLayout(false);
            this.layoutValoresPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorRelacion)).EndInit();
            this.layoutResistencias.ResumeLayout(false);
            this.layoutMenuLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm EstiloPanel;
        private System.Windows.Forms.TableLayoutPanel layoutBase;
        private System.Windows.Forms.TableLayoutPanel layoutDistribucionBase;
        private System.Windows.Forms.TableLayoutPanel layoutAplicacion;
        private Guna.UI2.WinForms.Guna2ControlBox btnCerrar;
        private System.Windows.Forms.Label TituloApp;
        private Guna.UI2.WinForms.Guna2DragControl ArrastrePanel;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizar;
        private System.Windows.Forms.TableLayoutPanel layoutDistribucionComponentes;
        private System.Windows.Forms.TableLayoutPanel layoutDistribucionColumna1;
        private System.Windows.Forms.TableLayoutPanel layoutDistribucionColumna2;
        private System.Windows.Forms.Label lbTemperatura;
        private System.Windows.Forms.Label lbVentilador2;
        private System.Windows.Forms.Label lbHumedad;
        private System.Windows.Forms.Label lbVentilador1;
        private System.Windows.Forms.TableLayoutPanel layoutDistribucionVariables;
        private System.Windows.Forms.Label lbCurvaTrabajo;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private System.Windows.Forms.TableLayoutPanel layoutPerfilesDeshidratacion;
        private System.Windows.Forms.Label lbSeleccionPerfil;
        private Guna.UI2.WinForms.Guna2ComboBox PerfilesDeshidratacion;
        private Guna.UI2.WinForms.Guna2Button btnCrearPerfil;
        private Guna.UI2.WinForms.Guna2CheckBox cbEditarValores;
        private System.Windows.Forms.TableLayoutPanel layoutValoresPerfil;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudValorRelacion;
        private Guna.UI2.WinForms.Guna2TextBox tbHumedad;
        private Guna.UI2.WinForms.Guna2TextBox tbTemperatura;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private System.Windows.Forms.Label lbResistencias;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator6;
        private System.Windows.Forms.TableLayoutPanel layoutResistencias;
        private Guna.UI2.WinForms.Guna2ToggleSwitch interruptorR1R2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch interruptorR3R4;
        private Guna.UI2.WinForms.Guna2ToggleSwitch interruptorR5R6;
        private Guna.UI2.WinForms.Guna2ToggleSwitch interruptorR7R8;
        private System.Windows.Forms.Label lbR7R8;
        private System.Windows.Forms.Label lbR5R6;
        private System.Windows.Forms.Label lbR3R4;
        private System.Windows.Forms.Label lbR1R2;
        private System.Windows.Forms.Label lbDrenajeAireHumedo;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator7;
        private System.Windows.Forms.TableLayoutPanel layoutEntradaSalidaAire;
        private System.Windows.Forms.Label lbMotorDrenaje;
        private Guna.UI2.WinForms.Guna2ToggleSwitch interruptorExclusaAire;
        private Guna.UI2.WinForms.Guna2ToggleSwitch interruptorMotorDrenaje;
        private System.Windows.Forms.Label lbActuadorExclusa;
        private System.Windows.Forms.TableLayoutPanel layoutDistribucionProceso;
        private Guna.UI2.WinForms.Guna2Button btnInicio;
        private Guna.UI2.WinForms.Guna2Button btnStop;
        private Guna.UI2.WinForms.Guna2ControlBox btnMaximizarRestaurar;
		private System.Windows.Forms.Label lbGrados;
		private System.Windows.Forms.Label lbPorciento;
        private System.Windows.Forms.Label lbRegimenes;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator8;
        private Guna.UI2.WinForms.Guna2Button indRegimenSecado;
        private Guna.UI2.WinForms.Guna2Button indRegimenCalentamiento;
        private Guna.UI2.WinForms.Guna2Button indRegimenDrenado;
        private System.Windows.Forms.Label lbInicio;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator9;
        private Guna.UI2.WinForms.Guna2Button btnPanelModulos;
        internal System.Windows.Forms.TableLayoutPanel layoutMenuLateral;
        internal System.Windows.Forms.TableLayoutPanel layoutTitulo;
        internal System.Windows.Forms.TableLayoutPanel layoutPieAplicacion;
        private CustomComponents.Lib.CurvaDeshidratacion curvaDeshidratacion;
        private CustomComponents.Lib.ControlTemperatura controlTemperatura1;
        private CustomComponents.Lib.ControlHumedad controlHumedad1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbVersionFirmware;
        private System.Windows.Forms.Label lbModulo;
        private Guna.UI2.WinForms.Guna2Button btnEliminarPerfil;
        private System.Windows.Forms.Timer _temporizadorActualizacion;
        private System.Windows.Forms.Label lbPoolCounter;
        private System.Windows.Forms.Label lbTrama;
        private CustomComponents.Lib.ControlVentilador controlVentilador2;
        private CustomComponents.Lib.ControlVentilador controlVentilador1;
    }
}