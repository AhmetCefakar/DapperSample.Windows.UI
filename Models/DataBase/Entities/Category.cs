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
        [DbColumnName("category_id")]
        public int CategoryId { get; set; }

        [DbColumnName("category_name")]
        public string CategoryName { get; set; }
    }
}
