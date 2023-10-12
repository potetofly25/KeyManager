using Dapper;
using DapperExtensions;
using KeyManager.Models;
using KeyManager.Utils;

namespace KeyManager.Dao
{
    internal class KeyDao
    {
        public static IEnumerable<KeyItem> GetAll()
        {
            using var connection = DBUtils.CreateConnection();
            connection.Open();
            return connection.GetList<KeyItem>();
        }

        public static void Insert(KeyItem _item)
        {
            using var connection = DBUtils.CreateConnection();
            connection.Open();
            using (var tran = connection.BeginTransaction())
            {
                try
                {
                    string sql = "INSERT INTO KeyItem(Name, LoginId, MailAddress, LoginPassword, Url, Remarks, SortNumber) " +
                                 "values(@Name, @LoginId, @MailAddress, @LoginPassword, @Url, @Remarks, @SortNumber)";
                    connection.Execute(sql, _item, tran);
                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback();
                }
            }
        }

        public static void Update(KeyItem _item)
        {
            using var connection = DBUtils.CreateConnection();
            connection.Open();
            using (var tran = connection.BeginTransaction())
            {
                try
                {
                    string sql = "UPDATE KeyItem SET Name = @Name, LoginId = @LoginId, MailAddress = @MailAddress, LoginPassword = @LoginPassword, " +
                                 " Url = @Url, Remarks = @Remarks, SortNumber = @SortNumber WHERE Id = @Id ";
                    connection.Execute(sql, _item, tran);
                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback();
                }
            }
        }

        public static void Delete(KeyItem _item)
        {
            using var connection = DBUtils.CreateConnection();
            connection.Open();
            using (var tran = connection.BeginTransaction())
            {
                try
                {
                    string sql = "DELETE FROM KeyItem WHERE Id = @Id";
                    var id = new
                    {
                        ID = _item.Id,
                    };
                    connection.Execute(sql, id, tran);
                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback();
                }
            }
        }

        public static int GetMaxID()
        {
            using var connection = DBUtils.CreateConnection();
            using var command = connection.CreateCommand();
            connection.Open();
            command.CommandText = "SELECT MAX(Id) FROM KeyItem";
            if (DBUtils.IsDBNull(command.ExecuteScalar()))
            {
                return 0;
            }
            return Convert.ToInt32(command.ExecuteScalar());
        }

    }
}
