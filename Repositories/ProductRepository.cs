﻿using Dapper;
using DapperSample.Windows.UI.Models.DataBase.Entities;
using DapperSample.Windows.UI.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperSample.Windows.UI.Repositories
{
    internal class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository() : base("production.products")
        {
        }

        /// <summary>
        /// This method return custom list for product model without paging
        /// </summary>
        /// <returns></returns>
        List<ProductListViewModel> GetAll()
        {
            List<ProductListViewModel> productListViewModels = new List<ProductListViewModel>();

            string _query = @"
                Select
		            p.product_id,
		            p.product_name,
		            b.brand_name,
		            c.category_name,
		            p.model_year,
		            p.list_price
	            From production.products as p
		            Inner Join production.brands as b on b.brand_id = p.brand_id
		            Inner join production.categories as c on c.category_id = p.category_id
            ";
            productListViewModels = Connection.Query<ProductListViewModel>(_query).ToList();

            return productListViewModels;
        }
    }
}
