namespace Spa
{
    partial class frmListaAcompañantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaAcompañantes));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblServicio = new System.Windows.Forms.Label();
            this.dgvAcompañantes = new System.Windows.Forms.DataGridView();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExportarPdf = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExcel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcompañantes)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.MenuTop.Controls.Add(this.btnSalir);
            this.MenuTop.Controls.Add(this.lblServicio);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(833, 54);
            this.MenuTop.TabIndex = 10;
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
            this.btnSalir.Location = new System.Drawing.Point(790, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblServicio
            // 
            this.lblServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.ForeColor = System.Drawing.Color.White;
            this.lblServicio.Location = new System.Drawing.Point(19, 12);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(294, 31);
            this.lblServicio.TabIndex = 0;
            this.lblServicio.Text = "Lista de acompañantes";
            this.lblServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvAcompañantes
            // 
            this.dgvAcompañantes.AllowUserToAddRows = false;
            this.dgvAcompañantes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.dgvAcompañantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAcompañantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAcompañantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAcompañantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAcompañantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.dgvAcompañantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAcompañantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcompañantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAcompañantes.ColumnHeadersHeight = 45;
            this.dgvAcompañantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAcompañantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAcompañantes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAcompañantes.EnableHeadersVisualStyles = false;
            this.dgvAcompañantes.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAcompañantes.Location = new System.Drawing.Point(12, 111);
            this.dgvAcompañantes.MultiSelect = false;
            this.dgvAcompañantes.Name = "dgvAcompañantes";
            this.dgvAcompañantes.ReadOnly = true;
            this.dgvAcompañantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcompañantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAcompañantes.RowHeadersVisible = false;
            this.dgvAcompañantes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAcompañantes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAcompañantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAcompañantes.Size = new System.Drawing.Size(809, 365);
            this.dgvAcompañantes.TabIndex = 11;
            this.dgvAcompañantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcompañantes_CellContentClick);
            // 
            // eliminar
            // 
            this.eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eliminar.HeaderText = "";
            this.eliminar.Image = global::Spa.Properties.Resources.icons8_eliminar_48;
            this.eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnExportarPdf
            // 
            this.btnExportarPdf.AllowAnimations = true;
            this.btnExportarPdf.AllowMouseEffects = true;
            this.btnExportarPdf.AllowToggling = false;
            this.btnExportarPdf.AnimationSpeed = 200;
            this.btnExportarPdf.AutoGenerateColors = false;
            this.btnExportarPdf.AutoRoundBorders = false;
            this.btnExportarPdf.AutoSizeLeftIcon = true;
            this.btnExportarPdf.AutoSizeRightIcon = true;
            this.btnExportarPdf.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarPdf.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnExportarPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportarPdf.BackgroundImage")));
            this.btnExportarPdf.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarPdf.ButtonText = " Exportar a PDF";
            this.btnExportarPdf.ButtonTextMarginLeft = 0;
            this.btnExportarPdf.ColorContrastOnClick = 45;
            this.btnExportarPdf.ColorContrastOnHover = 45;
            this.btnExportarPdf.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnExportarPdf.CustomizableEdges = borderEdges1;
            this.btnExportarPdf.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportarPdf.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportarPdf.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportarPdf.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportarPdf.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExportarPdf.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarPdf.ForeColor = System.Drawing.Color.White;
            this.btnExportarPdf.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarPdf.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportarPdf.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExportarPdf.IconMarginLeft = 11;
            this.btnExportarPdf.IconPadding = 10;
            this.btnExportarPdf.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarPdf.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportarPdf.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExportarPdf.IconSize = 25;
            this.btnExportarPdf.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnExportarPdf.IdleBorderRadius = 40;
            this.btnExportarPdf.IdleBorderThickness = 2;
            this.btnExportarPdf.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnExportarPdf.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnExportarPdf.IdleIconLeftImage")));
            this.btnExportarPdf.IdleIconRightImage = null;
            this.btnExportarPdf.IndicateFocus = false;
            this.btnExportarPdf.Location = new System.Drawing.Point(682, 60);
            this.btnExportarPdf.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnExportarPdf.Name = "btnExportarPdf";
            this.btnExportarPdf.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportarPdf.OnDisabledState.BorderRadius = 40;
            this.btnExportarPdf.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarPdf.OnDisabledState.BorderThickness = 2;
            this.btnExportarPdf.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportarPdf.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportarPdf.OnDisabledState.IconLeftImage = null;
            this.btnExportarPdf.OnDisabledState.IconRightImage = null;
            this.btnExportarPdf.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnExportarPdf.onHoverState.BorderRadius = 40;
            this.btnExportarPdf.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarPdf.onHoverState.BorderThickness = 2;
            this.btnExportarPdf.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnExportarPdf.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExportarPdf.onHoverState.IconLeftImage = null;
            this.btnExportarPdf.onHoverState.IconRightImage = null;
            this.btnExportarPdf.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnExportarPdf.OnIdleState.BorderRadius = 40;
            this.btnExportarPdf.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarPdf.OnIdleState.BorderThickness = 2;
            this.btnExportarPdf.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnExportarPdf.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnExportarPdf.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnExportarPdf.OnIdleState.IconLeftImage")));
            this.btnExportarPdf.OnIdleState.IconRightImage = null;
            this.btnExportarPdf.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnExportarPdf.OnPressedState.BorderRadius = 40;
            this.btnExportarPdf.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarPdf.OnPressedState.BorderThickness = 2;
            this.btnExportarPdf.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnExportarPdf.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExportarPdf.OnPressedState.IconLeftImage = null;
            this.btnExportarPdf.OnPressedState.IconRightImage = null;
            this.btnExportarPdf.Size = new System.Drawing.Size(139, 49);
            this.btnExportarPdf.TabIndex = 16;
            this.btnExportarPdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarPdf.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExportarPdf.TextMarginLeft = 0;
            this.btnExportarPdf.TextPadding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnExportarPdf.UseDefaultRadiusAndThickness = true;
            this.btnExportarPdf.Click += new System.EventHandler(this.btnExportarPdf_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.AllowAnimations = true;
            this.btnExcel.AllowMouseEffects = true;
            this.btnExcel.AllowToggling = false;
            this.btnExcel.AnimationSpeed = 200;
            this.btnExcel.AutoGenerateColors = false;
            this.btnExcel.AutoRoundBorders = false;
            this.btnExcel.AutoSizeLeftIcon = true;
            this.btnExcel.AutoSizeRightIcon = true;
            this.btnExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExcel.ButtonText = " Exportar a Excel";
            this.btnExcel.ButtonTextMarginLeft = 0;
            this.btnExcel.ColorContrastOnClick = 45;
            this.btnExcel.ColorContrastOnHover = 45;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnExcel.CustomizableEdges = borderEdges2;
            this.btnExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExcel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExcel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExcel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExcel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExcel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExcel.IconMarginLeft = 11;
            this.btnExcel.IconPadding = 10;
            this.btnExcel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExcel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExcel.IconSize = 25;
            this.btnExcel.IdleBorderColor = System.Drawing.Color.Green;
            this.btnExcel.IdleBorderRadius = 40;
            this.btnExcel.IdleBorderThickness = 2;
            this.btnExcel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnExcel.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.IdleIconLeftImage")));
            this.btnExcel.IdleIconRightImage = null;
            this.btnExcel.IndicateFocus = false;
            this.btnExcel.Location = new System.Drawing.Point(537, 60);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExcel.OnDisabledState.BorderRadius = 40;
            this.btnExcel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExcel.OnDisabledState.BorderThickness = 2;
            this.btnExcel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExcel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExcel.OnDisabledState.IconLeftImage = null;
            this.btnExcel.OnDisabledState.IconRightImage = null;
            this.btnExcel.onHoverState.BorderColor = System.Drawing.Color.Green;
            this.btnExcel.onHoverState.BorderRadius = 40;
            this.btnExcel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExcel.onHoverState.BorderThickness = 2;
            this.btnExcel.onHoverState.FillColor = System.Drawing.Color.Green;
            this.btnExcel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExcel.onHoverState.IconLeftImage = null;
            this.btnExcel.onHoverState.IconRightImage = null;
            this.btnExcel.OnIdleState.BorderColor = System.Drawing.Color.Green;
            this.btnExcel.OnIdleState.BorderRadius = 40;
            this.btnExcel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExcel.OnIdleState.BorderThickness = 2;
            this.btnExcel.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnExcel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnExcel.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.OnIdleState.IconLeftImage")));
            this.btnExcel.OnIdleState.IconRightImage = null;
            this.btnExcel.OnPressedState.BorderColor = System.Drawing.Color.Green;
            this.btnExcel.OnPressedState.BorderRadius = 40;
            this.btnExcel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExcel.OnPressedState.BorderThickness = 2;
            this.btnExcel.OnPressedState.FillColor = System.Drawing.Color.Green;
            this.btnExcel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExcel.OnPressedState.IconLeftImage = null;
            this.btnExcel.OnPressedState.IconRightImage = null;
            this.btnExcel.Size = new System.Drawing.Size(139, 49);
            this.btnExcel.TabIndex = 15;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExcel.TextMarginLeft = 0;
            this.btnExcel.TextPadding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnExcel.UseDefaultRadiusAndThickness = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frmListaAcompañantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(833, 488);
            this.Controls.Add(this.btnExportarPdf);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgvAcompañantes);
            this.Controls.Add(this.MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaAcompañantes";
            this.Text = "frmListaAcompañantes";
            this.Load += new System.EventHandler(this.frmListaAcompañantes_Load);
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcompañantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblServicio;
        public System.Windows.Forms.DataGridView dgvAcompañantes;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExportarPdf;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExcel;
    }
}