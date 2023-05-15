namespace ui {
    partial class SettingForm {
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
            ShellThicknessLabel = new Label();
            ShellThicknessTextBox = new TextBox();
            ShellThicknessUnitLabel = new Label();
            ApplyButton = new Button();
            ConformButton = new Button();
            CancelSettingButton = new Button();
            SuspendLayout();
            // 
            // ShellThicknessLabel
            // 
            ShellThicknessLabel.AutoSize = true;
            ShellThicknessLabel.Location = new Point(38, 31);
            ShellThicknessLabel.Name = "ShellThicknessLabel";
            ShellThicknessLabel.Size = new Size(32, 17);
            ShellThicknessLabel.TabIndex = 0;
            ShellThicknessLabel.Text = "厚度";
            // 
            // ShellThicknessTextBox
            // 
            ShellThicknessTextBox.Location = new Point(76, 28);
            ShellThicknessTextBox.Name = "ShellThicknessTextBox";
            ShellThicknessTextBox.Size = new Size(84, 23);
            ShellThicknessTextBox.TabIndex = 1;
            // 
            // ShellThicknessUnitLabel
            // 
            ShellThicknessUnitLabel.AutoSize = true;
            ShellThicknessUnitLabel.Location = new Point(166, 31);
            ShellThicknessUnitLabel.Name = "ShellThicknessUnitLabel";
            ShellThicknessUnitLabel.Size = new Size(19, 17);
            ShellThicknessUnitLabel.TabIndex = 2;
            ShellThicknessUnitLabel.Text = "m";
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(38, 82);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(47, 24);
            ApplyButton.TabIndex = 3;
            ApplyButton.Text = "应用";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // ConformButton
            // 
            ConformButton.Location = new Point(91, 82);
            ConformButton.Name = "ConformButton";
            ConformButton.Size = new Size(47, 24);
            ConformButton.TabIndex = 4;
            ConformButton.Text = "确认";
            ConformButton.UseVisualStyleBackColor = true;
            ConformButton.Click += ConformButton_Click;
            // 
            // CancelSettingButton
            // 
            CancelSettingButton.Location = new Point(144, 82);
            CancelSettingButton.Name = "CancelSettingButton";
            CancelSettingButton.Size = new Size(47, 24);
            CancelSettingButton.TabIndex = 5;
            CancelSettingButton.Text = "取消";
            CancelSettingButton.UseVisualStyleBackColor = true;
            CancelSettingButton.Click += CancelSettingButton_Click;
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 129);
            Controls.Add(CancelSettingButton);
            Controls.Add(ConformButton);
            Controls.Add(ApplyButton);
            Controls.Add(ShellThicknessUnitLabel);
            Controls.Add(ShellThicknessTextBox);
            Controls.Add(ShellThicknessLabel);
            Name = "SettingForm";
            Text = "设置";
            Load += SettingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ShellThicknessLabel;
        private TextBox ShellThicknessTextBox;
        private Label ShellThicknessUnitLabel;
        private Button ApplyButton;
        private Button ConformButton;
        private Button CancelSettingButton;
    }
}