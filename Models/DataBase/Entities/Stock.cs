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
        [PrimaryKey]
        //[DbColumnName("store_id")]
        public int store_id { get; set; }
        //[DbColumnName("product_id")]
        public int product_id { get; set; }
        //[DbColumnName("quantity")]
        public int quantity { get; set; }
    }
}
