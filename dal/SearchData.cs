﻿using dal.Database;
using ExcelDataReader;
using Microsoft.Data.Sqlite;
using model;
using System.Text;

namespace dal {

    public static class SearchData {
        public static readonly string DefaultDb =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tcr.sqlite");
        public static readonly string testTableName = "tcr";
        public static List<object> GetSelectItems(string colName) {
            DbAccess db = new DbAccess(DefaultDb);
            var reader = db.Select(testTableName, $"DISTINCT {colName}");
            List<object> items = new List<object>();
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

        public static bool CommonSearch(ref Contact contact) {
            DbAccess db = new DbAccess(DefaultDb);
            var reader = db.SelectWhere(testTableName, Constant.DATABASE_COL_NAME[PropertyType.TCR], contact.ToSqlSearchQuery());
            if (reader == null || !reader.HasRows) {
                return false;
            }

            reader.Read();
            contact.TCR = reader.GetDouble(0);
            reader.Close();
            db.CloseSqlConnection();
            return true;
        }
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

        private static void GetContactFromReader(SqliteDataReader reader, Contact contact) {
            contact.ContactMaterial = reader[Constant.DATABASE_COL_NAME[PropertyType.ContactMaterial]] as string ?? string.Empty;
            contact.InterfacialMaterial = reader[Constant.DATABASE_COL_NAME[PropertyType.InterfacialMaterial]] as string ?? string.Empty;
            contact.Roughness = reader.GetDouble(reader.GetOrdinal(Constant.DATABASE_COL_NAME[PropertyType.Roughness]));
            contact.ContactPress = reader.GetDouble(reader.GetOrdinal(Constant.DATABASE_COL_NAME[PropertyType.ContactPress]));
            contact.AtmPress = reader.GetDouble(reader.GetOrdinal(Constant.DATABASE_COL_NAME[PropertyType.AtmPress]));
            contact.TCR = reader.GetDouble(reader.GetOrdinal(Constant.DATABASE_COL_NAME[PropertyType.TCR]));
        }
        private static void GetContactFromReader(IExcelDataReader reader, Contact contact) {
            contact.ContactMaterial = reader.GetValue(0).ToString() ?? string.Empty;
            contact.InterfacialMaterial = reader.GetValue(1).ToString() ?? string.Empty;
            contact.Roughness = reader.GetDouble(2);
            contact.ContactPress = reader.GetDouble(3);
            contact.AtmPress = reader.GetDouble(4);
            contact.TCR = reader.GetDouble(5);
        }
        private static void AppendSearchLimCond(string searchItem, double? lb, double? ub, ref List<StringBuilder> conds) {
            if (lb is null || ub is null) { return; }
            conds.Add(new StringBuilder($@"{searchItem} BETWEEN {lb} AND {ub}
"));
        }
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
        public static void ImportDataFromExcel(string filename) {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using var stream = File.OpenRead(filename);
            using var reader = ExcelReaderFactory.CreateReader(stream);
            reader.Read();
            var db = new DbAccess(DefaultDb);
            while (reader.Read()) {
                Contact contact = new Contact();
                GetContactFromReader(reader, contact);
                var sqlReader = db.SelectWhere(testTableName, Constant.DATABASE_COL_NAME[PropertyType.TCR], contact.ToSqlSearchQuery());
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