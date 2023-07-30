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
        [DbColumnName("brand_id")]
        public int BrandId { get; set; }

        [DbColumnName("brand_name")]
        public string BrandName { get; set; }
    }
}
