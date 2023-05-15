// Joe
// 周漫
// 2021060715:47

using Microsoft.Data.Sqlite;
using System.Text;

namespace dal.Database {
    public class DbAccess {
        private SqliteConnection _dbConnection;
        private SqliteCommand _dbCommand;
        private SqliteDataReader _reader;
        public DbAccess() { }

        public DbAccess(string connectionString) {
            OpenDb(connectionString);
        }

        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="connectionString"></param>
        public void OpenDb(string connectionString) {
            try {
                _dbConnection = new SqliteConnection($@"Data Source={connectionString}");
                _dbConnection.Open();
            }
            catch (Exception e) {
                CloseSqlConnection();
                throw;
            }
        }
        /// <summary>
        /// 关闭连接
        /// </summary>
        public void CloseSqlConnection() {
            _dbCommand?.Dispose();
            _dbCommand = null;
            _reader?.Dispose();
            _reader = null;
            _dbConnection?.Close();
            _dbConnection = null;

        }
        /// <summary>
        /// 执行 sql 语句
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <returns></returns>
        public SqliteDataReader ExecuteQuery(string sqlQuery) {
            try {
                _dbCommand = _dbConnection.CreateCommand();
                _dbCommand.CommandText = sqlQuery;
                _reader = _dbCommand.ExecuteReader();
                return _reader;
            }
            catch (Exception e) {
                CloseSqlConnection();
                throw;
            }

        }
        /// <summary>
        /// 是否已经创建表
        /// </summary>
        /// <param name="tableName">表的名称</param>
        /// <returns></returns>
        public bool HasTableCreated(string tableName) {
            var query = ExecuteQuery($@"SELECT count(*) 
FROM sqlite_master
WHERE type='table'
AND name='{tableName}");
            query.Read();
            try {
                return query.GetBoolean(0);
            }
            catch (Exception e) {
                CloseSqlConnection();
                throw new SqliteException(e.Message, 1);
            }
        }
        /// <summary>
        /// 创建表
        /// </summary>
        /// <param name="tableName">表的名称</param>
        /// <param name="colName">列的名称数组</param>
        /// <param name="colType">列类型的名称数组</param>
        /// <param name="keyIndex">主键位置</param>
        /// <param name="notNull">非空列的编号</param>
        /// <returns></returns>
        public SqliteDataReader CreateTable(string tableName, string[] colName, DataType[] colType, int keyIndex = -1,
            int[] notNull = null) {
            if (colName.Length != colType.Length) {
                throw new SqliteException("The length of colName and colType are inconsistent!", 21);
            }
            bool[] isNotNull = new bool[colName.Length];
            if (notNull != null)
                foreach (int i in notNull) {
                    isNotNull[i] = true;
                }

            StringBuilder tmp = new StringBuilder();
            for (int i = 0; i < colName.Length; i++) {
                tmp.Append($@"{colName[i]} {colType[i]}");
                if (keyIndex == i) {
                    tmp.Append(@" PRIMARY KEY");
                }
                if (isNotNull[i]) {
                    tmp.Append(@" NOT NULL");
                }
                tmp.AppendLine($@"{(i == colName.Length - 1 ? ' ' : ',')}");
            }
#if DEBUG
            Console.WriteLine($@"CREATE TABLE {tableName} (
{tmp})");
#endif
            return ExecuteQuery($@"CREATE TABLE {tableName} (
{tmp})");
        }
        /// <summary>
        /// 删除表
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns></returns>
        public SqliteDataReader DropTable(string tableName) {
            return ExecuteQuery($@"DROP TABLE {tableName}");
        }
        /// <summary>
        /// 读取表内所有数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public SqliteDataReader ReadFullTable(string tableName) {
            return ExecuteQuery($@"SELECT * FROM {tableName}");
        }
        /// <summary>
        /// 插入数据（数据已转化为字符串）
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public SqliteDataReader InsertInto(string tableName, string values) {
            return ExecuteQuery($@"INSERT INTO {tableName}
VALUES ({values})");
        }
        /// <summary>
        /// 在指定列中插入数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="cols"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public SqliteDataReader InsertIntoSpecific(string tableName, string cols, string values) {
            return ExecuteQuery($@"INSERT INTO {tableName}
({cols})
VALUES({values})");
        }
        /// <summary>
        /// 按指定操作更新数据
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="updatePair"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public SqliteDataReader UpdateInto<TKey>(string tableName, IDictionary<string, TKey> updatePair,
            Condition.Condition condition) {
            return UpdateInto(tableName, updatePair, condition.ToString());
        }
        public SqliteDataReader UpdateInto<TKey>(string tableName, IDictionary<string, TKey> updatePair,
            string condition) {
            StringBuilder query = new StringBuilder();
            query.AppendLine($@"UPDATE {tableName} SET");
            foreach (var keyVal in updatePair) {
                query.AppendLine($@"{keyVal.Key}={keyVal.Value}");
            }

            query.AppendLine($@"WHERE {condition}");
#if DEBUG
            string str = query.ToString();
            Console.WriteLine(query);
#endif
            return ExecuteQuery(query.ToString());
        }
        /// <summary>
        /// 按指定操作删除数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public SqliteDataReader Delete(string tableName, Condition.Condition condition) {
            return ExecuteQuery($@"DELETE FROM {tableName}
WHERE {condition}");
        }
        /// <summary>
        /// 清空表
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public SqliteDataReader DeleteContents(string tableName) {
            return ExecuteQuery($@"DELETE FROM {tableName}");
        }
        /// <summary>
        /// 按条件查找对应列数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="cols"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        public SqliteDataReader SelectWhere(string tableName, string cols, string operation) {
            return ExecuteQuery($@"SELECT {cols}
FROM {tableName}
WHERE {operation}");
        }
        /// <summary>
        /// 按条件查找对应列数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="cols"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public SqliteDataReader SelectWhere(string tableName, string cols, Condition.Condition condition) {
            return SelectWhere(tableName, cols, condition.ToString());
        }
        /// <summary>
        /// 查找对应列数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public SqliteDataReader Select(string tableName, string cols) {
            return ExecuteQuery($@"SELECT {cols}
FROM {tableName}");
        }

        public SqliteDataReader SelectTop(string tableName, string cols, int n, string orderCol) {
            return ExecuteQuery($@"SELECT {cols}
FROM {tableName}
ORDER BY {orderCol} DESC LIMIT {n}");
        }
    }
}