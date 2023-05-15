using dal;
using model;
using System.Text;

namespace ui {

    public partial class MainForm : Form {
        private static readonly int _TABLE_CHECK_BOX_COL_INDEX = 1;
        private static readonly int _TABLE_SELECT_ALL_CHECK_BOX_ROW_INDEX = 0;

        /// <summary>
        /// ��ǰ���ڽ��в����ĽӴ�
        /// </summary>
        private Contact _currentContact = new Contact();

        /// <summary>
        /// ��ǰӦ���������
        /// </summary>
        public AppConfig appConfig = new AppConfig();

        private List<int> _exportLinesIndex = new List<int>();

        public MainForm() {
            InitializeComponent();
        }

        private void AppendButton_Click(object sender, EventArgs e) {
            if (_currentContact.TCR == 0) return;
            AppendCurentContactToTable();
        }

        private void SearchButton_Click(object sender, EventArgs e) {
            GetCurrentContact();
            if (SearchData.CommonSearch(ref _currentContact)) {
                TcrTextBox.Text = _currentContact.TCR.ToString("N3");
                return;
            }
            _currentContact.TCR = 0;
            TcrTextBox.Text = "0";
            MessageBox.Show($@"δ��ѯ����ǰ�����µĽӴ�����", @"����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ExportTUIButton_Click(object sender, EventArgs e) {
            GetExportLines();
            if (_exportLinesIndex.Count == 0) {
                MessageBox.Show($@"û��������Ҫ����", @"����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                Clipboard.SetText(GetFluentTuiStr());
                _exportLinesIndex.Clear();
                MessageBox.Show($@"������д������壬��ճ����fluent TUI��ʹ��", @"��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportUddButton_Click(object sender, EventArgs e) {
            GetExportLines();
            if (_exportLinesIndex.Count == 0) {
                MessageBox.Show($@"û��������Ҫ����", @"����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                //���ù����ļ�����
                saveFileDialog.Filter = "Scheme�ļ�|*.scm|�����ļ�|*.*";
                saveFileDialog.InitialDirectory = appConfig.DefaultSavePath;
                saveFileDialog.FileName = "tcr.scm";
                //��ʾ�Ի���
                string fileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    //��ȡѡ����ļ���
                    fileName = saveFileDialog.FileName;
                    //���ı�������ʾ�ļ���
                    CreateFluentUserDefinedDatabaseFile(fileName);
                    appConfig.DefaultSavePath = Path.GetDirectoryName(fileName);

                    MessageBox.Show($@"�����ѵ����Զ������ݿ⣬����fluent����ʹ��", @"��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                _exportLinesIndex.Clear();
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            AppConfigSetting.CreateDefaultIni();
            AppConfigSetting.ReadConfig(ref appConfig);
            SearchResultTableInit();
            AllComboBoxInit();
            ComboBoxTypeTagInit();
            ComboBoxItemsInit();
        }

        /// <summary>
        /// ����ComboBox���ݵ���������
        /// </summary>
        private void ComboBoxTypeTagInit() {
            ContactMaterialComboBox.Tag = PropertyType.ContactMaterial;
            InterfacialMaterialComboBox.Tag = PropertyType.InterfacialMaterial;
            RoughnessComboBox.Tag = PropertyType.Roughness;
            ContactPressComboBox.Tag = PropertyType.ContactPress;
            AtmPressComboBox.Tag = PropertyType.AtmPress;
        }

        /// <summary>
        /// ��ʼ������ComboBox��Items�б�
        /// </summary>
        private void ComboBoxItemsInit() {
            foreach (var control in this.PropertyGroupBox.Controls) {
                var box = control as ComboBox;
                if (box is null) { continue; }
                ComboBoxItemsInit(box);
            }
        }

        /// <summary>
        /// ��ʼ������ĳ��ComboBox��Items�б�
        /// </summary>
        /// <param name="comboBox">combox</param>
        private void ComboBoxItemsInit(ComboBox comboBox) {
            comboBox.Items.Clear();
            PropertyType type = (PropertyType)comboBox.Tag;
            comboBox.Items.AddRange(SearchData.GetSelectItems(Constant.DATABASE_COL_NAME[type]).ToArray());
            if (comboBox.Items.Count > 0) {
                comboBox.SelectedIndex = 0;
            }
        }

        private void GetCurrentContact() {
            _currentContact = new Contact();
            _currentContact.ContactPress = Double.Parse(ContactPressComboBox.Text);
            _currentContact.AtmPress = Double.Parse(AtmPressComboBox.Text);
            _currentContact.Roughness = Double.Parse(RoughnessComboBox.Text);
            _currentContact.InterfacialMaterial = InterfacialMaterialComboBox.Text;
            _currentContact.ContactMaterial = ContactMaterialComboBox.Text;
        }

        private void AllComboBoxInit() {
            foreach (Control control in this.PropertyGroupBox.Controls) {
                if (control is ComboBox) {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = 0;
                }
            }
        }

        private void AppendCurentContactToTable() {
            AppendContactToTable(_currentContact);
        }

        public void AppendContactToTable(Contact contact) {
            SearchResultDataGridview.Rows.Add(
                SearchResultDataGridview.Rows.Count,
                true,
                "",
                contact.TCR,
                contact.ContactMaterial,
                contact.InterfacialMaterial == "��" ? "none" : contact.InterfacialMaterial,
                contact.Roughness,
                contact.ContactPress,
                contact.AtmPress
                );
        }

        private void SearchResultTableInit() {
            SearchResultDataGridview.Rows.Clear();
            DataGridViewCheckBoxColumn isExport = new DataGridViewCheckBoxColumn {
                Name = "Export",
                HeaderText = "",
                Width = 20
            };
            SearchResultDataGridview.Columns.Add("serial", "���");
            SearchResultDataGridview.Columns.Add(isExport);
            SearchResultDataGridview.Columns.Add("name", "��������");
            SearchResultDataGridview.Columns.Add("tcr", "�Ӵ�����");
            SearchResultDataGridview.Columns.Add("contactMaterial", "����");
            SearchResultDataGridview.Columns.Add("interfacialMaterial", "�������");
            SearchResultDataGridview.Columns.Add("roughness", "�ֲڶ�");
            SearchResultDataGridview.Columns.Add("contactPress", "����ѹ��");
            SearchResultDataGridview.Columns.Add("atmPress", "����ѹ��");

            SearchResultDataGridview.Columns["serial"].Width = 60;
            SearchResultDataGridview.Columns["name"].Width = 100;
            SearchResultDataGridview.Columns["tcr"].Width = 100;
            SearchResultDataGridview.Columns["contactMaterial"].Width = 100;
            SearchResultDataGridview.Columns["interfacialMaterial"].Width = 100;
            SearchResultDataGridview.Columns["roughness"].Width = 100;
            SearchResultDataGridview.Columns["contactPress"].Width = 100;
            SearchResultDataGridview.Columns["atmPress"].Width = 100;

            SearchResultDataGridview.Rows.Add(
                "",
                true,
                "",
                "mm2K/W",
                _currentContact.ContactMaterial,
                _currentContact.InterfacialMaterial,
                "��m",
                "Mpa",
                "Pa"
                );
        }
        /// <summary>
        /// ��ȡ��Ҫ��������к�
        /// </summary>
        private void GetExportLines() {
            for (int i = 1 + _TABLE_SELECT_ALL_CHECK_BOX_ROW_INDEX; i < SearchResultDataGridview.Rows.Count; i++) {
                if (Convert.ToBoolean(SearchResultDataGridview.Rows[i].Cells["Export"].Value)) {
                    _exportLinesIndex.Add(i);
                }
            }
        }
        /// <summary>
        /// ��ѡ���еĲ������������Ϊfluent TUI�������ϵ�����
        /// </summary>
        /// <returns>fluent TUI�����ַ���</returns>
        private string GetFluentTuiStr() {
            StringBuilder tui = new StringBuilder();
            foreach (var index in _exportLinesIndex) {
                DataGridViewRow row = SearchResultDataGridview.Rows[index];
                tui.AppendLine($"/define/materials/change-create aluminum {GetMatName(row)} yes const 1 yes constant 0 yes constant {GetEquivalentThermalConductivity((double)row.Cells["tcr"].Value)} no");
            }
            return tui.ToString();
        }

        private double GetEquivalentThermalConductivity(double thermaclContactResistance) {
            return appConfig.ContactWidth / thermaclContactResistance * appConfig.TcrTransFactor;
        }
        /// <summary>
        /// ��ȡ��ǰ�еĲ�����fluent�е�����.Ĭ��Ϊ"��������"��������.
        /// ��"��������"���ַ���Ϊ�ջ�"",�򵼳�����Ϊ
        /// [�Ӵ�����]-[�������]-[���������]
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private string GetMatName(DataGridViewRow row) {
            string name;
            if (row.Cells["name"].Value is null || row.Cells["name"].Value.ToString() == "") {
                name = $"{row.Cells["contactMaterial"].Value}-{row.Cells["interfacialMaterial"].Value}-{row.Cells["serial"].Value}";
            }
            else {
                name = (string)row.Cells["name"].Value;
            }
            return name;
        }
        /// <summary>
        /// ����ѡ������fluent User-Difined Database (�û��Զ������ݿ�)
        /// </summary>
        /// <param name="filename"></param>
        private void CreateFluentUserDefinedDatabaseFile(string filename) {
            using StreamWriter uddWriter = new(filename);
            try {
                uddWriter.Write(@";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;                                                              ;;;
;;;             Fluent USER DEFINED MATERIAL DATABASE            ;;;
;;;                                                              ;;;
;;; (name type[fluid/solid] (chemical-formula . formula)         ;;;
;;;             (prop1 (method1a . data1a) (method1b . data1b))  ;;;
;;;            (prop2 (method2a . data2a) (method2b . data2b)))  ;;;
;;;                                                              ;;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

");
                uddWriter.WriteLine("(");
                foreach (var index in _exportLinesIndex) {
                    DataGridViewRow row = SearchResultDataGridview.Rows[index];
                    uddWriter.WriteLine($"    ({GetMatName(row)} solid");
                    uddWriter.WriteLine("        (density (constant . 1))");
                    uddWriter.WriteLine("        (specific-heat (constant . 0))");
                    uddWriter.WriteLine($"        (thermal-conductivity (constant . {GetEquivalentThermalConductivity((double)row.Cells["tcr"].Value)}))");
                    uddWriter.WriteLine("    )");
                    uddWriter.WriteLine("");
                }
                uddWriter.WriteLine(")");
            }
            catch (Exception) {
                throw;
            }
            finally {
                uddWriter.Close();
            }
        }

        private void ImportButton_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new() {
                Filter = "Excel�ļ�|*.xlsx"
            };
            if (ofd.ShowDialog() == DialogResult.OK) {
                string filename = ofd.FileName;
                SearchData.ImportDataFromExcel(filename);
                MessageBox.Show($@"�������", @"��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ComboBoxItemsInit();
            }
        }

        private void SearchResultDataGridview_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex != _TABLE_CHECK_BOX_COL_INDEX) return;
            if (e.RowIndex != _TABLE_SELECT_ALL_CHECK_BOX_ROW_INDEX) return;
            bool selectAllCheckBoxChecked = Convert.ToBoolean(SearchResultDataGridview[_TABLE_CHECK_BOX_COL_INDEX,
                _TABLE_SELECT_ALL_CHECK_BOX_ROW_INDEX].Value);
            for (int rowIndex = 1 + _TABLE_SELECT_ALL_CHECK_BOX_ROW_INDEX;
                rowIndex < SearchResultDataGridview.RowCount;
                rowIndex++) {
                SearchResultDataGridview[e.ColumnIndex, rowIndex].Value = selectAllCheckBoxChecked;
            }
        }

        private void SearchResultDataGridview_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.ColumnIndex == _TABLE_CHECK_BOX_COL_INDEX && e.RowIndex >= _TABLE_SELECT_ALL_CHECK_BOX_ROW_INDEX) {
                SearchResultDataGridview.EndEdit();
            }
        }
        /// <summary>
        /// Ӧ�����ð�������¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingButton_Click(object sender, EventArgs e) {
            SettingForm settingForm = new SettingForm(this);
            settingForm.ShowDialog();
        }
        /// <summary>
        /// �߼�������������¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdvancedSearchButton_Click(object sender, EventArgs e) {
            AdvancedSearchForm advancedSearchForm = new AdvancedSearchForm(this);
            advancedSearchForm.ShowDialog();
        }
    }
}