using DapperSample.Windows.UI.Helpers.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperSample.Windows.UI.Models.DataBase.Entities
{
    public class Stock : IEntity
    {
        [DbColumnName("store_id")]
        public int StoreId { get; set; }
        [DbColumnName("product_id")]
        public int ProductId { get; set; }
        [DbColumnName("quantity")]
        public int Quantity { get; set; }
    }
}
