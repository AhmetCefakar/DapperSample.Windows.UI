using DapperSample.Windows.UI.Models.DataBase;
using DapperSample.Windows.UI.Models.DataBase.Entities;
using DapperSample.Windows.UI.Models.StoreProcedure;
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

        private void ButtonProductUpdate_Click(object sender, EventArgs e)
        {
            using (ProductRepository _productRepository = new())
            {
                UpdateProductSP _updateProductSP = new()
                {
                    product_id = ProductId,
                    product_name = TextBoxProductName.Text,
                    brand_id = (int)ComboBoxBrand.SelectedValue,
                    category_id = (int)ComboBoxCatalog.SelectedValue,
                    model_year = int.Parse(TextBoxModleYear.Text),
                    list_price = decimal.Parse(TextBoxPrice.Text)
                };

                int _returnValue = _productRepository.Update(_updateProductSP);

                if (_returnValue == 0)
                {
                    MessageBox.Show("Current Product Updated", "Update Info");
                }
                else
                {
                    MessageBox.Show("Current Product haven't Updated", "Update Info");
                }
            }
        }

        private void ButtonProductDelete_Click(object sender, EventArgs e)
        {
            using (ProductRepository _productRepository = new())
            {
                int _returnValue = _productRepository.Delete(new DeleteProductSP { product_id = ProductId });

                if (_returnValue == 0)
                {
                    MessageBox.Show("Current Product Deleted", "Delete Info");
                }
                else
                {
                    MessageBox.Show("Current Product haven't Deleted", "Delete Info");
                }
            }
        }
    }
}
