using Dapper;
using DapperSample.Windows.UI.Helpers.Attributes;
using DapperSample.Windows.UI.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DapperSample.Windows.UI.Repositories.Base
{
    public class BaseRepositoryWithOnlySimpleReadings<T> : BaseRepository<T>, IDisposable, IReadRepositoryForOne<T>
        where T : IEntity
    {
        public BaseRepositoryWithOnlySimpleReadings(string tableName) : base(tableName)
        {
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            base.Dispose();
        }

        public List<T> GetAll()
        {
            string sql = GenerateSelectSql();

            using (IDbConnection dbConnection = Connection)
            {
                if (Connection.State == System.Data.ConnectionState.Closed)
                {
                    Connection.Open();
                }

                return Connection.Query<T>(sql).ToList();
            }
        }
    }
}
