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
        [DbColumnName("product_id")]
        public int ProductId { get; set; }
        
        [DbColumnName("product_name")]
        public string ProductName { get; set; }
        
        [DbColumnName("brand_id")]
        public int BrandId { get; set; }

        [DbColumnName("category_id")]
        public int CategoryId { get; set; }

        [DbColumnName("model_year")]
        public int ModelYear { get; set; }

        [DbColumnName("list_price")]
        public decimal ListPrice { get; set; }
    }
}
