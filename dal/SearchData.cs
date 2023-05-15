using dal.Database;
using ExcelDataReader;
using Microsoft.Data.Sqlite;
using model;
using System.Text;

namespace dal {

    public static class SearchData {
        /// <summary>
        /// 默认数据库
        /// </summary>
        public static readonly string DefaultDb =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tcr.sqlite");
        /// <summary>
        /// 默认接触热阻数据库表名
        /// </summary>
        public static readonly string testTableName = "tcr";
        /// <summary>
        /// 从数据库内获取某列的无重复元素
        /// </summary>
        /// <param name="colName">列名</param>
        /// <returns>所有查询结果的集合</returns>
        public static List<object> GetSelectItems(string colName) {
            DbAccess db = new DbAccess(DefaultDb);
            var reader = db.Select(testTableName, $"DISTINCT {colName}");
            List<object> items = new();
            if (reader == null || !reader.HasRows) {
                return items;
            }
            try {
                while (reader.Read()) {
                    items.Add(reader.GetValue(0));
                }
            }
            catch { }
            finally {
                reader.Close();
                db.CloseSqlConnection();
            }
            return items;
        }
        /// <summary>
        /// 单一条件的搜索
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public static bool CommonSearch(ref Contact contact) {
            DbAccess db = new DbAccess(DefaultDb);
            var reader = db.SelectWhere(testTableName, Constant.DATABASE_COL_NAME[PropertyType.TCR], ContactToQuery(contact));
            if (reader == null || !reader.HasRows) {
                return false;
            }

            reader.Read();
            contact.TCR = reader.GetDouble(0);
            reader.Close();
            db.CloseSqlConnection();
            return true;
        }
        /// <summary>
        /// 将接触信息转化为Sql查询条件
        /// </summary>
        /// <param name="contact"></param>
        /// <returns>sql查询语句的where条件语句字符串</returns>
        private static string ContactToQuery(Contact contact) {
            return $@"{Constant.DATABASE_COL_NAME[PropertyType.ContactMaterial]}='{contact.ContactMaterial}'
AND {Constant.DATABASE_COL_NAME[PropertyType.InterfacialMaterial]}='{contact.InterfacialMaterial}'
AND {Constant.DATABASE_COL_NAME[PropertyType.Roughness]} BETWEEN {contact.Roughness * .99} AND {contact.Roughness * 1.01}
AND {Constant.DATABASE_COL_NAME[PropertyType.ContactPress]} BETWEEN {contact.ContactPress * .99} AND {contact.ContactPress * 1.01}
AND {Constant.DATABASE_COL_NAME[PropertyType.AtmPress]} BETWEEN {contact.AtmPress * .99} AND {contact.AtmPress * 1.01}";
        }
        /// <summary>
        /// 高级查询
        /// </summary>
        /// <param name="model"></param>
        public static void AdvancedSearch(ref SearchModel model) {
            List<StringBuilder> conds = new List<StringBuilder>();
            if (model == null) { return; }
            AppendMultiSearchCond(Constant.DATABASE_COL_NAME[PropertyType.ContactMaterial], model.ContactMaterials, ref conds);
            AppendMultiSearchCond(Constant.DATABASE_COL_NAME[PropertyType.InterfacialMaterial], model.InterfacialMaterials, ref conds);
            AppendSearchLimCond(Constant.DATABASE_COL_NAME[PropertyType.Roughness], model.RoughnessLb, model.RoughnessUb, ref conds);
            AppendSearchLimCond(Constant.DATABASE_COL_NAME[PropertyType.ContactPress], model.ContactPressLb, model.ContactPressUb, ref conds);
            AppendSearchLimCond(Constant.DATABASE_COL_NAME[PropertyType.AtmPress], model.AtmPressLb, model.AtmPressUb, ref conds);
            if (conds.Count == 0) { model.SearchResult = null; return; }
            string operation = string.Join("AND ", conds);
            DbAccess db = new DbAccess(DefaultDb);
            var reader = db.SelectWhere(testTableName, "*", operation);
            if (reader == null) { model.SearchResult = null; return; }
            model.SearchResult = new List<Contact>();
            while (reader.Read()) {
                var contact = new Contact();
                GetContactFromReader(reader, contact);
                model.SearchResult.Add(contact);
            }
            reader.Close();
            db.CloseSqlConnection();
        }
        /// <summary>
        /// 从sql结果里读取接触热阻相关信息
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="contact"></param>
        private static void GetContactFromReader(SqliteDataReader reader, Contact contact) {
            contact.ContactMaterial = reader[Constant.DATABASE_COL_NAME[PropertyType.ContactMaterial]] as string ?? string.Empty;
            contact.InterfacialMaterial = reader[Constant.DATABASE_COL_NAME[PropertyType.InterfacialMaterial]] as string ?? string.Empty;
            contact.Roughness = reader.GetDouble(reader.GetOrdinal(Constant.DATABASE_COL_NAME[PropertyType.Roughness]));
            contact.ContactPress = reader.GetDouble(reader.GetOrdinal(Constant.DATABASE_COL_NAME[PropertyType.ContactPress]));
            contact.AtmPress = reader.GetDouble(reader.GetOrdinal(Constant.DATABASE_COL_NAME[PropertyType.AtmPress]));
            contact.TCR = reader.GetDouble(reader.GetOrdinal(Constant.DATABASE_COL_NAME[PropertyType.TCR]));
        }
        /// <summary>
        /// 从Excel文件里读取接触热阻信息
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="contact"></param>
        private static void GetContactFromReader(IExcelDataReader reader, Contact contact) {
            contact.ContactMaterial = reader.GetValue(Constant.IMPORT_FILE_COL_INDEX[PropertyType.ContactMaterial]).ToString() ?? string.Empty;
            contact.InterfacialMaterial = reader.GetValue(Constant.IMPORT_FILE_COL_INDEX[PropertyType.InterfacialMaterial]).ToString() ?? string.Empty;
            contact.Roughness = reader.GetDouble(Constant.IMPORT_FILE_COL_INDEX[PropertyType.Roughness]);
            contact.ContactPress = reader.GetDouble(Constant.IMPORT_FILE_COL_INDEX[PropertyType.ContactPress]);
            contact.AtmPress = reader.GetDouble(Constant.IMPORT_FILE_COL_INDEX[PropertyType.AtmPress]);
            contact.TCR = reader.GetDouble(Constant.IMPORT_FILE_COL_INDEX[PropertyType.TCR]);
        }
        private static void AppendSearchLimCond(string searchItem, double? lb, double? ub, ref List<StringBuilder> conds) {
            if (lb is null || ub is null) { return; }
            conds.Add(new StringBuilder().AppendLine($"{searchItem} BETWEEN {lb} AND {ub}"));
        }
        /// <summary>
        /// 处理','分隔的多项条件字符串
        /// </summary>
        /// <param name="searchItem"></param>
        /// <param name="searchCondString"></param>
        /// <param name="conds"></param>
        private static void AppendMultiSearchCond(string searchItem, string? searchCondString, ref List<StringBuilder> conds) {
            if (string.IsNullOrEmpty(searchCondString)) {
                return;
            }
            var materials = searchCondString.Split(new char[] { ',', '，' }, StringSplitOptions.RemoveEmptyEntries);
            if (materials.Length == 0) { return; }
            var cond = new StringBuilder();
            cond.Append($@"({searchItem} LIKE '%{materials[0].ToLower()}%'");
            if (materials.Length > 1) {
                for (int i = 1; i < materials.Length; i++) {
                    cond.Append($@" OR {searchItem} LIKE '%{materials[i].ToLower()}%'");
                }
            }
            cond.Append(")\n");
            conds.Add(cond);
        }
        /// <summary>
        /// 从Excel里导入接触热阻数据至数据库
        /// </summary>
        /// <param name="filename"></param>
        public static void ImportDataFromExcel(string filename) {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using var stream = File.OpenRead(filename);
            using var reader = ExcelReaderFactory.CreateReader(stream);
            reader.Read();
            var db = new DbAccess(DefaultDb);
            while (reader.Read()) {
                Contact contact = new Contact();
                GetContactFromReader(reader, contact);
                var sqlReader = db.SelectWhere(testTableName, Constant.DATABASE_COL_NAME[PropertyType.TCR], ContactToQuery(contact));
                if (sqlReader != null && sqlReader.HasRows) {
                    sqlReader.Read();
                    var id = sqlReader.GetInt32(0);
                    string updateQuery = $@"UPDATE {testTableName}
SET {Constant.DATABASE_COL_NAME[PropertyType.TCR]}={contact.TCR}
WHERE {Constant.DATABASE_COL_NAME[PropertyType.ID]}={id}";
                    db.ExecuteQuery(updateQuery);
                }
                else {
                    StringBuilder insertQuery = new StringBuilder();
                    insertQuery.AppendLine("INSERT INTO");
                    insertQuery.Append(testTableName);
                    insertQuery.Append('(');
                    insertQuery.Append(String.Join(',',
                        Constant.DATABASE_COL_NAME
                        .Where(pair => pair.Key != PropertyType.ID)
                        .Select(pair => pair.Value)));
                    insertQuery.Append(")\n");
                    insertQuery.AppendLine($"VALUES('{contact.ContactMaterial}','{contact.InterfacialMaterial}',{contact.Roughness},{contact.ContactPress},{contact.AtmPress},{contact.TCR})");
                    db.ExecuteQuery(insertQuery.ToString());
                }
            }
            db.CloseSqlConnection();
        }
    }
}