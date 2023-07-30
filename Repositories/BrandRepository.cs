using DapperSample.Windows.UI.Models.DataBase;
using DapperSample.Windows.UI.Models.DataBase.Entities;
using DapperSample.Windows.UI.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperSample.Windows.UI.Repositories
{
    internal class BrandRepository : BaseRepositoryWithOnlySimpleReadings<Brand>
    {
        public BrandRepository() : base("production.brands")
        {
        }


    }
}
