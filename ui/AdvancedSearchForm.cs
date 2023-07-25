using dal;
using model;

namespace ui {
    public partial class AdvancedSearchForm : Form {
        private MainForm _parent;
        private List<Contact> _contacts = new List<Contact>();
        private readonly string _STARED_TEXTBOX_NOTE_STRING = "*请使用','分隔不同的搜索项";
        public AdvancedSearchForm(MainForm parent) {
            InitializeComponent();
            _parent = parent;
        }
        private void ControlTagInit() {
            ContactMaterialCheckBox.Tag = new List<TextBox> { ContactMaterialTextBox };
            InterfacialMaterialCheckBox.Tag = new List<TextBox> { InterfacialMaterialTextBox };
            GasConditionCheckBox.Tag = new List<TextBox>() { GasConditionTextBox };
            RoughnessCheckBox.Tag = new List<TextBox> { RoughnessLbTextBox, RoughnessUbTextBox };
            ContactPressCheckBox.Tag = new List<TextBox> { ContactPressLbTextBox, ContactPressUbTextBox };
            AtmPressCheckBox.Tag = new List<TextBox> { AtmPressLbTextBox, AtmPressUbTextBox };
            InterfacialTempCheckBox.Tag = new List<TextBox> { InterfacialTempLbTextBox, InterfacialTempUbTextBox };
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e) {
            var checkBox = sender as CheckBox;
            if(checkBox is null)
                return;
            var textBoxes = checkBox.Tag as List<TextBox>;
            if(textBoxes is null)
                return;
            foreach(TextBox textBox in textBoxes) {
                textBox.Enabled = checkBox.Checked;
            }
        }

        private void AdvancedSearchForm_Load(object sender, EventArgs e) {
            ControlTagInit();
            foreach(var con in this.Controls) {
                if(con is CheckBox) {
                    CheckBox checkbox = (CheckBox)con;
                    checkbox.Checked = false;
                }
            }
            SearchResultTableInit();
        }

        private void TextBox_MouseLeave_DisableNote(object sender, EventArgs e) {
            if(sender is not TextBox)
                return;
            var textBox = sender as TextBox;
            if(textBox is null)
                return;
            if(!textBox.Enabled)
                return;
            MobileNoteLabel.Text = "";
        }
        private void TextBox_MouseEnter_ShowNote(object sender, EventArgs e) {
            if(sender is not TextBox)
                return;
            var textBox = sender as TextBox;
            if(textBox is null)
                return;
            if(!textBox.Enabled)
                return;
            MobileNoteLabel.Text = _STARED_TEXTBOX_NOTE_STRING;
            Point position = textBox.Location;
            //position.X += (int)(MobileNoteLabel.Height * 1.2);
            position.Y += (int)(MobileNoteLabel.Height * 1.5);
            MobileNoteLabel.Location = position;
        }

        private void AdvancedSearchButton_Click(object sender, EventArgs e) {
            SearchResultDataGridview.Rows.Clear();
            SearchModel search = new SearchModel();
            try {
                SetSearchModel(ref search);
            }
            catch(Exception) {
                MessageBox.Show($@"请输入一个正确的条件", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _contacts.Clear();
                return;
            }
            SearchData.AdvancedSearch(ref search);
            if(search.SearchResult is null || search.SearchResult.Count == 0) {
                MessageBox.Show($@"未查询到符合条件的接触", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _contacts.Clear();
                return;
            }
            _contacts = search.SearchResult;
            foreach(var contact in _contacts) {
                AppendCurentContactToTable(contact);
            }
        }
        private void AppendCurentContactToTable(Contact contact) {
            SearchResultDataGridview.Rows.Add(
               SearchResultDataGridview.Rows.Count,
               contact.TCR,
               contact.ContactMaterial,
               contact.ContactMaterial2,
               contact.InterfacialMaterial == "无" ? "none" : contact.InterfacialMaterial,
               $"{contact.RoughnessLb}~{contact.RoughnessUb}",
               contact.ContactPress,
               contact.AtmPress,
               contact.GasCondtion,
               contact.InterfacialTemp
               );
        }
        private void SetSearchModel(ref SearchModel search) {
            SetStringValueFromTextBox(ContactMaterialTextBox, ref search.ContactMaterials);
            SetStringValueFromTextBox(InterfacialMaterialTextBox, ref search.InterfacialMaterials);
            SetStringValueFromTextBox(GasConditionTextBox, ref search.GasConditions);
            SetDoubleValueFromTextBox(ContactPressLbTextBox, ref search.ContactPressLb);
            SetDoubleValueFromTextBox(ContactPressUbTextBox, ref search.ContactPressUb);
            SetDoubleValueFromTextBox(RoughnessLbTextBox, ref search.RoughnessLb);
            SetDoubleValueFromTextBox(RoughnessUbTextBox, ref search.RoughnessUb);
            SetDoubleValueFromTextBox(AtmPressLbTextBox, ref search.AtmPressLb);
            SetDoubleValueFromTextBox(AtmPressUbTextBox, ref search.AtmPressUb);
            SetDoubleValueFromTextBox(InterfacialTempLbTextBox, ref search.InterfacialTempLb);
            SetDoubleValueFromTextBox(InterfacialTempUbTextBox, ref search.InterfacialTempUb);
        }

        private void SetStringValueFromTextBox(TextBox textBox, ref string? value) {
            if(!textBox.Enabled) {
                value = null;
                return;
            }
            value = textBox.Text;
        }
        private void SetDoubleValueFromTextBox(TextBox textBox, ref double? value) {
            if(!textBox.Enabled) {
                value = null;
                return;
            }
            value = double.Parse(textBox.Text);
        }
        //private void ContactMaterialTextBox_MouseEnter(object sender, EventArgs e) {
        //    TextBoxMouseEnter(sender, e);
        //}

        private void SearchResultTableInit() {
            SearchResultDataGridview.Rows.Clear();
            SearchResultDataGridview.Columns.Add("serial", "序号");
            SearchResultDataGridview.Columns.Add("tcr", "接触热阻");
            SearchResultDataGridview.Columns.Add("contactMaterial1", "材料1");
            SearchResultDataGridview.Columns.Add("contactMaterial2", "材料2");
            SearchResultDataGridview.Columns.Add("interfacialMaterial", "界面填充");
            SearchResultDataGridview.Columns.Add("roughness", "粗糙度");
            SearchResultDataGridview.Columns.Add("contactPress", "界面压力");
            SearchResultDataGridview.Columns.Add("atmPress", "气体压力");
            SearchResultDataGridview.Columns.Add("gasCondition", "气体环境");
            SearchResultDataGridview.Columns.Add("interfacialTemp", "界面温度");

            SearchResultDataGridview.Columns["serial"].Width = 60;
            SearchResultDataGridview.Columns["tcr"].Width = 100;
            SearchResultDataGridview.Columns["contactMaterial1"].Width = 100;
            SearchResultDataGridview.Columns["contactMaterial2"].Width = 100;
            SearchResultDataGridview.Columns["interfacialMaterial"].Width = 100;
            SearchResultDataGridview.Columns["roughness"].Width = 120;
            SearchResultDataGridview.Columns["contactPress"].Width = 100;
            SearchResultDataGridview.Columns["atmPress"].Width = 100;
            SearchResultDataGridview.Columns["gasCondition"].Width = 100;
            SearchResultDataGridview.Columns["interfacialTemp"].Width = 100;

            SearchResultDataGridview.Rows.Add(
                "",
                "mm2K/W",
                "",
                "",
                "",
                "μm",
                "Mpa",
                "Pa",
                "",
                "℃"
                );
        }

        private void AppendSearchResultButton_Click(object sender, EventArgs e) {
            if(_contacts is null || _contacts.Count == 0)
                return;
            foreach(Contact contact in _contacts) {
                _parent.AppendContactToTable(contact);
            }
        }


    }
}
