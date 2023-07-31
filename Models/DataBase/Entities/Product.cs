using DapperSample.Windows.UI.Helpers.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperSample.Windows.UI.Models.DataBase.Entities
{
    public class Product : IEntity
    {
        [PrimaryKey]
        //[DbColumnName("product_id")]
        public int product_id { get; set; }
        
        //[DbColumnName("product_name")]
        public string product_name { get; set; }
        
        //[DbColumnName("brand_id")]
        public int brand_id { get; set; }

        //[DbColumnName("category_id")]
        public int category_id { get; set; }

        //[DbColumnName("model_year")]
        public short model_year { get; set; }

        //[DbColumnName("list_price")]
        public decimal list_price { get; set; }
    }
}
