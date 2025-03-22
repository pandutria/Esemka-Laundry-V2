namespace EsemkaLaundryWithDesign
{
    partial class FormPrepaidPackage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrepaidPackage));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tbSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.tbId = new Bunifu.UI.WinForms.BunifuTextBox();
            this.cboPackage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nupPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuGroupBox3 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.linkAddNew = new System.Windows.Forms.LinkLabel();
            this.tbPhoneNumber = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).BeginInit();
            this.bunifuGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(233, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 38);
            this.label1.TabIndex = 59;
            this.label1.Text = "Transaction Prepaid Package";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeight = 25;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.SystemColors.Control;
            this.dgvData.Location = new System.Drawing.Point(31, 160);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(810, 167);
            this.dgvData.TabIndex = 61;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // tbSearch
            // 
            this.tbSearch.AcceptsReturn = false;
            this.tbSearch.AcceptsTab = false;
            this.tbSearch.AnimationSpeed = 200;
            this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbSearch.AutoSizeHeight = true;
            this.tbSearch.BackColor = System.Drawing.Color.Transparent;
            this.tbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSearch.BackgroundImage")));
            this.tbSearch.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.tbSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.tbSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbSearch.BorderRadius = 10;
            this.tbSearch.BorderThickness = 1;
            this.tbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.DefaultText = "";
            this.tbSearch.FillColor = System.Drawing.Color.White;
            this.tbSearch.HideSelection = true;
            this.tbSearch.IconLeft = null;
            this.tbSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.IconPadding = 10;
            this.tbSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("tbSearch.IconRight")));
            this.tbSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Lines = new string[0];
            this.tbSearch.Location = new System.Drawing.Point(535, 100);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbSearch.Modified = false;
            this.tbSearch.Multiline = false;
            this.tbSearch.Name = "tbSearch";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearch.OnIdleState = stateProperties4;
            this.tbSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearch.PlaceholderText = "Search prepaid package";
            this.tbSearch.ReadOnly = false;
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShortcutsEnabled = true;
            this.tbSearch.Size = new System.Drawing.Size(306, 40);
            this.tbSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbSearch.TabIndex = 60;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearch.TextMarginBottom = 0;
            this.tbSearch.TextMarginLeft = 5;
            this.tbSearch.TextMarginTop = 0;
            this.tbSearch.TextPlaceholder = "Search prepaid package";
            this.tbSearch.UseSystemPasswordChar = false;
            this.tbSearch.WordWrap = true;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // tbId
            // 
            this.tbId.AcceptsReturn = false;
            this.tbId.AcceptsTab = false;
            this.tbId.AnimationSpeed = 200;
            this.tbId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbId.AutoSizeHeight = true;
            this.tbId.BackColor = System.Drawing.Color.Transparent;
            this.tbId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbId.BackgroundImage")));
            this.tbId.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.tbId.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbId.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.tbId.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbId.BorderRadius = 10;
            this.tbId.BorderThickness = 1;
            this.tbId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbId.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.DefaultText = "";
            this.tbId.FillColor = System.Drawing.Color.White;
            this.tbId.HideSelection = true;
            this.tbId.IconLeft = null;
            this.tbId.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbId.IconPadding = 10;
            this.tbId.IconRight = null;
            this.tbId.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbId.Lines = new string[0];
            this.tbId.Location = new System.Drawing.Point(31, 366);
            this.tbId.MaxLength = 32767;
            this.tbId.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbId.Modified = false;
            this.tbId.Multiline = false;
            this.tbId.Name = "tbId";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbId.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbId.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbId.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbId.OnIdleState = stateProperties8;
            this.tbId.Padding = new System.Windows.Forms.Padding(3);
            this.tbId.PasswordChar = '\0';
            this.tbId.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbId.PlaceholderText = "Prepaid package ID";
            this.tbId.ReadOnly = false;
            this.tbId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbId.SelectedText = "";
            this.tbId.SelectionLength = 0;
            this.tbId.SelectionStart = 0;
            this.tbId.ShortcutsEnabled = true;
            this.tbId.Size = new System.Drawing.Size(494, 40);
            this.tbId.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbId.TabIndex = 81;
            this.tbId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbId.TextMarginBottom = 0;
            this.tbId.TextMarginLeft = 5;
            this.tbId.TextMarginTop = 0;
            this.tbId.TextPlaceholder = "Prepaid package ID";
            this.tbId.UseSystemPasswordChar = false;
            this.tbId.WordWrap = true;
            // 
            // cboPackage
            // 
            this.cboPackage.FormattingEnabled = true;
            this.cboPackage.Location = new System.Drawing.Point(32, 443);
            this.cboPackage.Name = "cboPackage";
            this.cboPackage.Size = new System.Drawing.Size(235, 24);
            this.cboPackage.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "Package";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 83;
            this.label4.Text = "Price";
            // 
            // nupPrice
            // 
            this.nupPrice.Location = new System.Drawing.Point(307, 444);
            this.nupPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nupPrice.Name = "nupPrice";
            this.nupPrice.Size = new System.Drawing.Size(218, 22);
            this.nupPrice.TabIndex = 82;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AllowAnimations = true;
            this.btnSubmit.AllowMouseEffects = true;
            this.btnSubmit.AllowToggling = false;
            this.btnSubmit.AnimationSpeed = 200;
            this.btnSubmit.AutoGenerateColors = false;
            this.btnSubmit.AutoRoundBorders = false;
            this.btnSubmit.AutoSizeLeftIcon = true;
            this.btnSubmit.AutoSizeRightIcon = true;
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubmit.ButtonText = "Submit";
            this.btnSubmit.ButtonTextMarginLeft = 0;
            this.btnSubmit.ColorContrastOnClick = 45;
            this.btnSubmit.ColorContrastOnHover = 45;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSubmit.CustomizableEdges = borderEdges1;
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSubmit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSubmit.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSubmit.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSubmit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.IconLeft = null;
            this.btnSubmit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSubmit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSubmit.IconMarginLeft = 11;
            this.btnSubmit.IconPadding = 10;
            this.btnSubmit.IconRight = null;
            this.btnSubmit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSubmit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSubmit.IconSize = 25;
            this.btnSubmit.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSubmit.IdleBorderRadius = 0;
            this.btnSubmit.IdleBorderThickness = 0;
            this.btnSubmit.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSubmit.IdleIconLeftImage = null;
            this.btnSubmit.IdleIconRightImage = null;
            this.btnSubmit.IndicateFocus = false;
            this.btnSubmit.Location = new System.Drawing.Point(579, 428);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSubmit.OnDisabledState.BorderRadius = 15;
            this.btnSubmit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubmit.OnDisabledState.BorderThickness = 1;
            this.btnSubmit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSubmit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSubmit.OnDisabledState.IconLeftImage = null;
            this.btnSubmit.OnDisabledState.IconRightImage = null;
            this.btnSubmit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.btnSubmit.onHoverState.BorderRadius = 15;
            this.btnSubmit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubmit.onHoverState.BorderThickness = 1;
            this.btnSubmit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.btnSubmit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.onHoverState.IconLeftImage = null;
            this.btnSubmit.onHoverState.IconRightImage = null;
            this.btnSubmit.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.btnSubmit.OnIdleState.BorderRadius = 15;
            this.btnSubmit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubmit.OnIdleState.BorderThickness = 1;
            this.btnSubmit.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.btnSubmit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.OnIdleState.IconLeftImage = null;
            this.btnSubmit.OnIdleState.IconRightImage = null;
            this.btnSubmit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.btnSubmit.OnPressedState.BorderRadius = 15;
            this.btnSubmit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubmit.OnPressedState.BorderThickness = 1;
            this.btnSubmit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.btnSubmit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.OnPressedState.IconLeftImage = null;
            this.btnSubmit.OnPressedState.IconRightImage = null;
            this.btnSubmit.Size = new System.Drawing.Size(131, 39);
            this.btnSubmit.TabIndex = 85;
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSubmit.TextMarginLeft = 0;
            this.btnSubmit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSubmit.UseDefaultRadiusAndThickness = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // bunifuGroupBox3
            // 
            this.bunifuGroupBox3.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox3.BorderRadius = 15;
            this.bunifuGroupBox3.BorderThickness = 1;
            this.bunifuGroupBox3.Controls.Add(this.lblAddress);
            this.bunifuGroupBox3.Controls.Add(this.lblName);
            this.bunifuGroupBox3.Controls.Add(this.linkAddNew);
            this.bunifuGroupBox3.Controls.Add(this.tbPhoneNumber);
            this.bunifuGroupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox3.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox3.LabelIndent = 10;
            this.bunifuGroupBox3.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox3.Location = new System.Drawing.Point(31, 501);
            this.bunifuGroupBox3.Name = "bunifuGroupBox3";
            this.bunifuGroupBox3.Size = new System.Drawing.Size(810, 145);
            this.bunifuGroupBox3.TabIndex = 86;
            this.bunifuGroupBox3.TabStop = false;
            this.bunifuGroupBox3.Text = "Customer Data";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(332, 91);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(453, 23);
            this.lblAddress.TabIndex = 91;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(332, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(453, 23);
            this.lblName.TabIndex = 90;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkAddNew
            // 
            this.linkAddNew.AutoSize = true;
            this.linkAddNew.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAddNew.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.linkAddNew.Location = new System.Drawing.Point(29, 91);
            this.linkAddNew.Name = "linkAddNew";
            this.linkAddNew.Size = new System.Drawing.Size(186, 23);
            this.linkAddNew.TabIndex = 85;
            this.linkAddNew.TabStop = true;
            this.linkAddNew.Text = "Not found? Add New+";
            this.linkAddNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddNew_LinkClicked);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.AcceptsReturn = false;
            this.tbPhoneNumber.AcceptsTab = false;
            this.tbPhoneNumber.AnimationSpeed = 200;
            this.tbPhoneNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbPhoneNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbPhoneNumber.AutoSizeHeight = true;
            this.tbPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.tbPhoneNumber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbPhoneNumber.BackgroundImage")));
            this.tbPhoneNumber.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.tbPhoneNumber.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbPhoneNumber.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.tbPhoneNumber.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbPhoneNumber.BorderRadius = 10;
            this.tbPhoneNumber.BorderThickness = 1;
            this.tbPhoneNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhoneNumber.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.DefaultText = "";
            this.tbPhoneNumber.FillColor = System.Drawing.Color.White;
            this.tbPhoneNumber.HideSelection = true;
            this.tbPhoneNumber.IconLeft = null;
            this.tbPhoneNumber.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhoneNumber.IconPadding = 10;
            this.tbPhoneNumber.IconRight = null;
            this.tbPhoneNumber.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhoneNumber.Lines = new string[0];
            this.tbPhoneNumber.Location = new System.Drawing.Point(32, 35);
            this.tbPhoneNumber.MaxLength = 32767;
            this.tbPhoneNumber.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbPhoneNumber.Modified = false;
            this.tbPhoneNumber.Multiline = false;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPhoneNumber.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbPhoneNumber.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPhoneNumber.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPhoneNumber.OnIdleState = stateProperties12;
            this.tbPhoneNumber.Padding = new System.Windows.Forms.Padding(3);
            this.tbPhoneNumber.PasswordChar = '\0';
            this.tbPhoneNumber.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbPhoneNumber.PlaceholderText = "Phone Number";
            this.tbPhoneNumber.ReadOnly = false;
            this.tbPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPhoneNumber.SelectedText = "";
            this.tbPhoneNumber.SelectionLength = 0;
            this.tbPhoneNumber.SelectionStart = 0;
            this.tbPhoneNumber.ShortcutsEnabled = true;
            this.tbPhoneNumber.Size = new System.Drawing.Size(207, 40);
            this.tbPhoneNumber.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbPhoneNumber.TabIndex = 84;
            this.tbPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPhoneNumber.TextMarginBottom = 0;
            this.tbPhoneNumber.TextMarginLeft = 5;
            this.tbPhoneNumber.TextMarginTop = 0;
            this.tbPhoneNumber.TextPlaceholder = "Phone Number";
            this.tbPhoneNumber.UseSystemPasswordChar = false;
            this.tbPhoneNumber.WordWrap = true;
            this.tbPhoneNumber.TextChanged += new System.EventHandler(this.tbPhoneNumber_TextChanged);
            // 
            // FormPrepaidPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 683);
            this.Controls.Add(this.bunifuGroupBox3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nupPrice);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.cboPackage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrepaidPackage";
            this.Text = "FormPrepaidPackage";
            this.Load += new System.EventHandler(this.FormPrepaidPackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).EndInit();
            this.bunifuGroupBox3.ResumeLayout(false);
            this.bunifuGroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvData;
        private Bunifu.UI.WinForms.BunifuTextBox tbSearch;
        private Bunifu.UI.WinForms.BunifuTextBox tbId;
        private System.Windows.Forms.ComboBox cboPackage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupPrice;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSubmit;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox3;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.LinkLabel linkAddNew;
        private Bunifu.UI.WinForms.BunifuTextBox tbPhoneNumber;
    }
}