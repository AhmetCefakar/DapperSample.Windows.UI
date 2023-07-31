using DapperSample.Windows.UI.Helpers.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperSample.Windows.UI.Models.DataBase.Entities
{
    public class Brand : IEntity
    {
        [PrimaryKey]
        //[DbColumnName("brand_id")]
        public int brand_id { get; set; }

        //[DbColumnName("brand_name")]
        public string brand_name { get; set; }
    }
}
