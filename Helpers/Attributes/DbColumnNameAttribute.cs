using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperSample.Windows.UI.Helpers.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class DbColumnNameAttribute : Attribute
    {
        public string ColumnName { get; }

        public DbColumnNameAttribute(string columnName)
        {
            ColumnName = columnName;
        }
    }
}
