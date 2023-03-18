namespace Spa
{
    partial class frmBuscarPorReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarPorReserva));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvClientesPorHora = new System.Windows.Forms.DataGridView();
            this.dtpFecha = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.btnBuscar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblCapacidades = new System.Windows.Forms.Label();
            this.cbHora = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnExportarCapacidadesExcel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExportarCapacidadesPDF = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MenuTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesPorHora)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.MenuTop.Controls.Add(this.btnSalir);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(515, 54);
            this.MenuTop.TabIndex = 8;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.30754F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.79022F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.69857F));
            this.tableLayoutPanel1.Controls.Add(this.dgvClientesPorHora, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpFecha, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCapacidades, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbHora, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExportarCapacidadesExcel, 0, 1);
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
            this.tableLayoutPanel1.TabIndex = 9;
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
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.BackColor = System.Drawing.Color.Transparent;
            this.dtpFecha.BorderRadius = 17;
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.White;
            this.dtpFecha.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.dtpFecha.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpFecha.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.dtpFecha.Color = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpFecha.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpFecha.DisabledColor = System.Drawing.Color.Gray;
            this.dtpFecha.DisplayWeekNumbers = false;
            this.dtpFecha.DPHeight = 0;
            this.dtpFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFecha.FillDatePicker = true;
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFecha.ForeColor = System.Drawing.Color.White;
            this.dtpFecha.Icon = ((System.Drawing.Image)(resources.GetObject("dtpFecha.Icon")));
            this.dtpFecha.IconColor = System.Drawing.Color.White;
            this.dtpFecha.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpFecha.LeftTextMargin = 5;
            this.dtpFecha.Location = new System.Drawing.Point(3, 139);
            this.dtpFecha.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(187, 32);
            this.dtpFecha.TabIndex = 160;
            this.dtpFecha.Value = new System.DateTime(2021, 9, 1, 0, 0, 0, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AllowAnimations = true;
            this.btnBuscar.AllowMouseEffects = true;
            this.btnBuscar.AllowToggling = false;
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscar.AnimationSpeed = 200;
            this.btnBuscar.AutoGenerateColors = false;
            this.btnBuscar.AutoRoundBorders = false;
            this.btnBuscar.AutoSizeLeftIcon = true;
            this.btnBuscar.AutoSizeRightIcon = true;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscar.ButtonText = " ";
            this.btnBuscar.ButtonTextMarginLeft = 0;
            this.btnBuscar.ColorContrastOnClick = 45;
            this.btnBuscar.ColorContrastOnHover = 45;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnBuscar.CustomizableEdges = borderEdges1;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuscar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuscar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuscar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnBuscar.IconMarginLeft = 11;
            this.btnBuscar.IconPadding = 10;
            this.btnBuscar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscar.IdleBorderRadius = 40;
            this.btnBuscar.IdleBorderThickness = 2;
            this.btnBuscar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscar.IdleIconLeftImage = null;
            this.btnBuscar.IdleIconRightImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.IdleIconRightImage")));
            this.btnBuscar.IndicateFocus = false;
            this.btnBuscar.Location = new System.Drawing.Point(354, 131);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuscar.OnDisabledState.BorderRadius = 40;
            this.btnBuscar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscar.OnDisabledState.BorderThickness = 2;
            this.btnBuscar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuscar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuscar.OnDisabledState.IconLeftImage = null;
            this.btnBuscar.OnDisabledState.IconRightImage = null;
            this.btnBuscar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscar.onHoverState.BorderRadius = 40;
            this.btnBuscar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscar.onHoverState.BorderThickness = 2;
            this.btnBuscar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.onHoverState.IconLeftImage = null;
            this.btnBuscar.onHoverState.IconRightImage = null;
            this.btnBuscar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscar.OnIdleState.BorderRadius = 40;
            this.btnBuscar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscar.OnIdleState.BorderThickness = 2;
            this.btnBuscar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnIdleState.IconLeftImage = null;
            this.btnBuscar.OnIdleState.IconRightImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.OnIdleState.IconRightImage")));
            this.btnBuscar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscar.OnPressedState.BorderRadius = 40;
            this.btnBuscar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscar.OnPressedState.BorderThickness = 2;
            this.btnBuscar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnPressedState.IconLeftImage = null;
            this.btnBuscar.OnPressedState.IconRightImage = null;
            this.btnBuscar.Size = new System.Drawing.Size(50, 48);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.TextMarginLeft = 0;
            this.btnBuscar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBuscar.UseDefaultRadiusAndThickness = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // cbHora
            // 
            this.cbHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHora.BackColor = System.Drawing.Color.Transparent;
            this.cbHora.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.cbHora.BorderColor = System.Drawing.Color.Silver;
            this.cbHora.BorderRadius = 17;
            this.cbHora.Color = System.Drawing.Color.Silver;
            this.cbHora.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbHora.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbHora.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbHora.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbHora.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbHora.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbHora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHora.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHora.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbHora.FillDropDown = true;
            this.cbHora.FillIndicator = false;
            this.cbHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbHora.ForeColor = System.Drawing.Color.White;
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Icon = null;
            this.cbHora.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbHora.IndicatorColor = System.Drawing.Color.Gray;
            this.cbHora.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbHora.ItemBackColor = System.Drawing.Color.White;
            this.cbHora.ItemBorderColor = System.Drawing.Color.White;
            this.cbHora.ItemForeColor = System.Drawing.Color.Black;
            this.cbHora.ItemHeight = 26;
            this.cbHora.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbHora.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbHora.ItemTopMargin = 3;
            this.cbHora.Location = new System.Drawing.Point(196, 139);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(155, 32);
            this.cbHora.TabIndex = 169;
            this.cbHora.Text = null;
            this.cbHora.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbHora.TextLeftMargin = 5;
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
            this.btnExportarCapacidadesPDF.Size = new System.Drawing.Size(155, 47);
            this.btnExportarCapacidadesPDF.TabIndex = 168;
            this.btnExportarCapacidadesPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarCapacidadesPDF.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExportarCapacidadesPDF.TextMarginLeft = 0;
            this.btnExportarCapacidadesPDF.TextPadding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnExportarCapacidadesPDF.UseDefaultRadiusAndThickness = true;
            this.btnExportarCapacidadesPDF.Click += new System.EventHandler(this.btnExportarCapacidadesPDF_Click);
            // 
            // frmBuscarPorReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(515, 674);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarPorReserva";
            this.Text = "frmBuscarPorReserva";
            this.Load += new System.EventHandler(this.frmBuscarPorReserva_Load);
            this.MenuTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesPorHora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView dgvClientesPorHora;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpFecha;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBuscar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExportarCapacidadesExcel;
        private System.Windows.Forms.Label lblCapacidades;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExportarCapacidadesPDF;
        private Bunifu.UI.WinForms.BunifuDropdown cbHora;
    }
}