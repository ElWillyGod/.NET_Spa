namespace Spa
{
    partial class frmCambiarHorasSpa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarHorasSpa));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblServicio = new System.Windows.Forms.Label();
            this.pnlModificar = new System.Windows.Forms.Panel();
            this.comboApertura = new Bunifu.UI.WinForms.BunifuDropdown();
            this.comboCierre = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarHorario = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuTop.SuspendLayout();
            this.pnlModificar.SuspendLayout();
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
            this.MenuTop.Size = new System.Drawing.Size(423, 54);
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
            this.btnSalir.Location = new System.Drawing.Point(380, 3);
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
            this.lblServicio.Location = new System.Drawing.Point(3, 12);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(262, 31);
            this.lblServicio.TabIndex = 0;
            this.lblServicio.Text = "Cambiar horario Spa";
            this.lblServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlModificar
            // 
            this.pnlModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.pnlModificar.Controls.Add(this.comboApertura);
            this.pnlModificar.Controls.Add(this.comboCierre);
            this.pnlModificar.Controls.Add(this.label1);
            this.pnlModificar.Controls.Add(this.btnModificarHorario);
            this.pnlModificar.Controls.Add(this.label2);
            this.pnlModificar.Location = new System.Drawing.Point(9, 62);
            this.pnlModificar.Name = "pnlModificar";
            this.pnlModificar.Size = new System.Drawing.Size(411, 226);
            this.pnlModificar.TabIndex = 11;
            // 
            // comboApertura
            // 
            this.comboApertura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboApertura.BackColor = System.Drawing.Color.Transparent;
            this.comboApertura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.comboApertura.BorderColor = System.Drawing.Color.Silver;
            this.comboApertura.BorderRadius = 17;
            this.comboApertura.Color = System.Drawing.Color.Silver;
            this.comboApertura.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.comboApertura.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboApertura.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboApertura.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboApertura.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.comboApertura.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.comboApertura.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboApertura.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.comboApertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboApertura.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.comboApertura.FillDropDown = true;
            this.comboApertura.FillIndicator = false;
            this.comboApertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboApertura.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboApertura.ForeColor = System.Drawing.Color.White;
            this.comboApertura.FormattingEnabled = true;
            this.comboApertura.Icon = null;
            this.comboApertura.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.comboApertura.IndicatorColor = System.Drawing.Color.Gray;
            this.comboApertura.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.comboApertura.ItemBackColor = System.Drawing.Color.White;
            this.comboApertura.ItemBorderColor = System.Drawing.Color.White;
            this.comboApertura.ItemForeColor = System.Drawing.Color.Black;
            this.comboApertura.ItemHeight = 26;
            this.comboApertura.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.comboApertura.ItemHighLightForeColor = System.Drawing.Color.White;
            this.comboApertura.ItemTopMargin = 3;
            this.comboApertura.Location = new System.Drawing.Point(187, 48);
            this.comboApertura.Name = "comboApertura";
            this.comboApertura.Size = new System.Drawing.Size(188, 32);
            this.comboApertura.TabIndex = 157;
            this.comboApertura.Text = null;
            this.comboApertura.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.comboApertura.TextLeftMargin = 5;
            // 
            // comboCierre
            // 
            this.comboCierre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCierre.BackColor = System.Drawing.Color.Transparent;
            this.comboCierre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.comboCierre.BorderColor = System.Drawing.Color.Silver;
            this.comboCierre.BorderRadius = 17;
            this.comboCierre.Color = System.Drawing.Color.Silver;
            this.comboCierre.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.comboCierre.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboCierre.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboCierre.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboCierre.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.comboCierre.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.comboCierre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboCierre.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.comboCierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCierre.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.comboCierre.FillDropDown = true;
            this.comboCierre.FillIndicator = false;
            this.comboCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCierre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboCierre.ForeColor = System.Drawing.Color.White;
            this.comboCierre.FormattingEnabled = true;
            this.comboCierre.Icon = null;
            this.comboCierre.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.comboCierre.IndicatorColor = System.Drawing.Color.Gray;
            this.comboCierre.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.comboCierre.ItemBackColor = System.Drawing.Color.White;
            this.comboCierre.ItemBorderColor = System.Drawing.Color.White;
            this.comboCierre.ItemForeColor = System.Drawing.Color.Black;
            this.comboCierre.ItemHeight = 26;
            this.comboCierre.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.comboCierre.ItemHighLightForeColor = System.Drawing.Color.White;
            this.comboCierre.ItemTopMargin = 3;
            this.comboCierre.Location = new System.Drawing.Point(187, 93);
            this.comboCierre.Name = "comboCierre";
            this.comboCierre.Size = new System.Drawing.Size(188, 32);
            this.comboCierre.TabIndex = 156;
            this.comboCierre.Text = null;
            this.comboCierre.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.comboCierre.TextLeftMargin = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 95;
            this.label1.Text = "Hora Cierre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModificarHorario
            // 
            this.btnModificarHorario.AllowAnimations = true;
            this.btnModificarHorario.AllowMouseEffects = true;
            this.btnModificarHorario.AllowToggling = false;
            this.btnModificarHorario.AnimationSpeed = 200;
            this.btnModificarHorario.AutoGenerateColors = false;
            this.btnModificarHorario.AutoRoundBorders = false;
            this.btnModificarHorario.AutoSizeLeftIcon = true;
            this.btnModificarHorario.AutoSizeRightIcon = true;
            this.btnModificarHorario.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarHorario.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnModificarHorario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarHorario.BackgroundImage")));
            this.btnModificarHorario.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificarHorario.ButtonText = "Modificar horario";
            this.btnModificarHorario.ButtonTextMarginLeft = 0;
            this.btnModificarHorario.ColorContrastOnClick = 45;
            this.btnModificarHorario.ColorContrastOnHover = 45;
            this.btnModificarHorario.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnModificarHorario.CustomizableEdges = borderEdges1;
            this.btnModificarHorario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificarHorario.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnModificarHorario.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnModificarHorario.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnModificarHorario.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnModificarHorario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarHorario.ForeColor = System.Drawing.Color.White;
            this.btnModificarHorario.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarHorario.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnModificarHorario.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnModificarHorario.IconMarginLeft = 11;
            this.btnModificarHorario.IconPadding = 10;
            this.btnModificarHorario.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarHorario.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnModificarHorario.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnModificarHorario.IconSize = 25;
            this.btnModificarHorario.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnModificarHorario.IdleBorderRadius = 35;
            this.btnModificarHorario.IdleBorderThickness = 2;
            this.btnModificarHorario.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnModificarHorario.IdleIconLeftImage = null;
            this.btnModificarHorario.IdleIconRightImage = null;
            this.btnModificarHorario.IndicateFocus = false;
            this.btnModificarHorario.Location = new System.Drawing.Point(105, 141);
            this.btnModificarHorario.Name = "btnModificarHorario";
            this.btnModificarHorario.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnModificarHorario.OnDisabledState.BorderRadius = 35;
            this.btnModificarHorario.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificarHorario.OnDisabledState.BorderThickness = 2;
            this.btnModificarHorario.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnModificarHorario.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnModificarHorario.OnDisabledState.IconLeftImage = null;
            this.btnModificarHorario.OnDisabledState.IconRightImage = null;
            this.btnModificarHorario.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnModificarHorario.onHoverState.BorderRadius = 35;
            this.btnModificarHorario.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificarHorario.onHoverState.BorderThickness = 2;
            this.btnModificarHorario.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnModificarHorario.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnModificarHorario.onHoverState.IconLeftImage = null;
            this.btnModificarHorario.onHoverState.IconRightImage = null;
            this.btnModificarHorario.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnModificarHorario.OnIdleState.BorderRadius = 35;
            this.btnModificarHorario.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificarHorario.OnIdleState.BorderThickness = 2;
            this.btnModificarHorario.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnModificarHorario.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnModificarHorario.OnIdleState.IconLeftImage = null;
            this.btnModificarHorario.OnIdleState.IconRightImage = null;
            this.btnModificarHorario.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnModificarHorario.OnPressedState.BorderRadius = 35;
            this.btnModificarHorario.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificarHorario.OnPressedState.BorderThickness = 2;
            this.btnModificarHorario.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnModificarHorario.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnModificarHorario.OnPressedState.IconLeftImage = null;
            this.btnModificarHorario.OnPressedState.IconRightImage = null;
            this.btnModificarHorario.Size = new System.Drawing.Size(201, 58);
            this.btnModificarHorario.TabIndex = 93;
            this.btnModificarHorario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificarHorario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificarHorario.TextMarginLeft = 0;
            this.btnModificarHorario.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnModificarHorario.UseDefaultRadiusAndThickness = true;
            this.btnModificarHorario.Click += new System.EventHandler(this.btnModificarHorario_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 27);
            this.label2.TabIndex = 94;
            this.label2.Text = "Hora apertura:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCambiarHorasSpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(423, 300);
            this.Controls.Add(this.pnlModificar);
            this.Controls.Add(this.MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCambiarHorasSpa";
            this.Text = "frmCambiarHorasSpa";
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            this.pnlModificar.ResumeLayout(false);
            this.pnlModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Panel pnlModificar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnModificarHorario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDropdown comboApertura;
        private Bunifu.UI.WinForms.BunifuDropdown comboCierre;
    }
}