﻿namespace Spa
{
    partial class frmDatosClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosClientes));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnBuscarHoraFecha = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtBuscador = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnBuscar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscarPorReserva = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.dgvCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.dgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.ColumnHeadersHeight = 50;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminar,
            this.editar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCliente.Location = new System.Drawing.Point(12, 112);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCliente.Size = new System.Drawing.Size(913, 419);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // eliminar
            // 
            this.eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.eliminar.HeaderText = "";
            this.eliminar.Image = global::Spa.Properties.Resources.icons8_eliminar_481;
            this.eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.eliminar.Width = 5;
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.editar.HeaderText = "";
            this.editar.Image = global::Spa.Properties.Resources.icons8_lápiz_482;
            this.editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Width = 5;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Spa.Properties.Resources.icons8_eliminar_48;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Spa.Properties.Resources.icons8_lápiz_48;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // btnBuscarHoraFecha
            // 
            this.btnBuscarHoraFecha.AllowAnimations = true;
            this.btnBuscarHoraFecha.AllowMouseEffects = true;
            this.btnBuscarHoraFecha.AllowToggling = false;
            this.btnBuscarHoraFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarHoraFecha.AnimationSpeed = 200;
            this.btnBuscarHoraFecha.AutoGenerateColors = false;
            this.btnBuscarHoraFecha.AutoRoundBorders = false;
            this.btnBuscarHoraFecha.AutoSizeLeftIcon = true;
            this.btnBuscarHoraFecha.AutoSizeRightIcon = true;
            this.btnBuscarHoraFecha.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarHoraFecha.BackColor1 = System.Drawing.Color.SeaGreen;
            this.btnBuscarHoraFecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarHoraFecha.BackgroundImage")));
            this.btnBuscarHoraFecha.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscarHoraFecha.ButtonText = " Buscar Por hora \r\ny fecha";
            this.btnBuscarHoraFecha.ButtonTextMarginLeft = 0;
            this.btnBuscarHoraFecha.ColorContrastOnClick = 45;
            this.btnBuscarHoraFecha.ColorContrastOnHover = 45;
            this.btnBuscarHoraFecha.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnBuscarHoraFecha.CustomizableEdges = borderEdges1;
            this.btnBuscarHoraFecha.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarHoraFecha.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuscarHoraFecha.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuscarHoraFecha.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuscarHoraFecha.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnBuscarHoraFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscarHoraFecha.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHoraFecha.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarHoraFecha.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscarHoraFecha.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnBuscarHoraFecha.IconMarginLeft = 11;
            this.btnBuscarHoraFecha.IconPadding = 10;
            this.btnBuscarHoraFecha.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarHoraFecha.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscarHoraFecha.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBuscarHoraFecha.IconSize = 25;
            this.btnBuscarHoraFecha.IdleBorderColor = System.Drawing.Color.SeaGreen;
            this.btnBuscarHoraFecha.IdleBorderRadius = 40;
            this.btnBuscarHoraFecha.IdleBorderThickness = 2;
            this.btnBuscarHoraFecha.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnBuscarHoraFecha.IdleIconLeftImage = null;
            this.btnBuscarHoraFecha.IdleIconRightImage = null;
            this.btnBuscarHoraFecha.IndicateFocus = false;
            this.btnBuscarHoraFecha.Location = new System.Drawing.Point(616, 12);
            this.btnBuscarHoraFecha.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnBuscarHoraFecha.Name = "btnBuscarHoraFecha";
            this.btnBuscarHoraFecha.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuscarHoraFecha.OnDisabledState.BorderRadius = 40;
            this.btnBuscarHoraFecha.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscarHoraFecha.OnDisabledState.BorderThickness = 2;
            this.btnBuscarHoraFecha.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuscarHoraFecha.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuscarHoraFecha.OnDisabledState.IconLeftImage = null;
            this.btnBuscarHoraFecha.OnDisabledState.IconRightImage = null;
            this.btnBuscarHoraFecha.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarHoraFecha.onHoverState.BorderRadius = 40;
            this.btnBuscarHoraFecha.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscarHoraFecha.onHoverState.BorderThickness = 2;
            this.btnBuscarHoraFecha.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarHoraFecha.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHoraFecha.onHoverState.IconLeftImage = null;
            this.btnBuscarHoraFecha.onHoverState.IconRightImage = null;
            this.btnBuscarHoraFecha.OnIdleState.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnBuscarHoraFecha.OnIdleState.BorderRadius = 40;
            this.btnBuscarHoraFecha.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscarHoraFecha.OnIdleState.BorderThickness = 2;
            this.btnBuscarHoraFecha.OnIdleState.FillColor = System.Drawing.Color.SeaGreen;
            this.btnBuscarHoraFecha.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHoraFecha.OnIdleState.IconLeftImage = null;
            this.btnBuscarHoraFecha.OnIdleState.IconRightImage = null;
            this.btnBuscarHoraFecha.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarHoraFecha.OnPressedState.BorderRadius = 40;
            this.btnBuscarHoraFecha.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscarHoraFecha.OnPressedState.BorderThickness = 2;
            this.btnBuscarHoraFecha.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarHoraFecha.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHoraFecha.OnPressedState.IconLeftImage = null;
            this.btnBuscarHoraFecha.OnPressedState.IconRightImage = null;
            this.btnBuscarHoraFecha.Size = new System.Drawing.Size(153, 49);
            this.btnBuscarHoraFecha.TabIndex = 13;
            this.btnBuscarHoraFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarHoraFecha.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscarHoraFecha.TextMarginLeft = 0;
            this.btnBuscarHoraFecha.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBuscarHoraFecha.UseDefaultRadiusAndThickness = true;
            this.btnBuscarHoraFecha.Click += new System.EventHandler(this.btnBuscarReserva_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.AcceptsReturn = false;
            this.txtBuscador.AcceptsTab = false;
            this.txtBuscador.AnimationSpeed = 200;
            this.txtBuscador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscador.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscador.BackgroundImage")));
            this.txtBuscador.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txtBuscador.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBuscador.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txtBuscador.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.txtBuscador.BorderRadius = 35;
            this.txtBuscador.BorderThickness = 2;
            this.txtBuscador.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscador.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.DefaultText = "";
            this.txtBuscador.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.txtBuscador.ForeColor = System.Drawing.Color.White;
            this.txtBuscador.HideSelection = true;
            this.txtBuscador.IconLeft = null;
            this.txtBuscador.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscador.IconPadding = 10;
            this.txtBuscador.IconRight = null;
            this.txtBuscador.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscador.Lines = new string[0];
            this.txtBuscador.Location = new System.Drawing.Point(12, 12);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtBuscador.MaxLength = 50;
            this.txtBuscador.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBuscador.Modified = false;
            this.txtBuscador.Multiline = false;
            this.txtBuscador.Name = "txtBuscador";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscador.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscador.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscador.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscador.OnIdleState = stateProperties4;
            this.txtBuscador.Padding = new System.Windows.Forms.Padding(3);
            this.txtBuscador.PasswordChar = '\0';
            this.txtBuscador.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBuscador.PlaceholderText = "Buscar Cliente";
            this.txtBuscador.ReadOnly = false;
            this.txtBuscador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscador.SelectedText = "";
            this.txtBuscador.SelectionLength = 0;
            this.txtBuscador.SelectionStart = 0;
            this.txtBuscador.ShortcutsEnabled = false;
            this.txtBuscador.Size = new System.Drawing.Size(254, 48);
            this.txtBuscador.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBuscador.TabIndex = 11;
            this.txtBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscador.TextMarginBottom = 0;
            this.txtBuscador.TextMarginLeft = 3;
            this.txtBuscador.TextMarginTop = 0;
            this.txtBuscador.TextPlaceholder = "Buscar Cliente";
            this.txtBuscador.UseSystemPasswordChar = false;
            this.txtBuscador.WordWrap = true;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AllowAnimations = true;
            this.btnBuscar.AllowMouseEffects = true;
            this.btnBuscar.AllowToggling = false;
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnBuscar.CustomizableEdges = borderEdges2;
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
            this.btnBuscar.Location = new System.Drawing.Point(272, 12);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
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
            this.btnBuscar.Size = new System.Drawing.Size(50, 49);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.TextMarginLeft = 0;
            this.btnBuscar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBuscar.UseDefaultRadiusAndThickness = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuscarPorReserva
            // 
            this.btnBuscarPorReserva.AllowAnimations = true;
            this.btnBuscarPorReserva.AllowMouseEffects = true;
            this.btnBuscarPorReserva.AllowToggling = false;
            this.btnBuscarPorReserva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarPorReserva.AnimationSpeed = 200;
            this.btnBuscarPorReserva.AutoGenerateColors = false;
            this.btnBuscarPorReserva.AutoRoundBorders = false;
            this.btnBuscarPorReserva.AutoSizeLeftIcon = true;
            this.btnBuscarPorReserva.AutoSizeRightIcon = true;
            this.btnBuscarPorReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPorReserva.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarPorReserva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarPorReserva.BackgroundImage")));
            this.btnBuscarPorReserva.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscarPorReserva.ButtonText = " Buscar Por reserva";
            this.btnBuscarPorReserva.ButtonTextMarginLeft = 0;
            this.btnBuscarPorReserva.ColorContrastOnClick = 45;
            this.btnBuscarPorReserva.ColorContrastOnHover = 45;
            this.btnBuscarPorReserva.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnBuscarPorReserva.CustomizableEdges = borderEdges3;
            this.btnBuscarPorReserva.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarPorReserva.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuscarPorReserva.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuscarPorReserva.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuscarPorReserva.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnBuscarPorReserva.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPorReserva.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorReserva.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPorReserva.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscarPorReserva.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnBuscarPorReserva.IconMarginLeft = 11;
            this.btnBuscarPorReserva.IconPadding = 10;
            this.btnBuscarPorReserva.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPorReserva.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscarPorReserva.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBuscarPorReserva.IconSize = 25;
            this.btnBuscarPorReserva.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarPorReserva.IdleBorderRadius = 40;
            this.btnBuscarPorReserva.IdleBorderThickness = 2;
            this.btnBuscarPorReserva.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarPorReserva.IdleIconLeftImage = null;
            this.btnBuscarPorReserva.IdleIconRightImage = null;
            this.btnBuscarPorReserva.IndicateFocus = false;
            this.btnBuscarPorReserva.Location = new System.Drawing.Point(338, 11);
            this.btnBuscarPorReserva.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnBuscarPorReserva.Name = "btnBuscarPorReserva";
            this.btnBuscarPorReserva.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuscarPorReserva.OnDisabledState.BorderRadius = 40;
            this.btnBuscarPorReserva.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscarPorReserva.OnDisabledState.BorderThickness = 2;
            this.btnBuscarPorReserva.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuscarPorReserva.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuscarPorReserva.OnDisabledState.IconLeftImage = null;
            this.btnBuscarPorReserva.OnDisabledState.IconRightImage = null;
            this.btnBuscarPorReserva.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarPorReserva.onHoverState.BorderRadius = 40;
            this.btnBuscarPorReserva.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscarPorReserva.onHoverState.BorderThickness = 2;
            this.btnBuscarPorReserva.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarPorReserva.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorReserva.onHoverState.IconLeftImage = null;
            this.btnBuscarPorReserva.onHoverState.IconRightImage = null;
            this.btnBuscarPorReserva.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarPorReserva.OnIdleState.BorderRadius = 40;
            this.btnBuscarPorReserva.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscarPorReserva.OnIdleState.BorderThickness = 2;
            this.btnBuscarPorReserva.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarPorReserva.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorReserva.OnIdleState.IconLeftImage = null;
            this.btnBuscarPorReserva.OnIdleState.IconRightImage = null;
            this.btnBuscarPorReserva.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarPorReserva.OnPressedState.BorderRadius = 40;
            this.btnBuscarPorReserva.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscarPorReserva.OnPressedState.BorderThickness = 2;
            this.btnBuscarPorReserva.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnBuscarPorReserva.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorReserva.OnPressedState.IconLeftImage = null;
            this.btnBuscarPorReserva.OnPressedState.IconRightImage = null;
            this.btnBuscarPorReserva.Size = new System.Drawing.Size(153, 49);
            this.btnBuscarPorReserva.TabIndex = 14;
            this.btnBuscarPorReserva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarPorReserva.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscarPorReserva.TextMarginLeft = 0;
            this.btnBuscarPorReserva.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBuscarPorReserva.UseDefaultRadiusAndThickness = true;
            this.btnBuscarPorReserva.Click += new System.EventHandler(this.btnBuscarPorReserva_Click);
            // 
            // frmDatosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(937, 543);
            this.Controls.Add(this.btnBuscarPorReserva);
            this.Controls.Add(this.btnBuscarHoraFecha);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDatosClientes";
            this.Text = "frmDatos";
            this.Load += new System.EventHandler(this.frmDatosClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvCliente;
       
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Bunifu.UI.WinForms.BunifuTextBox txtBuscador;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBuscar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBuscarHoraFecha;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBuscarPorReserva;
    }
}