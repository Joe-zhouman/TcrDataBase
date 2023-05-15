namespace ui {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            PropertyGroupBox = new GroupBox();
            TcrTextBox = new TextBox();
            label2 = new Label();
            TcrLabel = new Label();
            AtmPressUnitLabel = new Label();
            ContactPressUnitLabel = new Label();
            RoughnessUnitLabel = new Label();
            AtmPressLabel = new Label();
            AtmPressComboBox = new ComboBox();
            ContactPressLabel = new Label();
            ContactPressComboBox = new ComboBox();
            RoughnessLabel = new Label();
            RoughnessComboBox = new ComboBox();
            InterfacialMaterialLabel = new Label();
            InterfacialMaterialComboBox = new ComboBox();
            ContactMaterialLabel = new Label();
            ContactMaterialComboBox = new ComboBox();
            OperationGroupBox = new GroupBox();
            SettingButton = new Button();
            ImportButton = new Button();
            ExportUddButton = new Button();
            ExportTUIButton = new Button();
            AppendButton = new Button();
            SearchButton = new Button();
            SearchResultDataGridview = new DataGridView();
            bindingSource1 = new BindingSource(components);
            AdvancedSearchButton = new Button();
            PropertyGroupBox.SuspendLayout();
            OperationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchResultDataGridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // PropertyGroupBox
            // 
            PropertyGroupBox.Controls.Add(TcrTextBox);
            PropertyGroupBox.Controls.Add(label2);
            PropertyGroupBox.Controls.Add(TcrLabel);
            PropertyGroupBox.Controls.Add(AtmPressUnitLabel);
            PropertyGroupBox.Controls.Add(ContactPressUnitLabel);
            PropertyGroupBox.Controls.Add(RoughnessUnitLabel);
            PropertyGroupBox.Controls.Add(AtmPressLabel);
            PropertyGroupBox.Controls.Add(AtmPressComboBox);
            PropertyGroupBox.Controls.Add(ContactPressLabel);
            PropertyGroupBox.Controls.Add(ContactPressComboBox);
            PropertyGroupBox.Controls.Add(RoughnessLabel);
            PropertyGroupBox.Controls.Add(RoughnessComboBox);
            PropertyGroupBox.Controls.Add(InterfacialMaterialLabel);
            PropertyGroupBox.Controls.Add(InterfacialMaterialComboBox);
            PropertyGroupBox.Controls.Add(ContactMaterialLabel);
            PropertyGroupBox.Controls.Add(ContactMaterialComboBox);
            PropertyGroupBox.Location = new Point(47, 38);
            PropertyGroupBox.Name = "PropertyGroupBox";
            PropertyGroupBox.Size = new Size(247, 325);
            PropertyGroupBox.TabIndex = 0;
            PropertyGroupBox.TabStop = false;
            PropertyGroupBox.Text = "材料属性";
            // 
            // TcrTextBox
            // 
            TcrTextBox.Location = new Point(64, 285);
            TcrTextBox.Name = "TcrTextBox";
            TcrTextBox.ReadOnly = true;
            TcrTextBox.Size = new Size(100, 23);
            TcrTextBox.TabIndex = 16;
            TcrTextBox.Text = "0";
            TcrTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 288);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 15;
            label2.Text = "mm2K/W";
            // 
            // TcrLabel
            // 
            TcrLabel.AutoSize = true;
            TcrLabel.Location = new Point(6, 291);
            TcrLabel.Name = "TcrLabel";
            TcrLabel.Size = new Size(56, 17);
            TcrLabel.TabIndex = 14;
            TcrLabel.Text = "接触热阻";
            // 
            // AtmPressUnitLabel
            // 
            AtmPressUnitLabel.AutoSize = true;
            AtmPressUnitLabel.Location = new Point(191, 229);
            AtmPressUnitLabel.Name = "AtmPressUnitLabel";
            AtmPressUnitLabel.Size = new Size(22, 17);
            AtmPressUnitLabel.TabIndex = 12;
            AtmPressUnitLabel.Text = "Pa";
            // 
            // ContactPressUnitLabel
            // 
            ContactPressUnitLabel.AutoSize = true;
            ContactPressUnitLabel.Location = new Point(191, 182);
            ContactPressUnitLabel.Name = "ContactPressUnitLabel";
            ContactPressUnitLabel.Size = new Size(34, 17);
            ContactPressUnitLabel.TabIndex = 11;
            ContactPressUnitLabel.Text = "MPa";
            // 
            // RoughnessUnitLabel
            // 
            RoughnessUnitLabel.AutoSize = true;
            RoughnessUnitLabel.Location = new Point(191, 136);
            RoughnessUnitLabel.Name = "RoughnessUnitLabel";
            RoughnessUnitLabel.Size = new Size(27, 17);
            RoughnessUnitLabel.TabIndex = 10;
            RoughnessUnitLabel.Text = "μm";
            // 
            // AtmPressLabel
            // 
            AtmPressLabel.AutoSize = true;
            AtmPressLabel.Location = new Point(6, 229);
            AtmPressLabel.Name = "AtmPressLabel";
            AtmPressLabel.Size = new Size(56, 17);
            AtmPressLabel.TabIndex = 9;
            AtmPressLabel.Text = "气体压力";
            // 
            // AtmPressComboBox
            // 
            AtmPressComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AtmPressComboBox.FormattingEnabled = true;
            AtmPressComboBox.Items.AddRange(new object[] { "101325", "1" });
            AtmPressComboBox.Location = new Point(64, 226);
            AtmPressComboBox.Name = "AtmPressComboBox";
            AtmPressComboBox.Size = new Size(121, 25);
            AtmPressComboBox.TabIndex = 8;
            // 
            // ContactPressLabel
            // 
            ContactPressLabel.AutoSize = true;
            ContactPressLabel.Location = new Point(6, 182);
            ContactPressLabel.Name = "ContactPressLabel";
            ContactPressLabel.Size = new Size(56, 17);
            ContactPressLabel.TabIndex = 7;
            ContactPressLabel.Text = "界面压力";
            // 
            // ContactPressComboBox
            // 
            ContactPressComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ContactPressComboBox.FormattingEnabled = true;
            ContactPressComboBox.Items.AddRange(new object[] { "0.15", "0.5", "1.5" });
            ContactPressComboBox.Location = new Point(64, 179);
            ContactPressComboBox.Name = "ContactPressComboBox";
            ContactPressComboBox.Size = new Size(121, 25);
            ContactPressComboBox.TabIndex = 6;
            // 
            // RoughnessLabel
            // 
            RoughnessLabel.AutoSize = true;
            RoughnessLabel.Location = new Point(6, 136);
            RoughnessLabel.Name = "RoughnessLabel";
            RoughnessLabel.Size = new Size(44, 17);
            RoughnessLabel.TabIndex = 5;
            RoughnessLabel.Text = "粗糙度";
            // 
            // RoughnessComboBox
            // 
            RoughnessComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RoughnessComboBox.FormattingEnabled = true;
            RoughnessComboBox.Items.AddRange(new object[] { "0.35", "0.22" });
            RoughnessComboBox.Location = new Point(64, 133);
            RoughnessComboBox.Name = "RoughnessComboBox";
            RoughnessComboBox.Size = new Size(121, 25);
            RoughnessComboBox.TabIndex = 4;
            // 
            // InterfacialMaterialLabel
            // 
            InterfacialMaterialLabel.AutoSize = true;
            InterfacialMaterialLabel.Location = new Point(6, 89);
            InterfacialMaterialLabel.Name = "InterfacialMaterialLabel";
            InterfacialMaterialLabel.Size = new Size(56, 17);
            InterfacialMaterialLabel.TabIndex = 3;
            InterfacialMaterialLabel.Text = "界面填充";
            // 
            // InterfacialMaterialComboBox
            // 
            InterfacialMaterialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            InterfacialMaterialComboBox.FormattingEnabled = true;
            InterfacialMaterialComboBox.Items.AddRange(new object[] { "无", "Oring", "Gasket", "Qpad" });
            InterfacialMaterialComboBox.Location = new Point(64, 86);
            InterfacialMaterialComboBox.Name = "InterfacialMaterialComboBox";
            InterfacialMaterialComboBox.Size = new Size(121, 25);
            InterfacialMaterialComboBox.TabIndex = 2;
            // 
            // ContactMaterialLabel
            // 
            ContactMaterialLabel.AutoSize = true;
            ContactMaterialLabel.Location = new Point(6, 42);
            ContactMaterialLabel.Name = "ContactMaterialLabel";
            ContactMaterialLabel.Size = new Size(32, 17);
            ContactMaterialLabel.TabIndex = 1;
            ContactMaterialLabel.Text = "材料";
            // 
            // ContactMaterialComboBox
            // 
            ContactMaterialComboBox.DisplayMember = "0";
            ContactMaterialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ContactMaterialComboBox.FormattingEnabled = true;
            ContactMaterialComboBox.Items.AddRange(new object[] { "Al6061", "Al6062", "Al6063", "Al6064", "Al6065", "Al6066" });
            ContactMaterialComboBox.Location = new Point(64, 39);
            ContactMaterialComboBox.Name = "ContactMaterialComboBox";
            ContactMaterialComboBox.Size = new Size(121, 25);
            ContactMaterialComboBox.TabIndex = 0;
            ContactMaterialComboBox.Tag = "";
            // 
            // OperationGroupBox
            // 
            OperationGroupBox.Controls.Add(AdvancedSearchButton);
            OperationGroupBox.Controls.Add(SettingButton);
            OperationGroupBox.Controls.Add(ImportButton);
            OperationGroupBox.Controls.Add(ExportUddButton);
            OperationGroupBox.Controls.Add(ExportTUIButton);
            OperationGroupBox.Controls.Add(AppendButton);
            OperationGroupBox.Controls.Add(SearchButton);
            OperationGroupBox.Location = new Point(349, 43);
            OperationGroupBox.Name = "OperationGroupBox";
            OperationGroupBox.Size = new Size(354, 153);
            OperationGroupBox.TabIndex = 1;
            OperationGroupBox.TabStop = false;
            OperationGroupBox.Text = "常用操作";
            // 
            // SettingButton
            // 
            SettingButton.Location = new Point(230, 71);
            SettingButton.Name = "SettingButton";
            SettingButton.Size = new Size(86, 23);
            SettingButton.TabIndex = 5;
            SettingButton.Text = "设置";
            SettingButton.UseVisualStyleBackColor = true;
            SettingButton.Click += SettingButton_Click;
            // 
            // ImportButton
            // 
            ImportButton.Location = new Point(230, 31);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(86, 23);
            ImportButton.TabIndex = 4;
            ImportButton.Text = "导入数据";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // ExportUddButton
            // 
            ExportUddButton.Location = new Point(121, 71);
            ExportUddButton.Name = "ExportUddButton";
            ExportUddButton.Size = new Size(86, 23);
            ExportUddButton.TabIndex = 3;
            ExportUddButton.Text = "导出至UDD";
            ExportUddButton.UseVisualStyleBackColor = true;
            ExportUddButton.Click += ExportUddButton_Click;
            // 
            // ExportTUIButton
            // 
            ExportTUIButton.Location = new Point(121, 31);
            ExportTUIButton.Name = "ExportTUIButton";
            ExportTUIButton.Size = new Size(86, 23);
            ExportTUIButton.TabIndex = 2;
            ExportTUIButton.Text = "导出至TUI";
            ExportTUIButton.UseVisualStyleBackColor = true;
            ExportTUIButton.Click += ExportTUIButton_Click;
            // 
            // AppendButton
            // 
            AppendButton.Location = new Point(17, 71);
            AppendButton.Name = "AppendButton";
            AppendButton.Size = new Size(86, 23);
            AppendButton.TabIndex = 1;
            AppendButton.Text = "添加记录";
            AppendButton.UseVisualStyleBackColor = true;
            AppendButton.Click += AppendButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(17, 31);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(86, 23);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "查询";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchResultDataGridview
            // 
            SearchResultDataGridview.AllowUserToAddRows = false;
            SearchResultDataGridview.AllowUserToResizeColumns = false;
            SearchResultDataGridview.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            SearchResultDataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            SearchResultDataGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            SearchResultDataGridview.DefaultCellStyle = dataGridViewCellStyle2;
            SearchResultDataGridview.Location = new Point(349, 213);
            SearchResultDataGridview.Name = "SearchResultDataGridview";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            SearchResultDataGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            SearchResultDataGridview.RowHeadersWidth = 25;
            SearchResultDataGridview.RowTemplate.Height = 25;
            SearchResultDataGridview.Size = new Size(419, 150);
            SearchResultDataGridview.TabIndex = 2;
            SearchResultDataGridview.CellMouseUp += SearchResultDataGridview_CellMouseUp;
            SearchResultDataGridview.CellValueChanged += SearchResultDataGridview_CellValueChanged;
            // 
            // AdvancedSearchButton
            // 
            AdvancedSearchButton.Location = new Point(17, 110);
            AdvancedSearchButton.Name = "AdvancedSearchButton";
            AdvancedSearchButton.Size = new Size(86, 23);
            AdvancedSearchButton.TabIndex = 6;
            AdvancedSearchButton.Text = "高级查询";
            AdvancedSearchButton.UseVisualStyleBackColor = true;
            AdvancedSearchButton.Click += AdvancedSearchButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 377);
            Controls.Add(SearchResultDataGridview);
            Controls.Add(OperationGroupBox);
            Controls.Add(PropertyGroupBox);
            Name = "MainForm";
            Text = "接触热阻查询系统";
            Load += MainForm_Load;
            PropertyGroupBox.ResumeLayout(false);
            PropertyGroupBox.PerformLayout();
            OperationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SearchResultDataGridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox PropertyGroupBox;
        private ComboBox ContactMaterialComboBox;
        private TextBox TcrTextBox;
        private Label label2;
        private Label TcrLabel;
        private Label AtmPressUnitLabel;
        private Label ContactPressUnitLabel;
        private Label RoughnessUnitLabel;
        private Label AtmPressLabel;
        private ComboBox AtmPressComboBox;
        private Label ContactPressLabel;
        private ComboBox ContactPressComboBox;
        private Label RoughnessLabel;
        private ComboBox RoughnessComboBox;
        private Label InterfacialMaterialLabel;
        private ComboBox InterfacialMaterialComboBox;
        private Label ContactMaterialLabel;
        private GroupBox OperationGroupBox;
        private Button ExportUddButton;
        private Button ExportTUIButton;
        private Button AppendButton;
        private Button SearchButton;
        private DataGridView SearchResultDataGridview;
        private Button ImportButton;
        private Button SettingButton;
        private BindingSource bindingSource1;
        private Button AdvancedSearchButton;
    }
}