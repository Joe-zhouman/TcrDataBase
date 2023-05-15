using dal;
using model;

namespace ui {
    public partial class AdvancedSearchForm : Form {
        private MainForm _parent;
        private List<Contact> _contacts = new List<Contact>();
        private readonly string _noteString = "*请使用','分隔不同的搜索项";
        public AdvancedSearchForm(MainForm parent) {
            InitializeComponent();
            _parent = parent;
        }
        private void ControlTagInit() {
            ContactMaterialCheckBox.Tag = new List<TextBox> { ContactMaterialTextBox };
            InterfacialMaterialCheckBox.Tag = new List<TextBox> { InterfacialMaterialTextBox };
            RoughnessCheckBox.Tag = new List<TextBox> { RoughnessLbTextBox, RoughnessUbTextBox };
            ContactPressCheckBox.Tag = new List<TextBox> { ContactPressLbTextBox, ContactPressUbTextBox };
            AtmPressCheckBox.Tag = new List<TextBox> { AtmPressLbTextBox, AtmPressUbTextBox };
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e) {
            var checkBox = sender as CheckBox;
            if (checkBox is null) return;
            var textBoxes = checkBox.Tag as List<TextBox>;
            if (textBoxes is null) return;
            foreach (TextBox textBox in textBoxes) {
                textBox.Enabled = checkBox.Checked;
            }
        }

        private void AdvancedSearchForm_Load(object sender, EventArgs e) {
            ControlTagInit();
            foreach (var con in this.Controls) {
                if (con is CheckBox) {
                    CheckBox checkbox = (CheckBox)con;
                    checkbox.Checked = false;
                }
            }
            SearchResultTableInit();
        }

        private void TextBox_MouseLeave_DisableNote(object sender, EventArgs e) {
            if (sender is not TextBox) return;
            var textBox = sender as TextBox;
            if (textBox is null) return;
            if (!textBox.Enabled) return;
            MobileNoteLabel.Text = "";
        }
        private void TextBox_MouseEnter_ShowNote(object sender, EventArgs e) {
            if (sender is not TextBox) return;
            var textBox = sender as TextBox;
            if (textBox is null) return;
            if (!textBox.Enabled) return;
            MobileNoteLabel.Text = _noteString;
            Point position = textBox.Location;
            //position.X += (int)(MobileNoteLabel.Height * 1.2);
            position.Y += (int)(MobileNoteLabel.Height * 1.5);
            MobileNoteLabel.Location = position;
        }

        private void AdvancedSearchButton_Click(object sender, EventArgs e) {
            SearchResultTableInit();
            SearchModel search = new SearchModel();
            try {
                SetSearchModel(ref search);
            }
            catch (Exception) {
                MessageBox.Show($@"请输入一个正确的条件", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _contacts.Clear();
                return;
            }
            SearchData.AdvancedSearch(ref search);
            if (search.SearchResult is null || search.SearchResult.Count == 0) {
                MessageBox.Show($@"未查询到符合条件的接触", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _contacts.Clear();
                return;
            }
            _contacts = search.SearchResult;
            foreach (var contact in _contacts) {
                AppendCurentContactToTable(contact);
            }
        }
        private void AppendCurentContactToTable(Contact contact) {
            SearchResultDataGridView.Rows.Add(
                SearchResultDataGridView.Rows.Count - 1,
                contact.TCR,
                contact.ContactMaterial,
                contact.InterfacialMaterial,
                contact.Roughness,
                contact.ContactPress,
                contact.AtmPress
                );
        }
        private void SetSearchModel(ref SearchModel search) {
            SetStringValueFromTextBox(ContactMaterialTextBox, ref search.ContactMaterials);
            SetStringValueFromTextBox(InterfacialMaterialTextBox, ref search.InterfacialMaterials);
            SetDoubleValueFromTextBox(ContactPressLbTextBox, ref search.ContactPressLb);
            SetDoubleValueFromTextBox(ContactPressUbTextBox, ref search.ContactPressUb);
            SetDoubleValueFromTextBox(RoughnessLbTextBox, ref search.RoughnessLb);
            SetDoubleValueFromTextBox(RoughnessUbTextBox, ref search.RoughnessUb);
            SetDoubleValueFromTextBox(AtmPressLbTextBox, ref search.AtmPressLb);
            SetDoubleValueFromTextBox(AtmPressUbTextBox, ref search.AtmPressUb);
        }

        private void SetStringValueFromTextBox(TextBox textBox, ref string? value) {
            if (!textBox.Enabled) {
                value = null; return;
            }
            value = textBox.Text;
        }
        private void SetDoubleValueFromTextBox(TextBox textBox, ref double? value) {
            if (!textBox.Enabled) {
                value = null; return;
            }
            value = double.Parse(textBox.Text);
        }
        //private void ContactMaterialTextBox_MouseEnter(object sender, EventArgs e) {
        //    TextBoxMouseEnter(sender, e);
        //}

        private void SearchResultTableInit() {
            SearchResultDataGridView.Rows.Clear();
            SearchResultDataGridView.Columns.Clear();
            SearchResultDataGridView.Columns.Add("serial", "序号");
            SearchResultDataGridView.Columns.Add("tcr", "接触热阻");
            SearchResultDataGridView.Columns.Add("contactMaterial", "材料");
            SearchResultDataGridView.Columns.Add("interfacialMaterial", "界面填充");
            SearchResultDataGridView.Columns.Add("roughness", "粗糙度");
            SearchResultDataGridView.Columns.Add("contactPress", "界面压力");
            SearchResultDataGridView.Columns.Add("atmPress", "气体压力");

            SearchResultDataGridView.Columns["serial"].Width = 60;
            SearchResultDataGridView.Columns["tcr"].Width = 100;
            SearchResultDataGridView.Columns["contactMaterial"].Width = 100;
            SearchResultDataGridView.Columns["interfacialMaterial"].Width = 100;
            SearchResultDataGridView.Columns["roughness"].Width = 100;
            SearchResultDataGridView.Columns["contactPress"].Width = 100;
            SearchResultDataGridView.Columns["atmPress"].Width = 100;

            SearchResultDataGridView.Rows.Add(
                "",
                "mm2K/W",
                "",
                "",
                "μm",
                "Mpa",
                "Pa"
                );
        }

        private void AppendSearchResultButton_Click(object sender, EventArgs e) {
            if (_contacts is null || _contacts.Count == 0) return;
            foreach (Contact contact in _contacts) {
                _parent.AppendContactToTable(contact);
            }
        }


    }
}
