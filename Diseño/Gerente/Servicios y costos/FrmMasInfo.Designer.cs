namespace Spa
{
    partial class FrmMasInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasInfo));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvClientesPorHora = new System.Windows.Forms.DataGridView();
            this.dtpFechaCapacidades = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.btnBuscarCapacidad = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExportarCapacidadesExcel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblCapacidades = new System.Windows.Forms.Label();
            this.btnExportarCapacidadesPDF = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesPorHora)).BeginInit();
            this.MenuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.58108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.48198F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.009009F));
            this.tableLayoutPanel1.Controls.Add(this.dgvClientesPorHora, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaCapacidades, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscarCapacidad, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExportarCapacidadesExcel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCapacidades, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExportarCapacidadesPDF, 1, 1);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.943477F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.29943F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.12429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.85499F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 596);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvClientesPorHora
            // 
            this.dgvClientesPorHora.AllowUserToAddRows = false;
            this.dgvClientesPorHora.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.dgvClientesPorHora.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientesPorHora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientesPorHora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientesPorHora.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.dgvClientesPorHora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClientesPorHora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientesPorHora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientesPorHora.ColumnHeadersHeight = 50;
            this.dgvClientesPorHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvClientesPorHora, 3);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientesPorHora.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientesPorHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientesPorHora.EnableHeadersVisualStyles = false;
            this.dgvClientesPorHora.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvClientesPorHora.Location = new System.Drawing.Point(3, 200);
            this.dgvClientesPorHora.Name = "dgvClientesPorHora";
            this.dgvClientesPorHora.ReadOnly = true;
            this.dgvClientesPorHora.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientesPorHora.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientesPorHora.RowHeadersVisible = false;
            this.dgvClientesPorHora.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClientesPorHora.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClientesPorHora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientesPorHora.Size = new System.Drawing.Size(485, 393);
            this.dgvClientesPorHora.TabIndex = 1;
            // 
            // dtpFechaCapacidades
            // 
            this.dtpFechaCapacidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaCapacidades.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaCapacidades.BorderRadius = 17;
            this.dtpFechaCapacidades.CalendarForeColor = System.Drawing.Color.White;
            this.dtpFechaCapacidades.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.dtpFechaCapacidades.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpFechaCapacidades.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.dtpFechaCapacidades.Color = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.tableLayoutPanel1.SetColumnSpan(this.dtpFechaCapacidades, 2);
            this.dtpFechaCapacidades.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaCapacidades.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpFechaCapacidades.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpFechaCapacidades.DisabledColor = System.Drawing.Color.Gray;
            this.dtpFechaCapacidades.DisplayWeekNumbers = false;
            this.dtpFechaCapacidades.DPHeight = 0;
            this.dtpFechaCapacidades.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaCapacidades.FillDatePicker = true;
            this.dtpFechaCapacidades.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaCapacidades.ForeColor = System.Drawing.Color.White;
            this.dtpFechaCapacidades.Icon = ((System.Drawing.Image)(resources.GetObject("dtpFechaCapacidades.Icon")));
            this.dtpFechaCapacidades.IconColor = System.Drawing.Color.White;
            this.dtpFechaCapacidades.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpFechaCapacidades.LeftTextMargin = 5;
            this.dtpFechaCapacidades.Location = new System.Drawing.Point(3, 139);
            this.dtpFechaCapacidades.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpFechaCapacidades.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaCapacidades.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpFechaCapacidades.Name = "dtpFechaCapacidades";
            this.dtpFechaCapacidades.Size = new System.Drawing.Size(390, 32);
            this.dtpFechaCapacidades.TabIndex = 160;
            this.dtpFechaCapacidades.Value = new System.DateTime(2021, 9, 1, 0, 0, 0, 0);
            // 
            // btnBuscarCapacidad
            // 
            this.btnBuscarCapacidad.AllowAnimations = true;
            this.btnBuscarCapacidad.AllowMouseEffects = true;
            this.btnBuscarCapacidad.AllowToggling = false;
            this.btnBuscarCapacidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarCapacidad.AnimationSpeed = 200;
            this.btnBuscarCapacidad.AutoGenerateColors = false;
            this.btnBuscarCapacidad.AutoRoundBorders = false;
            this.btnBuscarCapacidad.AutoSizeLeftIcon = true;
            this.btnBuscarCapacidad.AutoSizeRightIcon = true;
            this.btnBuscarCapacidad.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCapacidad.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarCapacidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCapacidad.BackgroundImage")));
            this.btnBuscarCapacidad.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscarCapacidad.ButtonText = " ";
            this.btnBuscarCapacidad.ButtonTextMarginLeft = 0;
            this.btnBuscarCapacidad.ColorContrastOnClick = 45;
            this.btnBuscarCapacidad.ColorContrastOnHover = 45;
            this.btnBuscarCapacidad.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnBuscarCapacidad.CustomizableEdges = borderEdges1;
            this.btnBuscarCapacidad.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarCapacidad.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuscarCapacidad.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuscarCapacidad.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuscarCapacidad.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnBuscarCapacidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarCapacidad.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCapacidad.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCapacidad.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscarCapacidad.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnBuscarCapacidad.IconMarginLeft = 11;
            this.btnBuscarCapacidad.IconPadding = 10;
            this.btnBuscarCapacidad.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCapacidad.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscarCapacidad.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBuscarCapacidad.IconSize = 25;
            this.btnBuscarCapacidad.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarCapacidad.IdleBorderRadius = 40;
            this.btnBuscarCapacidad.IdleBorderThickness = 2;
            this.btnBuscarCapacidad.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarCapacidad.IdleIconLeftImage = null;
            this.btnBuscarCapacidad.IdleIconRightImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCapacidad.IdleIconRightImage")));
            this.btnBuscarCapacidad.IndicateFocus = false;
            this.btnBuscarCapacidad.Location = new System.Drawing.Point(396, 131);
            this.btnBuscarCapacidad.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarCapacidad.Name = "btnBuscarCapacidad";
            this.btnBuscarCapacidad.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuscarCapacidad.OnDisabledState.BorderRadius = 40;
            this.btnBuscarCapacidad.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscarCapacidad.OnDisabledState.BorderThickness = 2;
            this.btnBuscarCapacidad.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuscarCapacidad.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuscarCapacidad.OnDisabledState.IconLeftImage = null;
            this.btnBuscarCapacidad.OnDisabledState.IconRightImage = null;
            this.btnBuscarCapacidad.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarCapacidad.onHoverState.BorderRadius = 40;
            this.btnBuscarCapacidad.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscarCapacidad.onHoverState.BorderThickness = 2;
            this.btnBuscarCapacidad.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarCapacidad.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCapacidad.onHoverState.IconLeftImage = null;
            this.btnBuscarCapacidad.onHoverState.IconRightImage = null;
            this.btnBuscarCapacidad.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarCapacidad.OnIdleState.BorderRadius = 40;
            this.btnBuscarCapacidad.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscarCapacidad.OnIdleState.BorderThickness = 2;
            this.btnBuscarCapacidad.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarCapacidad.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCapacidad.OnIdleState.IconLeftImage = null;
            this.btnBuscarCapacidad.OnIdleState.IconRightImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCapacidad.OnIdleState.IconRightImage")));
            this.btnBuscarCapacidad.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarCapacidad.OnPressedState.BorderRadius = 40;
            this.btnBuscarCapacidad.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscarCapacidad.OnPressedState.BorderThickness = 2;
            this.btnBuscarCapacidad.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarCapacidad.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCapacidad.OnPressedState.IconLeftImage = null;
            this.btnBuscarCapacidad.OnPressedState.IconRightImage = null;
            this.btnBuscarCapacidad.Size = new System.Drawing.Size(50, 48);
            this.btnBuscarCapacidad.TabIndex = 13;
            this.btnBuscarCapacidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarCapacidad.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscarCapacidad.TextMarginLeft = 0;
            this.btnBuscarCapacidad.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBuscarCapacidad.UseDefaultRadiusAndThickness = true;
            this.btnBuscarCapacidad.Click += new System.EventHandler(this.btnBuscarCapacidad_Click);
            // 
            // btnExportarCapacidadesExcel
            // 
            this.btnExportarCapacidadesExcel.AllowAnimations = true;
            this.btnExportarCapacidadesExcel.AllowMouseEffects = true;
            this.btnExportarCapacidadesExcel.AllowToggling = false;
            this.btnExportarCapacidadesExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarCapacidadesExcel.AnimationSpeed = 200;
            this.btnExportarCapacidadesExcel.AutoGenerateColors = false;
            this.btnExportarCapacidadesExcel.AutoRoundBorders = false;
            this.btnExportarCapacidadesExcel.AutoSizeLeftIcon = true;
            this.btnExportarCapacidadesExcel.AutoSizeRightIcon = true;
            this.btnExportarCapacidadesExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarCapacidadesExcel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnExportarCapacidadesExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportarCapacidadesExcel.BackgroundImage")));
            this.btnExportarCapacidadesExcel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarCapacidadesExcel.ButtonText = " Exportar a Excel";
            this.btnExportarCapacidadesExcel.ButtonTextMarginLeft = 0;
            this.btnExportarCapacidadesExcel.ColorContrastOnClick = 45;
            this.btnExportarCapacidadesExcel.ColorContrastOnHover = 45;
            this.btnExportarCapacidadesExcel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnExportarCapacidadesExcel.CustomizableEdges = borderEdges2;
            this.btnExportarCapacidadesExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportarCapacidadesExcel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportarCapacidadesExcel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportarCapacidadesExcel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportarCapacidadesExcel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExportarCapacidadesExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarCapacidadesExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportarCapacidadesExcel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarCapacidadesExcel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportarCapacidadesExcel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExportarCapacidadesExcel.IconMarginLeft = 11;
            this.btnExportarCapacidadesExcel.IconPadding = 10;
            this.btnExportarCapacidadesExcel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarCapacidadesExcel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportarCapacidadesExcel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExportarCapacidadesExcel.IconSize = 25;
            this.btnExportarCapacidadesExcel.IdleBorderColor = System.Drawing.Color.Green;
            this.btnExportarCapacidadesExcel.IdleBorderRadius = 40;
            this.btnExportarCapacidadesExcel.IdleBorderThickness = 2;
            this.btnExportarCapacidadesExcel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnExportarCapacidadesExcel.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnExportarCapacidadesExcel.IdleIconLeftImage")));
            this.btnExportarCapacidadesExcel.IdleIconRightImage = null;
            this.btnExportarCapacidadesExcel.IndicateFocus = false;
            this.btnExportarCapacidadesExcel.Location = new System.Drawing.Point(3, 53);
            this.btnExportarCapacidadesExcel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnExportarCapacidadesExcel.Name = "btnExportarCapacidadesExcel";
            this.btnExportarCapacidadesExcel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportarCapacidadesExcel.OnDisabledState.BorderRadius = 40;
            this.btnExportarCapacidadesExcel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarCapacidadesExcel.OnDisabledState.BorderThickness = 2;
            this.btnExportarCapacidadesExcel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportarCapacidadesExcel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportarCapacidadesExcel.OnDisabledState.IconLeftImage = null;
            this.btnExportarCapacidadesExcel.OnDisabledState.IconRightImage = null;
            this.btnExportarCapacidadesExcel.onHoverState.BorderColor = System.Drawing.Color.Green;
            this.btnExportarCapacidadesExcel.onHoverState.BorderRadius = 40;
            this.btnExportarCapacidadesExcel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarCapacidadesExcel.onHoverState.BorderThickness = 2;
            this.btnExportarCapacidadesExcel.onHoverState.FillColor = System.Drawing.Color.Green;
            this.btnExportarCapacidadesExcel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExportarCapacidadesExcel.onHoverState.IconLeftImage = null;
            this.btnExportarCapacidadesExcel.onHoverState.IconRightImage = null;
            this.btnExportarCapacidadesExcel.OnIdleState.BorderColor = System.Drawing.Color.Green;
            this.btnExportarCapacidadesExcel.OnIdleState.BorderRadius = 40;
            this.btnExportarCapacidadesExcel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarCapacidadesExcel.OnIdleState.BorderThickness = 2;
            this.btnExportarCapacidadesExcel.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnExportarCapacidadesExcel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnExportarCapacidadesExcel.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnExportarCapacidadesExcel.OnIdleState.IconLeftImage")));
            this.btnExportarCapacidadesExcel.OnIdleState.IconRightImage = null;
            this.btnExportarCapacidadesExcel.OnPressedState.BorderColor = System.Drawing.Color.Green;
            this.btnExportarCapacidadesExcel.OnPressedState.BorderRadius = 40;
            this.btnExportarCapacidadesExcel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarCapacidadesExcel.OnPressedState.BorderThickness = 2;
            this.btnExportarCapacidadesExcel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnExportarCapacidadesExcel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExportarCapacidadesExcel.OnPressedState.IconLeftImage = null;
            this.btnExportarCapacidadesExcel.OnPressedState.IconRightImage = null;
            this.btnExportarCapacidadesExcel.Size = new System.Drawing.Size(187, 47);
            this.btnExportarCapacidadesExcel.TabIndex = 167;
            this.btnExportarCapacidadesExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExportarCapacidadesExcel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExportarCapacidadesExcel.TextMarginLeft = 0;
            this.btnExportarCapacidadesExcel.TextPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExportarCapacidadesExcel.UseDefaultRadiusAndThickness = true;
            this.btnExportarCapacidadesExcel.Click += new System.EventHandler(this.btnExportarCapacidadesExcel_Click);
            // 
            // lblCapacidades
            // 
            this.lblCapacidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCapacidades.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblCapacidades, 3);
            this.lblCapacidades.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.lblCapacidades.ForeColor = System.Drawing.Color.White;
            this.lblCapacidades.Location = new System.Drawing.Point(3, 5);
            this.lblCapacidades.Name = "lblCapacidades";
            this.lblCapacidades.Size = new System.Drawing.Size(485, 37);
            this.lblCapacidades.TabIndex = 162;
            this.lblCapacidades.Text = "Clientes";
            this.lblCapacidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExportarCapacidadesPDF
            // 
            this.btnExportarCapacidadesPDF.AllowAnimations = true;
            this.btnExportarCapacidadesPDF.AllowMouseEffects = true;
            this.btnExportarCapacidadesPDF.AllowToggling = false;
            this.btnExportarCapacidadesPDF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExportarCapacidadesPDF.AnimationSpeed = 200;
            this.btnExportarCapacidadesPDF.AutoGenerateColors = false;
            this.btnExportarCapacidadesPDF.AutoRoundBorders = false;
            this.btnExportarCapacidadesPDF.AutoSizeLeftIcon = true;
            this.btnExportarCapacidadesPDF.AutoSizeRightIcon = true;
            this.btnExportarCapacidadesPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarCapacidadesPDF.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnExportarCapacidadesPDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportarCapacidadesPDF.BackgroundImage")));
            this.btnExportarCapacidadesPDF.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarCapacidadesPDF.ButtonText = " Exportar a PDF";
            this.btnExportarCapacidadesPDF.ButtonTextMarginLeft = 0;
            this.btnExportarCapacidadesPDF.ColorContrastOnClick = 45;
            this.btnExportarCapacidadesPDF.ColorContrastOnHover = 45;
            this.btnExportarCapacidadesPDF.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnExportarCapacidadesPDF.CustomizableEdges = borderEdges3;
            this.btnExportarCapacidadesPDF.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportarCapacidadesPDF.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportarCapacidadesPDF.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportarCapacidadesPDF.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportarCapacidadesPDF.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExportarCapacidadesPDF.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarCapacidadesPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportarCapacidadesPDF.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarCapacidadesPDF.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportarCapacidadesPDF.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExportarCapacidadesPDF.IconMarginLeft = 11;
            this.btnExportarCapacidadesPDF.IconPadding = 10;
            this.btnExportarCapacidadesPDF.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarCapacidadesPDF.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportarCapacidadesPDF.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExportarCapacidadesPDF.IconSize = 25;
            this.btnExportarCapacidadesPDF.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnExportarCapacidadesPDF.IdleBorderRadius = 40;
            this.btnExportarCapacidadesPDF.IdleBorderThickness = 2;
            this.btnExportarCapacidadesPDF.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnExportarCapacidadesPDF.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnExportarCapacidadesPDF.IdleIconLeftImage")));
            this.btnExportarCapacidadesPDF.IdleIconRightImage = null;
            this.btnExportarCapacidadesPDF.IndicateFocus = false;
            this.btnExportarCapacidadesPDF.Location = new System.Drawing.Point(196, 53);
            this.btnExportarCapacidadesPDF.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnExportarCapacidadesPDF.Name = "btnExportarCapacidadesPDF";
            this.btnExportarCapacidadesPDF.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportarCapacidadesPDF.OnDisabledState.BorderRadius = 40;
            this.btnExportarCapacidadesPDF.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarCapacidadesPDF.OnDisabledState.BorderThickness = 2;
            this.btnExportarCapacidadesPDF.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportarCapacidadesPDF.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportarCapacidadesPDF.OnDisabledState.IconLeftImage = null;
            this.btnExportarCapacidadesPDF.OnDisabledState.IconRightImage = null;
            this.btnExportarCapacidadesPDF.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnExportarCapacidadesPDF.onHoverState.BorderRadius = 40;
            this.btnExportarCapacidadesPDF.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarCapacidadesPDF.onHoverState.BorderThickness = 2;
            this.btnExportarCapacidadesPDF.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnExportarCapacidadesPDF.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExportarCapacidadesPDF.onHoverState.IconLeftImage = null;
            this.btnExportarCapacidadesPDF.onHoverState.IconRightImage = null;
            this.btnExportarCapacidadesPDF.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnExportarCapacidadesPDF.OnIdleState.BorderRadius = 40;
            this.btnExportarCapacidadesPDF.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarCapacidadesPDF.OnIdleState.BorderThickness = 2;
            this.btnExportarCapacidadesPDF.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnExportarCapacidadesPDF.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnExportarCapacidadesPDF.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnExportarCapacidadesPDF.OnIdleState.IconLeftImage")));
            this.btnExportarCapacidadesPDF.OnIdleState.IconRightImage = null;
            this.btnExportarCapacidadesPDF.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnExportarCapacidadesPDF.OnPressedState.BorderRadius = 40;
            this.btnExportarCapacidadesPDF.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarCapacidadesPDF.OnPressedState.BorderThickness = 2;
            this.btnExportarCapacidadesPDF.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnExportarCapacidadesPDF.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExportarCapacidadesPDF.OnPressedState.IconLeftImage = null;
            this.btnExportarCapacidadesPDF.OnPressedState.IconRightImage = null;
            this.btnExportarCapacidadesPDF.Size = new System.Drawing.Size(134, 47);
            this.btnExportarCapacidadesPDF.TabIndex = 168;
            this.btnExportarCapacidadesPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarCapacidadesPDF.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExportarCapacidadesPDF.TextMarginLeft = 0;
            this.btnExportarCapacidadesPDF.TextPadding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnExportarCapacidadesPDF.UseDefaultRadiusAndThickness = true;
            this.btnExportarCapacidadesPDF.Click += new System.EventHandler(this.btnExportarCapacidadesPDF_Click);
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.MenuTop.Controls.Add(this.btnSalir);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(515, 54);
            this.MenuTop.TabIndex = 7;
            this.MenuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseDown);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Image = global::Spa.Properties.Resources.CorrectoSalirbtn1;
            this.btnSalir.Location = new System.Drawing.Point(472, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmMasInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(515, 674);
            this.Controls.Add(this.MenuTop);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMasInfo";
            this.Text = "FrmMasInfo";
            this.Load += new System.EventHandler(this.FrmMasInfo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesPorHora)).EndInit();
            this.MenuTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView dgvClientesPorHora;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpFechaCapacidades;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBuscarCapacidad;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExportarCapacidadesExcel;
        private System.Windows.Forms.Label lblCapacidades;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExportarCapacidadesPDF;
        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Button btnSalir;
    }
}