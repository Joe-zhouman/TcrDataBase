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
            AtmPressUnitLabel = new Label();
            ContactPressUnitLabel = new Label();
            RoughnessUnitLabel = new Label();
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TillLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            MobileNoteLabel = new Label();
            AdvancedSearchButton = new Button();
            SearchResultDataGridView = new DataGridView();
            AppendSearchResultButton = new Button();
            ((System.ComponentModel.ISupportInitialize)SearchResultDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AtmPressUnitLabel
            // 
            AtmPressUnitLabel.AutoSize = true;
            AtmPressUnitLabel.Location = new Point(213, 235);
            AtmPressUnitLabel.Name = "AtmPressUnitLabel";
            AtmPressUnitLabel.Size = new Size(22, 17);
            AtmPressUnitLabel.TabIndex = 20;
            AtmPressUnitLabel.Text = "Pa";
            // 
            // ContactPressUnitLabel
            // 
            ContactPressUnitLabel.AutoSize = true;
            ContactPressUnitLabel.Location = new Point(213, 188);
            ContactPressUnitLabel.Name = "ContactPressUnitLabel";
            ContactPressUnitLabel.Size = new Size(34, 17);
            ContactPressUnitLabel.TabIndex = 19;
            ContactPressUnitLabel.Text = "MPa";
            // 
            // RoughnessUnitLabel
            // 
            RoughnessUnitLabel.AutoSize = true;
            RoughnessUnitLabel.Location = new Point(213, 142);
            RoughnessUnitLabel.Name = "RoughnessUnitLabel";
            RoughnessUnitLabel.Size = new Size(27, 17);
            RoughnessUnitLabel.TabIndex = 18;
            RoughnessUnitLabel.Text = "μm";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 235);
            label1.Name = "label1";
            label1.Size = new Size(22, 17);
            label1.TabIndex = 33;
            label1.Text = "Pa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 188);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 32;
            label2.Text = "MPa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(388, 142);
            label3.Name = "label3";
            label3.Size = new Size(27, 17);
            label3.TabIndex = 31;
            label3.Text = "μm";
            // 
            // TillLabel
            // 
            TillLabel.AutoSize = true;
            TillLabel.Location = new Point(248, 143);
            TillLabel.Name = "TillLabel";
            TillLabel.Size = new Size(20, 17);
            TillLabel.TabIndex = 37;
            TillLabel.Text = "至";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 188);
            label4.Name = "label4";
            label4.Size = new Size(20, 17);
            label4.TabIndex = 38;
            label4.Text = "至";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 236);
            label5.Name = "label5";
            label5.Size = new Size(20, 17);
            label5.TabIndex = 39;
            label5.Text = "至";
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
            SearchResultDataGridView.Location = new Point(462, 27);
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
            ClientSize = new Size(1024, 323);
            Controls.Add(AppendSearchResultButton);
            Controls.Add(SearchResultDataGridView);
            Controls.Add(AdvancedSearchButton);
            Controls.Add(MobileNoteLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TillLabel);
            Controls.Add(AtmPressUbTextBox);
            Controls.Add(RoughnessUbTextBox);
            Controls.Add(ContactPressUbTextBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
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
            Controls.Add(AtmPressUnitLabel);
            Controls.Add(ContactPressUnitLabel);
            Controls.Add(RoughnessUnitLabel);
            Controls.Add(AtmPressLabel);
            Controls.Add(ContactPressLabel);
            Controls.Add(RoughnessLabel);
            Controls.Add(InterfacialMaterialLabel);
            Controls.Add(ContactMaterialLabel);
            Name = "AdvancedSearchForm";
            Text = "AdvancedSearchForm";
            Load += AdvancedSearchForm_Load;
            ((System.ComponentModel.ISupportInitialize)SearchResultDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AtmPressUnitLabel;
        private Label ContactPressUnitLabel;
        private Label RoughnessUnitLabel;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label TillLabel;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label MobileNoteLabel;
        private Button AdvancedSearchButton;
        private DataGridView SearchResultDataGridView;
        private Button AppendSearchResultButton;
    }
}