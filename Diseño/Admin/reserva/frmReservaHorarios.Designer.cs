namespace Spa
{
    partial class frmReservaHorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservaHorarios));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReservarCupos = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.ColumnaClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaHoras = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnaBorrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnReservarCupos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvHorarios, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.85068F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.14932F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnReservarCupos
            // 
            this.btnReservarCupos.AllowAnimations = true;
            this.btnReservarCupos.AllowMouseEffects = true;
            this.btnReservarCupos.AllowToggling = false;
            this.btnReservarCupos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReservarCupos.AnimationSpeed = 200;
            this.btnReservarCupos.AutoGenerateColors = false;
            this.btnReservarCupos.AutoRoundBorders = false;
            this.btnReservarCupos.AutoSizeLeftIcon = true;
            this.btnReservarCupos.AutoSizeRightIcon = true;
            this.btnReservarCupos.BackColor = System.Drawing.Color.Transparent;
            this.btnReservarCupos.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnReservarCupos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReservarCupos.BackgroundImage")));
            this.btnReservarCupos.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReservarCupos.ButtonText = "Guardar";
            this.btnReservarCupos.ButtonTextMarginLeft = 0;
            this.btnReservarCupos.ColorContrastOnClick = 45;
            this.btnReservarCupos.ColorContrastOnHover = 45;
            this.tableLayoutPanel1.SetColumnSpan(this.btnReservarCupos, 2);
            this.btnReservarCupos.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnReservarCupos.CustomizableEdges = borderEdges1;
            this.btnReservarCupos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReservarCupos.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReservarCupos.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReservarCupos.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReservarCupos.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReservarCupos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservarCupos.ForeColor = System.Drawing.Color.White;
            this.btnReservarCupos.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservarCupos.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReservarCupos.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnReservarCupos.IconMarginLeft = 11;
            this.btnReservarCupos.IconPadding = 10;
            this.btnReservarCupos.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReservarCupos.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReservarCupos.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnReservarCupos.IconSize = 25;
            this.btnReservarCupos.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnReservarCupos.IdleBorderRadius = 35;
            this.btnReservarCupos.IdleBorderThickness = 2;
            this.btnReservarCupos.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnReservarCupos.IdleIconLeftImage = null;
            this.btnReservarCupos.IdleIconRightImage = null;
            this.btnReservarCupos.IndicateFocus = false;
            this.btnReservarCupos.Location = new System.Drawing.Point(177, 286);
            this.btnReservarCupos.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnReservarCupos.Name = "btnReservarCupos";
            this.btnReservarCupos.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReservarCupos.OnDisabledState.BorderRadius = 35;
            this.btnReservarCupos.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReservarCupos.OnDisabledState.BorderThickness = 2;
            this.btnReservarCupos.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReservarCupos.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReservarCupos.OnDisabledState.IconLeftImage = null;
            this.btnReservarCupos.OnDisabledState.IconRightImage = null;
            this.btnReservarCupos.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnReservarCupos.onHoverState.BorderRadius = 35;
            this.btnReservarCupos.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReservarCupos.onHoverState.BorderThickness = 2;
            this.btnReservarCupos.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnReservarCupos.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReservarCupos.onHoverState.IconLeftImage = null;
            this.btnReservarCupos.onHoverState.IconRightImage = null;
            this.btnReservarCupos.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnReservarCupos.OnIdleState.BorderRadius = 35;
            this.btnReservarCupos.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReservarCupos.OnIdleState.BorderThickness = 2;
            this.btnReservarCupos.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnReservarCupos.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReservarCupos.OnIdleState.IconLeftImage = null;
            this.btnReservarCupos.OnIdleState.IconRightImage = null;
            this.btnReservarCupos.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnReservarCupos.OnPressedState.BorderRadius = 35;
            this.btnReservarCupos.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReservarCupos.OnPressedState.BorderThickness = 2;
            this.btnReservarCupos.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnReservarCupos.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReservarCupos.OnPressedState.IconLeftImage = null;
            this.btnReservarCupos.OnPressedState.IconRightImage = null;
            this.btnReservarCupos.Size = new System.Drawing.Size(315, 60);
            this.btnReservarCupos.TabIndex = 137;
            this.btnReservarCupos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReservarCupos.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReservarCupos.TextMarginLeft = 0;
            this.btnReservarCupos.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReservarCupos.UseDefaultRadiusAndThickness = true;
            this.btnReservarCupos.Click += new System.EventHandler(this.btnReservarCupos_Click);
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.AllowUserToAddRows = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.dgvHorarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHorarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.dgvHorarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHorarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHorarios.ColumnHeadersHeight = 50;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaClientes,
            this.ColumnaNombre,
            this.ColumnaHoras,
            this.ColumnaBorrar});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvHorarios, 3);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHorarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHorarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHorarios.EnableHeadersVisualStyles = false;
            this.dgvHorarios.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvHorarios.Location = new System.Drawing.Point(3, 3);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHorarios.RowHeadersVisible = false;
            this.dgvHorarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHorarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorarios.Size = new System.Drawing.Size(664, 260);
            this.dgvHorarios.TabIndex = 2;
            this.dgvHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorarios_CellContentClick);
            // 
            // ColumnaClientes
            // 
            this.ColumnaClientes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnaClientes.HeaderText = "CI";
            this.ColumnaClientes.Name = "ColumnaClientes";
            this.ColumnaClientes.ReadOnly = true;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.ReadOnly = true;
            // 
            // ColumnaHoras
            // 
            this.ColumnaHoras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnaHoras.HeaderText = "Horas";
            this.ColumnaHoras.Name = "ColumnaHoras";
            // 
            // ColumnaBorrar
            // 
            this.ColumnaBorrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnaBorrar.HeaderText = "Borrar";
            this.ColumnaBorrar.Image = global::Spa.Properties.Resources.icons8_eliminar_483;
            this.ColumnaBorrar.Name = "ColumnaBorrar";
            this.ColumnaBorrar.Width = 54;
            // 
            // frmReservaHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(694, 390);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReservaHorarios";
            this.Text = "frmReservaHorarios";
            this.Load += new System.EventHandler(this.frmReservaHorarios_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView dgvHorarios;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReservarCupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnaHoras;
        private System.Windows.Forms.DataGridViewImageColumn ColumnaBorrar;
    }
}