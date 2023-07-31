using Dapper;
using Dapper.Contrib.Extensions;
using DapperSample.Windows.UI.Helpers;
using DapperSample.Windows.UI.Helpers.Attributes;
using DapperSample.Windows.UI.Models.DataBase;
using DapperSample.Windows.UI.Models.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        protected SqlConnection Connection { get; set; }
        protected readonly string TableName; // Holds the table name with schema prefix (e.g., "production.categories")

        public BaseRepository(string tableName)
        {
            TableName = tableName;
            Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

            // Add a custom type handler for column mapping
            //SqlMapper.RemoveTypeMap(typeof(T));
            //SqlMapper.AddTypeHandler(typeof(T), CreateCustomTypeHandler());
        }

        //private SqlMapper.ITypeHandler CreateCustomTypeHandler()
        //{
        //    var properties = typeof(T).GetProperties();
        //    var columnNameMapping = properties.ToDictionary(
        //        p => p.GetCustomAttribute<DbColumnNameAttribute>()?.ColumnName ?? p.Name,
        //        p => p
        //    );

        //    return new CustomTypeHandler(columnNameMapping);
        //}

        //private class CustomTypeHandler : SqlMapper.ITypeHandler
        //{
        //    private readonly IDictionary<string, PropertyInfo> columnNameMapping;

        //    public CustomTypeHandler(IDictionary<string, PropertyInfo> columnNameMapping)
        //    {
        //        this.columnNameMapping = columnNameMapping;
        //    }

        //    public void SetValue(IDbDataParameter parameter, object value)
        //    {
        //        parameter.Value = value;
        //    }

        //    public object Parse(Type destinationType, object value)
        //    {
        //        if (value is DBNull || value == null)
        //        {
        //            return null;
        //        }

        //        if (columnNameMapping.TryGetValue(destinationType.Name, out PropertyInfo property))
        //        {
        //            return Convert.ChangeType(value, property.PropertyType);
        //        }

        //        return value;
        //    }
        //}

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// This metod returns entity's PrimaryKey's Property info
        /// </summary>
        /// <returns></returns>
        protected PropertyInfo GetPrimaryKeyProperty()
        {
            return typeof(T).GetProperties().FirstOrDefault(p => p.GetCustomAttribute<PrimaryKeyAttribute>() != null);
        }

        protected string? GetPrimaryKeyColumnName()
        {
            var primaryKeyProperty = GetPrimaryKeyProperty();
            return primaryKeyProperty.Name;
            //return primaryKeyProperty?.GetCustomAttribute<DbColumnNameAttribute>()?.ColumnName;
        }

        protected string GenerateSelectSql()
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            string columns = string.Join(", ", properties.Select(p => Helper.GetColumnName(p)));
            return $"SELECT {columns} FROM {TableName} ";
        }

        public T GetById(int id)
        {
            string sql = GenerateSelectSql();
            sql += $" WHERE {GetPrimaryKeyColumnName()} = @Id ";

            using (IDbConnection dbConnection = Connection)
            {
                if (Connection.State == System.Data.ConnectionState.Closed)
                {
                    Connection.Open();
                }

                var _result = Connection.QueryFirstOrDefault<T>(sql, new { Id = id });
                return _result;
            }
        }
    }
}
