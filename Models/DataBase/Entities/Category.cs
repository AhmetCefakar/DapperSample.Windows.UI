using DapperSample.Windows.UI.Helpers.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperSample.Windows.UI.Models.DataBase.Entities
{
    public class Category : IEntity
    {
        [PrimaryKey]
        //[DbColumnName("category_id")]
        public int category_id { get; set; }
        
        //[DbColumnName("category_name")]
        public string category_name { get; set; }
    }
}
