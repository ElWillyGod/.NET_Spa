namespace Spa
{
    partial class frmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.SalesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesListingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NetSalesByPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHoy = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn7dias = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnMes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn30dias = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAño = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dpDesde = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpHasta = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.btnAplicar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesListingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetSalesByPeriodBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesReportBindingSource
            // 
            this.SalesReportBindingSource.DataSource = typeof(Logica.SalesReport);
            // 
            // SalesListingBindingSource
            // 
            this.SalesListingBindingSource.DataSource = typeof(Logica.SalesListing);
            // 
            // NetSalesByPeriodBindingSource
            // 
            this.NetSalesByPeriodBindingSource.DataSource = typeof(Logica.NetSalesByPeriod);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SalesReportBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.SalesListingBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.NetSalesByPeriodBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Spa.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(283, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(719, 617);
            this.reportViewer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnHoy, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn7dias, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnMes, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn30dias, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnAño, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnAplicar, 0, 7);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.432433F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51351F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.71171F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.96396F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.93694F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.38739F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.77634F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5316F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(274, 617);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnHoy
            // 
            this.btnHoy.AllowAnimations = true;
            this.btnHoy.AllowMouseEffects = true;
            this.btnHoy.AllowToggling = false;
            this.btnHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHoy.AnimationSpeed = 200;
            this.btnHoy.AutoGenerateColors = false;
            this.btnHoy.AutoRoundBorders = false;
            this.btnHoy.AutoSizeLeftIcon = true;
            this.btnHoy.AutoSizeRightIcon = true;
            this.btnHoy.BackColor = System.Drawing.Color.Transparent;
            this.btnHoy.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnHoy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHoy.BackgroundImage")));
            this.btnHoy.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHoy.ButtonText = "Hoy";
            this.btnHoy.ButtonTextMarginLeft = 0;
            this.btnHoy.ColorContrastOnClick = 45;
            this.btnHoy.ColorContrastOnHover = 45;
            this.btnHoy.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnHoy.CustomizableEdges = borderEdges1;
            this.btnHoy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHoy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHoy.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHoy.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHoy.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnHoy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoy.ForeColor = System.Drawing.Color.White;
            this.btnHoy.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoy.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnHoy.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnHoy.IconMarginLeft = 11;
            this.btnHoy.IconPadding = 10;
            this.btnHoy.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoy.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnHoy.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnHoy.IconSize = 25;
            this.btnHoy.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnHoy.IdleBorderRadius = 35;
            this.btnHoy.IdleBorderThickness = 2;
            this.btnHoy.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnHoy.IdleIconLeftImage = null;
            this.btnHoy.IdleIconRightImage = null;
            this.btnHoy.IndicateFocus = false;
            this.btnHoy.Location = new System.Drawing.Point(3, 61);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHoy.OnDisabledState.BorderRadius = 35;
            this.btnHoy.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHoy.OnDisabledState.BorderThickness = 2;
            this.btnHoy.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHoy.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHoy.OnDisabledState.IconLeftImage = null;
            this.btnHoy.OnDisabledState.IconRightImage = null;
            this.btnHoy.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnHoy.onHoverState.BorderRadius = 35;
            this.btnHoy.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHoy.onHoverState.BorderThickness = 2;
            this.btnHoy.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnHoy.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnHoy.onHoverState.IconLeftImage = null;
            this.btnHoy.onHoverState.IconRightImage = null;
            this.btnHoy.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnHoy.OnIdleState.BorderRadius = 35;
            this.btnHoy.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHoy.OnIdleState.BorderThickness = 2;
            this.btnHoy.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnHoy.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnHoy.OnIdleState.IconLeftImage = null;
            this.btnHoy.OnIdleState.IconRightImage = null;
            this.btnHoy.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnHoy.OnPressedState.BorderRadius = 35;
            this.btnHoy.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHoy.OnPressedState.BorderThickness = 2;
            this.btnHoy.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnHoy.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnHoy.OnPressedState.IconLeftImage = null;
            this.btnHoy.OnPressedState.IconRightImage = null;
            this.btnHoy.Size = new System.Drawing.Size(268, 49);
            this.btnHoy.TabIndex = 130;
            this.btnHoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHoy.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHoy.TextMarginLeft = 0;
            this.btnHoy.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnHoy.UseDefaultRadiusAndThickness = true;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // btn7dias
            // 
            this.btn7dias.AllowAnimations = true;
            this.btn7dias.AllowMouseEffects = true;
            this.btn7dias.AllowToggling = false;
            this.btn7dias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn7dias.AnimationSpeed = 200;
            this.btn7dias.AutoGenerateColors = false;
            this.btn7dias.AutoRoundBorders = false;
            this.btn7dias.AutoSizeLeftIcon = true;
            this.btn7dias.AutoSizeRightIcon = true;
            this.btn7dias.BackColor = System.Drawing.Color.Transparent;
            this.btn7dias.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn7dias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn7dias.BackgroundImage")));
            this.btn7dias.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn7dias.ButtonText = "Ultimos 7 dias";
            this.btn7dias.ButtonTextMarginLeft = 0;
            this.btn7dias.ColorContrastOnClick = 45;
            this.btn7dias.ColorContrastOnHover = 45;
            this.btn7dias.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn7dias.CustomizableEdges = borderEdges2;
            this.btn7dias.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn7dias.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn7dias.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn7dias.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn7dias.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn7dias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7dias.ForeColor = System.Drawing.Color.White;
            this.btn7dias.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn7dias.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn7dias.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn7dias.IconMarginLeft = 11;
            this.btn7dias.IconPadding = 10;
            this.btn7dias.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn7dias.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn7dias.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn7dias.IconSize = 25;
            this.btn7dias.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn7dias.IdleBorderRadius = 35;
            this.btn7dias.IdleBorderThickness = 2;
            this.btn7dias.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn7dias.IdleIconLeftImage = null;
            this.btn7dias.IdleIconRightImage = null;
            this.btn7dias.IndicateFocus = false;
            this.btn7dias.Location = new System.Drawing.Point(3, 138);
            this.btn7dias.Name = "btn7dias";
            this.btn7dias.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn7dias.OnDisabledState.BorderRadius = 35;
            this.btn7dias.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn7dias.OnDisabledState.BorderThickness = 2;
            this.btn7dias.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn7dias.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn7dias.OnDisabledState.IconLeftImage = null;
            this.btn7dias.OnDisabledState.IconRightImage = null;
            this.btn7dias.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn7dias.onHoverState.BorderRadius = 35;
            this.btn7dias.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn7dias.onHoverState.BorderThickness = 2;
            this.btn7dias.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn7dias.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn7dias.onHoverState.IconLeftImage = null;
            this.btn7dias.onHoverState.IconRightImage = null;
            this.btn7dias.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn7dias.OnIdleState.BorderRadius = 35;
            this.btn7dias.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn7dias.OnIdleState.BorderThickness = 2;
            this.btn7dias.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn7dias.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn7dias.OnIdleState.IconLeftImage = null;
            this.btn7dias.OnIdleState.IconRightImage = null;
            this.btn7dias.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn7dias.OnPressedState.BorderRadius = 35;
            this.btn7dias.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn7dias.OnPressedState.BorderThickness = 2;
            this.btn7dias.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn7dias.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn7dias.OnPressedState.IconLeftImage = null;
            this.btn7dias.OnPressedState.IconRightImage = null;
            this.btn7dias.Size = new System.Drawing.Size(268, 49);
            this.btn7dias.TabIndex = 131;
            this.btn7dias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn7dias.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn7dias.TextMarginLeft = 0;
            this.btn7dias.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn7dias.UseDefaultRadiusAndThickness = true;
            this.btn7dias.Click += new System.EventHandler(this.btn7dias_Click);
            // 
            // btnMes
            // 
            this.btnMes.AllowAnimations = true;
            this.btnMes.AllowMouseEffects = true;
            this.btnMes.AllowToggling = false;
            this.btnMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMes.AnimationSpeed = 200;
            this.btnMes.AutoGenerateColors = false;
            this.btnMes.AutoRoundBorders = false;
            this.btnMes.AutoSizeLeftIcon = true;
            this.btnMes.AutoSizeRightIcon = true;
            this.btnMes.BackColor = System.Drawing.Color.Transparent;
            this.btnMes.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnMes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMes.BackgroundImage")));
            this.btnMes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMes.ButtonText = "Este Mes";
            this.btnMes.ButtonTextMarginLeft = 0;
            this.btnMes.ColorContrastOnClick = 45;
            this.btnMes.ColorContrastOnHover = 45;
            this.btnMes.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnMes.CustomizableEdges = borderEdges3;
            this.btnMes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMes.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMes.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMes.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.ForeColor = System.Drawing.Color.White;
            this.btnMes.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMes.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMes.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnMes.IconMarginLeft = 11;
            this.btnMes.IconPadding = 10;
            this.btnMes.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMes.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMes.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnMes.IconSize = 25;
            this.btnMes.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnMes.IdleBorderRadius = 35;
            this.btnMes.IdleBorderThickness = 2;
            this.btnMes.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnMes.IdleIconLeftImage = null;
            this.btnMes.IdleIconRightImage = null;
            this.btnMes.IndicateFocus = false;
            this.btnMes.Location = new System.Drawing.Point(3, 216);
            this.btnMes.Name = "btnMes";
            this.btnMes.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMes.OnDisabledState.BorderRadius = 35;
            this.btnMes.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMes.OnDisabledState.BorderThickness = 2;
            this.btnMes.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMes.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMes.OnDisabledState.IconLeftImage = null;
            this.btnMes.OnDisabledState.IconRightImage = null;
            this.btnMes.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnMes.onHoverState.BorderRadius = 35;
            this.btnMes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMes.onHoverState.BorderThickness = 2;
            this.btnMes.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnMes.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnMes.onHoverState.IconLeftImage = null;
            this.btnMes.onHoverState.IconRightImage = null;
            this.btnMes.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnMes.OnIdleState.BorderRadius = 35;
            this.btnMes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMes.OnIdleState.BorderThickness = 2;
            this.btnMes.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnMes.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnMes.OnIdleState.IconLeftImage = null;
            this.btnMes.OnIdleState.IconRightImage = null;
            this.btnMes.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnMes.OnPressedState.BorderRadius = 35;
            this.btnMes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMes.OnPressedState.BorderThickness = 2;
            this.btnMes.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnMes.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnMes.OnPressedState.IconLeftImage = null;
            this.btnMes.OnPressedState.IconRightImage = null;
            this.btnMes.Size = new System.Drawing.Size(268, 49);
            this.btnMes.TabIndex = 132;
            this.btnMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMes.TextMarginLeft = 0;
            this.btnMes.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnMes.UseDefaultRadiusAndThickness = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btn30dias
            // 
            this.btn30dias.AllowAnimations = true;
            this.btn30dias.AllowMouseEffects = true;
            this.btn30dias.AllowToggling = false;
            this.btn30dias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn30dias.AnimationSpeed = 200;
            this.btn30dias.AutoGenerateColors = false;
            this.btn30dias.AutoRoundBorders = false;
            this.btn30dias.AutoSizeLeftIcon = true;
            this.btn30dias.AutoSizeRightIcon = true;
            this.btn30dias.BackColor = System.Drawing.Color.Transparent;
            this.btn30dias.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn30dias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn30dias.BackgroundImage")));
            this.btn30dias.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn30dias.ButtonText = "Ultimos 30 dias";
            this.btn30dias.ButtonTextMarginLeft = 0;
            this.btn30dias.ColorContrastOnClick = 45;
            this.btn30dias.ColorContrastOnHover = 45;
            this.btn30dias.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn30dias.CustomizableEdges = borderEdges4;
            this.btn30dias.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn30dias.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn30dias.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn30dias.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn30dias.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn30dias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30dias.ForeColor = System.Drawing.Color.White;
            this.btn30dias.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn30dias.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn30dias.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn30dias.IconMarginLeft = 11;
            this.btn30dias.IconPadding = 10;
            this.btn30dias.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn30dias.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn30dias.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn30dias.IconSize = 25;
            this.btn30dias.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn30dias.IdleBorderRadius = 35;
            this.btn30dias.IdleBorderThickness = 2;
            this.btn30dias.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn30dias.IdleIconLeftImage = null;
            this.btn30dias.IdleIconRightImage = null;
            this.btn30dias.IndicateFocus = false;
            this.btn30dias.Location = new System.Drawing.Point(3, 294);
            this.btn30dias.Name = "btn30dias";
            this.btn30dias.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn30dias.OnDisabledState.BorderRadius = 35;
            this.btn30dias.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn30dias.OnDisabledState.BorderThickness = 2;
            this.btn30dias.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn30dias.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn30dias.OnDisabledState.IconLeftImage = null;
            this.btn30dias.OnDisabledState.IconRightImage = null;
            this.btn30dias.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn30dias.onHoverState.BorderRadius = 35;
            this.btn30dias.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn30dias.onHoverState.BorderThickness = 2;
            this.btn30dias.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn30dias.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn30dias.onHoverState.IconLeftImage = null;
            this.btn30dias.onHoverState.IconRightImage = null;
            this.btn30dias.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn30dias.OnIdleState.BorderRadius = 35;
            this.btn30dias.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn30dias.OnIdleState.BorderThickness = 2;
            this.btn30dias.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn30dias.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn30dias.OnIdleState.IconLeftImage = null;
            this.btn30dias.OnIdleState.IconRightImage = null;
            this.btn30dias.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn30dias.OnPressedState.BorderRadius = 35;
            this.btn30dias.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn30dias.OnPressedState.BorderThickness = 2;
            this.btn30dias.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn30dias.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn30dias.OnPressedState.IconLeftImage = null;
            this.btn30dias.OnPressedState.IconRightImage = null;
            this.btn30dias.Size = new System.Drawing.Size(268, 49);
            this.btn30dias.TabIndex = 133;
            this.btn30dias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn30dias.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn30dias.TextMarginLeft = 0;
            this.btn30dias.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn30dias.UseDefaultRadiusAndThickness = true;
            this.btn30dias.Click += new System.EventHandler(this.btn30dias_Click);
            // 
            // btnAño
            // 
            this.btnAño.AllowAnimations = true;
            this.btnAño.AllowMouseEffects = true;
            this.btnAño.AllowToggling = false;
            this.btnAño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAño.AnimationSpeed = 200;
            this.btnAño.AutoGenerateColors = false;
            this.btnAño.AutoRoundBorders = false;
            this.btnAño.AutoSizeLeftIcon = true;
            this.btnAño.AutoSizeRightIcon = true;
            this.btnAño.BackColor = System.Drawing.Color.Transparent;
            this.btnAño.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAño.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAño.BackgroundImage")));
            this.btnAño.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAño.ButtonText = "Este año";
            this.btnAño.ButtonTextMarginLeft = 0;
            this.btnAño.ColorContrastOnClick = 45;
            this.btnAño.ColorContrastOnHover = 45;
            this.btnAño.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnAño.CustomizableEdges = borderEdges5;
            this.btnAño.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAño.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAño.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAño.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAño.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAño.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAño.ForeColor = System.Drawing.Color.White;
            this.btnAño.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAño.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAño.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAño.IconMarginLeft = 11;
            this.btnAño.IconPadding = 10;
            this.btnAño.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAño.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAño.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAño.IconSize = 25;
            this.btnAño.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAño.IdleBorderRadius = 35;
            this.btnAño.IdleBorderThickness = 2;
            this.btnAño.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAño.IdleIconLeftImage = null;
            this.btnAño.IdleIconRightImage = null;
            this.btnAño.IndicateFocus = false;
            this.btnAño.Location = new System.Drawing.Point(3, 368);
            this.btnAño.Name = "btnAño";
            this.btnAño.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAño.OnDisabledState.BorderRadius = 35;
            this.btnAño.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAño.OnDisabledState.BorderThickness = 2;
            this.btnAño.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAño.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAño.OnDisabledState.IconLeftImage = null;
            this.btnAño.OnDisabledState.IconRightImage = null;
            this.btnAño.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAño.onHoverState.BorderRadius = 35;
            this.btnAño.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAño.onHoverState.BorderThickness = 2;
            this.btnAño.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAño.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAño.onHoverState.IconLeftImage = null;
            this.btnAño.onHoverState.IconRightImage = null;
            this.btnAño.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAño.OnIdleState.BorderRadius = 35;
            this.btnAño.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAño.OnIdleState.BorderThickness = 2;
            this.btnAño.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAño.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAño.OnIdleState.IconLeftImage = null;
            this.btnAño.OnIdleState.IconRightImage = null;
            this.btnAño.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAño.OnPressedState.BorderRadius = 35;
            this.btnAño.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAño.OnPressedState.BorderThickness = 2;
            this.btnAño.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAño.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAño.OnPressedState.IconLeftImage = null;
            this.btnAño.OnPressedState.IconRightImage = null;
            this.btnAño.Size = new System.Drawing.Size(268, 49);
            this.btnAño.TabIndex = 134;
            this.btnAño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAño.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAño.TextMarginLeft = 0;
            this.btnAño.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAño.UseDefaultRadiusAndThickness = true;
            this.btnAño.Click += new System.EventHandler(this.btnAño_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.59702F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.40298F));
            this.tableLayoutPanel3.Controls.Add(this.dpDesde, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dpHasta, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 433);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(268, 77);
            this.tableLayoutPanel3.TabIndex = 135;
            // 
            // dpDesde
            // 
            this.dpDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dpDesde.BackColor = System.Drawing.Color.Transparent;
            this.dpDesde.BorderRadius = 17;
            this.dpDesde.CalendarForeColor = System.Drawing.Color.White;
            this.dpDesde.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.dpDesde.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dpDesde.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.dpDesde.Color = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.dpDesde.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dpDesde.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dpDesde.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dpDesde.DisabledColor = System.Drawing.Color.Gray;
            this.dpDesde.DisplayWeekNumbers = false;
            this.dpDesde.DPHeight = 0;
            this.dpDesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpDesde.FillDatePicker = true;
            this.dpDesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpDesde.ForeColor = System.Drawing.Color.White;
            this.dpDesde.Icon = ((System.Drawing.Image)(resources.GetObject("dpDesde.Icon")));
            this.dpDesde.IconColor = System.Drawing.Color.White;
            this.dpDesde.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dpDesde.LeftTextMargin = 5;
            this.dpDesde.Location = new System.Drawing.Point(85, 3);
            this.dpDesde.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dpDesde.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dpDesde.MinimumSize = new System.Drawing.Size(4, 32);
            this.dpDesde.Name = "dpDesde";
            this.dpDesde.Size = new System.Drawing.Size(180, 32);
            this.dpDesde.TabIndex = 81;
            this.dpDesde.Value = new System.DateTime(2021, 9, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 30);
            this.label2.TabIndex = 84;
            this.label2.Text = "Hasta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 83;
            this.label1.Text = "Desde:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpHasta
            // 
            this.dpHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dpHasta.BackColor = System.Drawing.Color.Transparent;
            this.dpHasta.BorderRadius = 17;
            this.dpHasta.CalendarForeColor = System.Drawing.Color.White;
            this.dpHasta.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.dpHasta.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dpHasta.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.dpHasta.Color = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.dpHasta.CustomFormat = "dd/MM/yyyy";
            this.dpHasta.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dpHasta.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dpHasta.DisabledColor = System.Drawing.Color.Gray;
            this.dpHasta.DisplayWeekNumbers = false;
            this.dpHasta.DPHeight = 0;
            this.dpHasta.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpHasta.FillDatePicker = true;
            this.dpHasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpHasta.ForeColor = System.Drawing.Color.White;
            this.dpHasta.Icon = ((System.Drawing.Image)(resources.GetObject("dpHasta.Icon")));
            this.dpHasta.IconColor = System.Drawing.Color.White;
            this.dpHasta.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dpHasta.LeftTextMargin = 5;
            this.dpHasta.Location = new System.Drawing.Point(85, 41);
            this.dpHasta.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dpHasta.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dpHasta.MinimumSize = new System.Drawing.Size(4, 32);
            this.dpHasta.Name = "dpHasta";
            this.dpHasta.Size = new System.Drawing.Size(180, 32);
            this.dpHasta.TabIndex = 82;
            this.dpHasta.Value = new System.DateTime(2021, 9, 1, 0, 0, 0, 0);
            // 
            // btnAplicar
            // 
            this.btnAplicar.AllowAnimations = true;
            this.btnAplicar.AllowMouseEffects = true;
            this.btnAplicar.AllowToggling = false;
            this.btnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicar.AnimationSpeed = 200;
            this.btnAplicar.AutoGenerateColors = false;
            this.btnAplicar.AutoRoundBorders = false;
            this.btnAplicar.AutoSizeLeftIcon = true;
            this.btnAplicar.AutoSizeRightIcon = true;
            this.btnAplicar.BackColor = System.Drawing.Color.Transparent;
            this.btnAplicar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAplicar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAplicar.BackgroundImage")));
            this.btnAplicar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAplicar.ButtonText = "Aplicar";
            this.btnAplicar.ButtonTextMarginLeft = 0;
            this.btnAplicar.ColorContrastOnClick = 45;
            this.btnAplicar.ColorContrastOnHover = 45;
            this.btnAplicar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnAplicar.CustomizableEdges = borderEdges6;
            this.btnAplicar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAplicar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAplicar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAplicar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAplicar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAplicar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAplicar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAplicar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAplicar.IconMarginLeft = 11;
            this.btnAplicar.IconPadding = 10;
            this.btnAplicar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAplicar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAplicar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAplicar.IconSize = 25;
            this.btnAplicar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAplicar.IdleBorderRadius = 35;
            this.btnAplicar.IdleBorderThickness = 2;
            this.btnAplicar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAplicar.IdleIconLeftImage = null;
            this.btnAplicar.IdleIconRightImage = null;
            this.btnAplicar.IndicateFocus = false;
            this.btnAplicar.Location = new System.Drawing.Point(3, 540);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAplicar.OnDisabledState.BorderRadius = 35;
            this.btnAplicar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAplicar.OnDisabledState.BorderThickness = 2;
            this.btnAplicar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAplicar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAplicar.OnDisabledState.IconLeftImage = null;
            this.btnAplicar.OnDisabledState.IconRightImage = null;
            this.btnAplicar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAplicar.onHoverState.BorderRadius = 35;
            this.btnAplicar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAplicar.onHoverState.BorderThickness = 2;
            this.btnAplicar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAplicar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.onHoverState.IconLeftImage = null;
            this.btnAplicar.onHoverState.IconRightImage = null;
            this.btnAplicar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAplicar.OnIdleState.BorderRadius = 35;
            this.btnAplicar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAplicar.OnIdleState.BorderThickness = 2;
            this.btnAplicar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAplicar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.OnIdleState.IconLeftImage = null;
            this.btnAplicar.OnIdleState.IconRightImage = null;
            this.btnAplicar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAplicar.OnPressedState.BorderRadius = 35;
            this.btnAplicar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAplicar.OnPressedState.BorderThickness = 2;
            this.btnAplicar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAplicar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.OnPressedState.IconLeftImage = null;
            this.btnAplicar.OnPressedState.IconRightImage = null;
            this.btnAplicar.Size = new System.Drawing.Size(268, 49);
            this.btnAplicar.TabIndex = 136;
            this.btnAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAplicar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAplicar.TextMarginLeft = 0;
            this.btnAplicar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAplicar.UseDefaultRadiusAndThickness = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.88845F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.11156F));
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.19718F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1005, 623);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVenta";
            this.Text = "frmVenta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesListingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetSalesByPeriodBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalesReportBindingSource;
        private System.Windows.Forms.BindingSource SalesListingBindingSource;
        private System.Windows.Forms.BindingSource NetSalesByPeriodBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnHoy;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn7dias;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn30dias;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAño;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAplicar;
        private Bunifu.UI.WinForms.BunifuDatePicker dpDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDatePicker dpHasta;
    }
}