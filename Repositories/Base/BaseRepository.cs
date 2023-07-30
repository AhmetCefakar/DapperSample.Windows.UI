using Dapper;
using DapperSample.Windows.UI.Helpers.Attributes;
using DapperSample.Windows.UI.Models.DataBase;
using DapperSample.Windows.UI.Models.DataBase.Entities;
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
    public class BaseRepository<T> : IDisposable
        where T : IEntity
    {
        public SqlConnection Connection { get; set; }
        public readonly string TableName; // Holds the table name with schema prefix (e.g., "production.categories")

        public BaseRepository(string tableName)
        {
            TableName = tableName;
            Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public string GenerateSelectSql()
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            string columns = string.Join(", ", properties.Select(p => GetColumnName(p)));
            return $"SELECT {columns} FROM {TableName};";

            //return $"SELECT * FROM {TableName};";
        }

        /// <summary>
        /// Helper method to get the mapped database column name
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <returns></returns>
        public string GetColumnName(PropertyInfo propertyInfo)
        {
            var attribute = propertyInfo.GetCustomAttribute<DbColumnNameAttribute>();

            if (attribute != null)
                return attribute.ColumnName;
            else
                return propertyInfo.Name; // Fallback to the property name if no attribute is specified
        }
    }
}
