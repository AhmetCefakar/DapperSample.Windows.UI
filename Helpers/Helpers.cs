using DapperSample.Windows.UI.Helpers.Attributes;
using DapperSample.Windows.UI.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DapperSample.Windows.UI.Helpers
{
    public static class Helper
    {
        /// <summary>
        /// Helper method to get the mapped database column name
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <returns></returns>
        public static string GetColumnName(PropertyInfo propertyInfo)
        {
            var attribute = propertyInfo.GetCustomAttribute<DbColumnNameAttribute>();

            if (attribute != null)
                return attribute.ColumnName;
            else
                return propertyInfo.Name; // Fallback to the property name if no attribute is specified
        }

    }
}
