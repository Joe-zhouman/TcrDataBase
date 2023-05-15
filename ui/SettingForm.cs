using dal;

namespace ui {
    public partial class SettingForm : Form {
        private MainForm _parent;
        public SettingForm(MainForm parent) {
            InitializeComponent();
            _parent = parent;
        }

        private void ApplyButton_Click(object sender, EventArgs e) {
            if (double.TryParse(ShellThicknessTextBox.Text, out var result)) {
                _parent.appConfig.ContactWidth = result;
                AppConfigSetting.WriteConfig(_parent.appConfig);
                MessageBox.Show($@"接触热阻材料等效厚度已被修改为{result}m，请注意fluent中的设置", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            MessageBox.Show($@"请输入一个正确的数", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void ConformButton_Click(object sender, EventArgs e) {
            ApplyButton_Click(sender, e);
            Close();
            Dispose();
        }

        private void CancelSettingButton_Click(object sender, EventArgs e) {
            SettingForm_Load(sender, e);
        }

        private void SettingForm_Load(object sender, EventArgs e) {
            ShellThicknessTextBox.Text = _parent.appConfig.ContactWidth.ToString();
        }
    }
}
