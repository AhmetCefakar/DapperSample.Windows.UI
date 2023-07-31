using DapperSample.Windows.UI.Models.DataBase.Entities;
using DapperSample.Windows.UI.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperSample.Windows.UI.Forms
{
    public partial class UpdateProductForm : Form
    {
        int ProductId;

        public UpdateProductForm(int productId)
        {
            InitializeComponent();
            ProductId = productId;
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            GetBrands();
            GetCategories();
            GetProductById();
        }

        void GetBrands()
        {
            using (BrandRepository _brandRepository = new())
            {
                ComboBoxBrand.DisplayMember = "brand_name";
                ComboBoxBrand.ValueMember = "brand_id";
                ComboBoxBrand.DataSource = _brandRepository.GetAll();
            }
        }

        void GetCategories()
        {
            using (CategoryRepository _categoryRepository = new())
            {
                ComboBoxCatalog.DisplayMember = "category_name";
                ComboBoxCatalog.ValueMember = "category_id";
                ComboBoxCatalog.DataSource = _categoryRepository.GetAll();
            }
        }
        
        void GetProductById()
        {
            using (ProductRepository _productRepository = new())
            {
                var _currentItem = _productRepository.GetById(ProductId);

                TextBoxProductName.Text = _currentItem.product_name;
                TextBoxModleYear.Text = _currentItem.model_year.ToString();
                TextBoxPrice.Text = _currentItem.list_price.ToString();
                ComboBoxBrand.SelectedValue = _currentItem.brand_id;
                ComboBoxCatalog.SelectedValue = _currentItem.category_id;
            }
        }
    }
}
