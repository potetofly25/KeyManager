using System.Data.SQLite;

namespace KeyManager.Utils
{
    internal static class DBUtils
    {
        public static SQLiteConnection CreateConnection()
        {
            string dir = System.AppDomain.CurrentDomain.BaseDirectory;
            string path = System.IO.Path.Combine(dir, "Assets", "KeyDB.db");
            var config = new SQLiteConnectionStringBuilder()
            {
                DataSource = path
            };
            return new SQLiteConnection(config.ToString());
        }

        public static bool IsDBNull(object value)
        {
            if (value == System.DBNull.Value) return true;
            IConvertible? convertible = value as IConvertible;
            return convertible != null ? convertible.GetTypeCode() == TypeCode.DBNull : false;
        }
    }
}
