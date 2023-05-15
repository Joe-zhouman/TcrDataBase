using dal;
using model;
using System.Text;

namespace ui {

    public partial class MainForm : Form {
        private static readonly int _TABLE_CHECK_BOX_COL_INDEX = 1;
        private static readonly int _TABLE_SELECT_ALL_CHECK_BOX_ROW_INDEX = 0;

        /// <summary>
        /// 当前正在进行操作的接触
        /// </summary>
        private Contact _currentContact = new Contact();

        /// <summary>
        /// 当前应用相关配置
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
            MessageBox.Show($@"未查询到当前条件下的接触热阻", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ExportTUIButton_Click(object sender, EventArgs e) {
            GetExportLines();
            if (_exportLinesIndex.Count == 0) {
                MessageBox.Show($@"没有数据需要导出", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                Clipboard.SetText(GetFluentTuiStr());
                _exportLinesIndex.Clear();
                MessageBox.Show($@"数据已写入剪贴板，请粘贴在fluent TUI中使用", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportUddButton_Click(object sender, EventArgs e) {
            GetExportLines();
            if (_exportLinesIndex.Count == 0) {
                MessageBox.Show($@"没有数据需要导出", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                //设置过滤文件类型
                saveFileDialog.Filter = "Scheme文件|*.scm|所有文件|*.*";
                saveFileDialog.InitialDirectory = appConfig.DefaultSavePath;
                saveFileDialog.FileName = "tcr.scm";
                //显示对话框
                string fileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    //获取选择的文件名
                    fileName = saveFileDialog.FileName;
                    //在文本框中显示文件名
                    CreateFluentUserDefinedDatabaseFile(fileName);
                    appConfig.DefaultSavePath = Path.GetDirectoryName(fileName);

                    MessageBox.Show($@"数据已导入自定义数据库，请在fluent导入使用", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// 设置ComboBox数据的属性类型
        /// </summary>
        private void ComboBoxTypeTagInit() {
            ContactMaterialComboBox.Tag = PropertyType.ContactMaterial;
            InterfacialMaterialComboBox.Tag = PropertyType.InterfacialMaterial;
            RoughnessComboBox.Tag = PropertyType.Roughness;
            ContactPressComboBox.Tag = PropertyType.ContactPress;
            AtmPressComboBox.Tag = PropertyType.AtmPress;
        }

        /// <summary>
        /// 初始化所有ComboBox的Items列表
        /// </summary>
        private void ComboBoxItemsInit() {
            foreach (var control in this.PropertyGroupBox.Controls) {
                var box = control as ComboBox;
                if (box is null) { continue; }
                ComboBoxItemsInit(box);
            }
        }

        /// <summary>
        /// 初始化所有某个ComboBox的Items列表
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
                contact.InterfacialMaterial == "无" ? "none" : contact.InterfacialMaterial,
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
            SearchResultDataGridview.Columns.Add("serial", "序号");
            SearchResultDataGridview.Columns.Add(isExport);
            SearchResultDataGridview.Columns.Add("name", "导出名称");
            SearchResultDataGridview.Columns.Add("tcr", "接触热阻");
            SearchResultDataGridview.Columns.Add("contactMaterial", "材料");
            SearchResultDataGridview.Columns.Add("interfacialMaterial", "界面填充");
            SearchResultDataGridview.Columns.Add("roughness", "粗糙度");
            SearchResultDataGridview.Columns.Add("contactPress", "界面压力");
            SearchResultDataGridview.Columns.Add("atmPress", "气体压力");

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
                "μm",
                "Mpa",
                "Pa"
                );
        }
        /// <summary>
        /// 获取需要被输出的行号
        /// </summary>
        private void GetExportLines() {
            for (int i = 1 + _TABLE_SELECT_ALL_CHECK_BOX_ROW_INDEX; i < SearchResultDataGridview.Rows.Count; i++) {
                if (Convert.ToBoolean(SearchResultDataGridview.Rows[i].Cells["Export"].Value)) {
                    _exportLinesIndex.Add(i);
                }
            }
        }
        /// <summary>
        /// 将选择行的材料属性输出称为fluent TUI创建材料的命令
        /// </summary>
        /// <returns>fluent TUI命令字符串</returns>
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
        /// 获取当前行的材料在fluent中的名称.默认为"导出名称"栏的内容.
        /// 若"导出名称"栏字符串为空或"",则导出名称为
        /// [接触材料]-[界面材料]-[导出栏序号]
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
        /// 导出选择结果至fluent User-Difined Database (用户自定义数据库)
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
                Filter = "Excel文件|*.xlsx"
            };
            if (ofd.ShowDialog() == DialogResult.OK) {
                string filename = ofd.FileName;
                SearchData.ImportDataFromExcel(filename);
                MessageBox.Show($@"导入完毕", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// 应用设置按键点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingButton_Click(object sender, EventArgs e) {
            SettingForm settingForm = new SettingForm(this);
            settingForm.ShowDialog();
        }
        /// <summary>
        /// 高级搜索按键点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdvancedSearchButton_Click(object sender, EventArgs e) {
            AdvancedSearchForm advancedSearchForm = new AdvancedSearchForm(this);
            advancedSearchForm.ShowDialog();
        }
    }
}