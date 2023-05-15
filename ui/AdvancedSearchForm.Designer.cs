namespace ui {
    partial class AdvancedSearchForm {
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
            AtmPressLbUnitLabel = new Label();
            ContactPressLbUnitLabel = new Label();
            RoughnessLbUnitLabel = new Label();
            AtmPressLabel = new Label();
            ContactPressLabel = new Label();
            RoughnessLabel = new Label();
            InterfacialMaterialLabel = new Label();
            ContactMaterialLabel = new Label();
            ContactPressLbTextBox = new TextBox();
            RoughnessLbTextBox = new TextBox();
            InterfacialMaterialTextBox = new TextBox();
            ContactMaterialTextBox = new TextBox();
            AtmPressLbTextBox = new TextBox();
            ContactMaterialCheckBox = new CheckBox();
            InterfacialMaterialCheckBox = new CheckBox();
            RoughnessCheckBox = new CheckBox();
            ContactPressCheckBox = new CheckBox();
            AtmPressCheckBox = new CheckBox();
            AtmPressUbTextBox = new TextBox();
            RoughnessUbTextBox = new TextBox();
            ContactPressUbTextBox = new TextBox();
            AtmPressUbUnitLabel = new Label();
            ContactPressUbUnitLabel = new Label();
            RoughnessUbUnitLabel = new Label();
            RoughnessTillLabel = new Label();
            ContactPressTillLabel = new Label();
            AtmPressTillLabel = new Label();
            label6 = new Label();
            label7 = new Label();
            MobileNoteLabel = new Label();
            AdvancedSearchButton = new Button();
            SearchResultDataGridView = new DataGridView();
            AppendSearchResultButton = new Button();
            ((System.ComponentModel.ISupportInitialize)SearchResultDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AtmPressLbUnitLabel
            // 
            AtmPressLbUnitLabel.AutoSize = true;
            AtmPressLbUnitLabel.Location = new Point(213, 235);
            AtmPressLbUnitLabel.Name = "AtmPressLbUnitLabel";
            AtmPressLbUnitLabel.Size = new Size(22, 17);
            AtmPressLbUnitLabel.TabIndex = 20;
            AtmPressLbUnitLabel.Text = "Pa";
            // 
            // ContactPressLbUnitLabel
            // 
            ContactPressLbUnitLabel.AutoSize = true;
            ContactPressLbUnitLabel.Location = new Point(213, 188);
            ContactPressLbUnitLabel.Name = "ContactPressLbUnitLabel";
            ContactPressLbUnitLabel.Size = new Size(34, 17);
            ContactPressLbUnitLabel.TabIndex = 19;
            ContactPressLbUnitLabel.Text = "MPa";
            // 
            // RoughnessLbUnitLabel
            // 
            RoughnessLbUnitLabel.AutoSize = true;
            RoughnessLbUnitLabel.Location = new Point(213, 142);
            RoughnessLbUnitLabel.Name = "RoughnessLbUnitLabel";
            RoughnessLbUnitLabel.Size = new Size(27, 17);
            RoughnessLbUnitLabel.TabIndex = 18;
            RoughnessLbUnitLabel.Text = "μm";
            // 
            // AtmPressLabel
            // 
            AtmPressLabel.AutoSize = true;
            AtmPressLabel.Location = new Point(57, 233);
            AtmPressLabel.Name = "AtmPressLabel";
            AtmPressLabel.Size = new Size(56, 17);
            AtmPressLabel.TabIndex = 17;
            AtmPressLabel.Text = "气体压力";
            // 
            // ContactPressLabel
            // 
            ContactPressLabel.AutoSize = true;
            ContactPressLabel.Location = new Point(57, 186);
            ContactPressLabel.Name = "ContactPressLabel";
            ContactPressLabel.Size = new Size(56, 17);
            ContactPressLabel.TabIndex = 16;
            ContactPressLabel.Text = "界面压力";
            // 
            // RoughnessLabel
            // 
            RoughnessLabel.AutoSize = true;
            RoughnessLabel.Location = new Point(57, 140);
            RoughnessLabel.Name = "RoughnessLabel";
            RoughnessLabel.Size = new Size(44, 17);
            RoughnessLabel.TabIndex = 15;
            RoughnessLabel.Text = "粗糙度";
            // 
            // InterfacialMaterialLabel
            // 
            InterfacialMaterialLabel.AutoSize = true;
            InterfacialMaterialLabel.Location = new Point(57, 93);
            InterfacialMaterialLabel.Name = "InterfacialMaterialLabel";
            InterfacialMaterialLabel.Size = new Size(56, 17);
            InterfacialMaterialLabel.TabIndex = 14;
            InterfacialMaterialLabel.Text = "界面填充";
            // 
            // ContactMaterialLabel
            // 
            ContactMaterialLabel.AutoSize = true;
            ContactMaterialLabel.Location = new Point(57, 46);
            ContactMaterialLabel.Name = "ContactMaterialLabel";
            ContactMaterialLabel.Size = new Size(32, 17);
            ContactMaterialLabel.TabIndex = 13;
            ContactMaterialLabel.Text = "材料";
            // 
            // ContactPressLbTextBox
            // 
            ContactPressLbTextBox.Location = new Point(110, 185);
            ContactPressLbTextBox.Name = "ContactPressLbTextBox";
            ContactPressLbTextBox.Size = new Size(100, 23);
            ContactPressLbTextBox.TabIndex = 21;
            // 
            // RoughnessLbTextBox
            // 
            RoughnessLbTextBox.Location = new Point(110, 140);
            RoughnessLbTextBox.Name = "RoughnessLbTextBox";
            RoughnessLbTextBox.Size = new Size(100, 23);
            RoughnessLbTextBox.TabIndex = 22;
            // 
            // InterfacialMaterialTextBox
            // 
            InterfacialMaterialTextBox.Location = new Point(110, 90);
            InterfacialMaterialTextBox.Name = "InterfacialMaterialTextBox";
            InterfacialMaterialTextBox.Size = new Size(100, 23);
            InterfacialMaterialTextBox.TabIndex = 23;
            InterfacialMaterialTextBox.MouseEnter += TextBox_MouseEnter_ShowNote;
            InterfacialMaterialTextBox.MouseLeave += TextBox_MouseLeave_DisableNote;
            // 
            // ContactMaterialTextBox
            // 
            ContactMaterialTextBox.Location = new Point(110, 46);
            ContactMaterialTextBox.Name = "ContactMaterialTextBox";
            ContactMaterialTextBox.Size = new Size(100, 23);
            ContactMaterialTextBox.TabIndex = 24;
            ContactMaterialTextBox.MouseEnter += TextBox_MouseEnter_ShowNote;
            ContactMaterialTextBox.MouseLeave += TextBox_MouseLeave_DisableNote;
            // 
            // AtmPressLbTextBox
            // 
            AtmPressLbTextBox.Location = new Point(110, 233);
            AtmPressLbTextBox.Name = "AtmPressLbTextBox";
            AtmPressLbTextBox.Size = new Size(100, 23);
            AtmPressLbTextBox.TabIndex = 25;
            // 
            // ContactMaterialCheckBox
            // 
            ContactMaterialCheckBox.AutoSize = true;
            ContactMaterialCheckBox.Checked = true;
            ContactMaterialCheckBox.CheckState = CheckState.Checked;
            ContactMaterialCheckBox.Location = new Point(36, 48);
            ContactMaterialCheckBox.Name = "ContactMaterialCheckBox";
            ContactMaterialCheckBox.Size = new Size(15, 14);
            ContactMaterialCheckBox.TabIndex = 26;
            ContactMaterialCheckBox.UseVisualStyleBackColor = true;
            ContactMaterialCheckBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // InterfacialMaterialCheckBox
            // 
            InterfacialMaterialCheckBox.AutoSize = true;
            InterfacialMaterialCheckBox.Checked = true;
            InterfacialMaterialCheckBox.CheckState = CheckState.Checked;
            InterfacialMaterialCheckBox.Location = new Point(36, 95);
            InterfacialMaterialCheckBox.Name = "InterfacialMaterialCheckBox";
            InterfacialMaterialCheckBox.Size = new Size(15, 14);
            InterfacialMaterialCheckBox.TabIndex = 27;
            InterfacialMaterialCheckBox.UseVisualStyleBackColor = true;
            InterfacialMaterialCheckBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // RoughnessCheckBox
            // 
            RoughnessCheckBox.AutoSize = true;
            RoughnessCheckBox.Checked = true;
            RoughnessCheckBox.CheckState = CheckState.Checked;
            RoughnessCheckBox.Location = new Point(36, 142);
            RoughnessCheckBox.Name = "RoughnessCheckBox";
            RoughnessCheckBox.Size = new Size(15, 14);
            RoughnessCheckBox.TabIndex = 28;
            RoughnessCheckBox.UseVisualStyleBackColor = true;
            RoughnessCheckBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // ContactPressCheckBox
            // 
            ContactPressCheckBox.AutoSize = true;
            ContactPressCheckBox.Checked = true;
            ContactPressCheckBox.CheckState = CheckState.Checked;
            ContactPressCheckBox.Location = new Point(36, 188);
            ContactPressCheckBox.Name = "ContactPressCheckBox";
            ContactPressCheckBox.Size = new Size(15, 14);
            ContactPressCheckBox.TabIndex = 29;
            ContactPressCheckBox.UseVisualStyleBackColor = true;
            ContactPressCheckBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // AtmPressCheckBox
            // 
            AtmPressCheckBox.AutoSize = true;
            AtmPressCheckBox.Checked = true;
            AtmPressCheckBox.CheckState = CheckState.Checked;
            AtmPressCheckBox.Location = new Point(36, 233);
            AtmPressCheckBox.Name = "AtmPressCheckBox";
            AtmPressCheckBox.Size = new Size(15, 14);
            AtmPressCheckBox.TabIndex = 30;
            AtmPressCheckBox.UseVisualStyleBackColor = true;
            AtmPressCheckBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // AtmPressUbTextBox
            // 
            AtmPressUbTextBox.Location = new Point(285, 233);
            AtmPressUbTextBox.Name = "AtmPressUbTextBox";
            AtmPressUbTextBox.Size = new Size(100, 23);
            AtmPressUbTextBox.TabIndex = 36;
            // 
            // RoughnessUbTextBox
            // 
            RoughnessUbTextBox.Location = new Point(285, 140);
            RoughnessUbTextBox.Name = "RoughnessUbTextBox";
            RoughnessUbTextBox.Size = new Size(100, 23);
            RoughnessUbTextBox.TabIndex = 35;
            // 
            // ContactPressUbTextBox
            // 
            ContactPressUbTextBox.Location = new Point(285, 185);
            ContactPressUbTextBox.Name = "ContactPressUbTextBox";
            ContactPressUbTextBox.Size = new Size(100, 23);
            ContactPressUbTextBox.TabIndex = 34;
            // 
            // AtmPressUbUnitLabel
            // 
            AtmPressUbUnitLabel.AutoSize = true;
            AtmPressUbUnitLabel.Location = new Point(388, 235);
            AtmPressUbUnitLabel.Name = "AtmPressUbUnitLabel";
            AtmPressUbUnitLabel.Size = new Size(22, 17);
            AtmPressUbUnitLabel.TabIndex = 33;
            AtmPressUbUnitLabel.Text = "Pa";
            // 
            // ContactPressUbUnitLabel
            // 
            ContactPressUbUnitLabel.AutoSize = true;
            ContactPressUbUnitLabel.Location = new Point(388, 188);
            ContactPressUbUnitLabel.Name = "ContactPressUbUnitLabel";
            ContactPressUbUnitLabel.Size = new Size(34, 17);
            ContactPressUbUnitLabel.TabIndex = 32;
            ContactPressUbUnitLabel.Text = "MPa";
            // 
            // RoughnessUbUnitLabel
            // 
            RoughnessUbUnitLabel.AutoSize = true;
            RoughnessUbUnitLabel.Location = new Point(388, 142);
            RoughnessUbUnitLabel.Name = "RoughnessUbUnitLabel";
            RoughnessUbUnitLabel.Size = new Size(27, 17);
            RoughnessUbUnitLabel.TabIndex = 31;
            RoughnessUbUnitLabel.Text = "μm";
            // 
            // RoughnessTillLabel
            // 
            RoughnessTillLabel.AutoSize = true;
            RoughnessTillLabel.Location = new Point(248, 143);
            RoughnessTillLabel.Name = "RoughnessTillLabel";
            RoughnessTillLabel.Size = new Size(20, 17);
            RoughnessTillLabel.TabIndex = 37;
            RoughnessTillLabel.Text = "至";
            // 
            // ContactPressTillLabel
            // 
            ContactPressTillLabel.AutoSize = true;
            ContactPressTillLabel.Location = new Point(248, 188);
            ContactPressTillLabel.Name = "ContactPressTillLabel";
            ContactPressTillLabel.Size = new Size(20, 17);
            ContactPressTillLabel.TabIndex = 38;
            ContactPressTillLabel.Text = "至";
            // 
            // AtmPressTillLabel
            // 
            AtmPressTillLabel.AutoSize = true;
            AtmPressTillLabel.Location = new Point(248, 236);
            AtmPressTillLabel.Name = "AtmPressTillLabel";
            AtmPressTillLabel.Size = new Size(20, 17);
            AtmPressTillLabel.TabIndex = 39;
            AtmPressTillLabel.Text = "至";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(210, 46);
            label6.Name = "label6";
            label6.Size = new Size(17, 21);
            label6.TabIndex = 40;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(210, 92);
            label7.Name = "label7";
            label7.Size = new Size(17, 21);
            label7.TabIndex = 41;
            label7.Text = "*";
            // 
            // MobileNoteLabel
            // 
            MobileNoteLabel.AutoSize = true;
            MobileNoteLabel.BackColor = SystemColors.Info;
            MobileNoteLabel.ForeColor = Color.Black;
            MobileNoteLabel.Location = new Point(110, 297);
            MobileNoteLabel.Name = "MobileNoteLabel";
            MobileNoteLabel.Size = new Size(0, 17);
            MobileNoteLabel.TabIndex = 43;
            // 
            // AdvancedSearchButton
            // 
            AdvancedSearchButton.Location = new Point(135, 288);
            AdvancedSearchButton.Name = "AdvancedSearchButton";
            AdvancedSearchButton.Size = new Size(75, 23);
            AdvancedSearchButton.TabIndex = 44;
            AdvancedSearchButton.Text = "搜索";
            AdvancedSearchButton.UseVisualStyleBackColor = true;
            AdvancedSearchButton.Click += AdvancedSearchButton_Click;
            // 
            // SearchResultDataGridView
            // 
            SearchResultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchResultDataGridView.Location = new Point(12, 317);
            SearchResultDataGridView.Name = "SearchResultDataGridView";
            SearchResultDataGridView.RowTemplate.Height = 25;
            SearchResultDataGridView.Size = new Size(540, 269);
            SearchResultDataGridView.TabIndex = 45;
            // 
            // AppendSearchResultButton
            // 
            AppendSearchResultButton.Location = new Point(285, 288);
            AppendSearchResultButton.Name = "AppendSearchResultButton";
            AppendSearchResultButton.Size = new Size(75, 23);
            AppendSearchResultButton.TabIndex = 46;
            AppendSearchResultButton.Text = "添加";
            AppendSearchResultButton.UseVisualStyleBackColor = true;
            AppendSearchResultButton.Click += AppendSearchResultButton_Click;
            // 
            // AdvancedSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 592);
            Controls.Add(AppendSearchResultButton);
            Controls.Add(SearchResultDataGridView);
            Controls.Add(AdvancedSearchButton);
            Controls.Add(MobileNoteLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(AtmPressTillLabel);
            Controls.Add(ContactPressTillLabel);
            Controls.Add(RoughnessTillLabel);
            Controls.Add(AtmPressUbTextBox);
            Controls.Add(RoughnessUbTextBox);
            Controls.Add(ContactPressUbTextBox);
            Controls.Add(AtmPressUbUnitLabel);
            Controls.Add(ContactPressUbUnitLabel);
            Controls.Add(RoughnessUbUnitLabel);
            Controls.Add(AtmPressCheckBox);
            Controls.Add(ContactPressCheckBox);
            Controls.Add(RoughnessCheckBox);
            Controls.Add(InterfacialMaterialCheckBox);
            Controls.Add(ContactMaterialCheckBox);
            Controls.Add(AtmPressLbTextBox);
            Controls.Add(ContactMaterialTextBox);
            Controls.Add(InterfacialMaterialTextBox);
            Controls.Add(RoughnessLbTextBox);
            Controls.Add(ContactPressLbTextBox);
            Controls.Add(AtmPressLbUnitLabel);
            Controls.Add(ContactPressLbUnitLabel);
            Controls.Add(RoughnessLbUnitLabel);
            Controls.Add(AtmPressLabel);
            Controls.Add(ContactPressLabel);
            Controls.Add(RoughnessLabel);
            Controls.Add(InterfacialMaterialLabel);
            Controls.Add(ContactMaterialLabel);
            Name = "AdvancedSearchForm";
            Text = "高级查询";
            Load += AdvancedSearchForm_Load;
            ((System.ComponentModel.ISupportInitialize)SearchResultDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AtmPressLbUnitLabel;
        private Label ContactPressLbUnitLabel;
        private Label RoughnessLbUnitLabel;
        private Label AtmPressLabel;
        private Label ContactPressLabel;
        private Label RoughnessLabel;
        private Label InterfacialMaterialLabel;
        private Label ContactMaterialLabel;
        private TextBox ContactPressLbTextBox;
        private TextBox RoughnessLbTextBox;
        private TextBox InterfacialMaterialTextBox;
        private TextBox ContactMaterialTextBox;
        private TextBox AtmPressLbTextBox;
        private CheckBox ContactMaterialCheckBox;
        private CheckBox InterfacialMaterialCheckBox;
        private CheckBox RoughnessCheckBox;
        private CheckBox ContactPressCheckBox;
        private CheckBox AtmPressCheckBox;
        private TextBox AtmPressUbTextBox;
        private TextBox RoughnessUbTextBox;
        private TextBox ContactPressUbTextBox;
        private Label AtmPressUbUnitLabel;
        private Label ContactPressUbUnitLabel;
        private Label RoughnessUbUnitLabel;
        private Label RoughnessTillLabel;
        private Label ContactPressTillLabel;
        private Label AtmPressTillLabel;
        private Label label6;
        private Label label7;
        private Label MobileNoteLabel;
        private Button AdvancedSearchButton;
        private DataGridView SearchResultDataGridView;
        private Button AppendSearchResultButton;
    }
}