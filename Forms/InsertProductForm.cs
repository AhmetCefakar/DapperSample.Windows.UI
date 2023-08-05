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
    public partial class InsertProductForm : Form
    {
        public InsertProductForm()
        {
            InitializeComponent();
        }

        private void InsertProductForm_Load(object sender, EventArgs e)
        {
            GetBrands();
            GetCategories();
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

        private void ButtonProductInsert_Click(object sender, EventArgs e)
        {
            using (ProductRepository _productRepository = new())
            {
                InsertProductSP _updateProductSP = new()
                {
                    product_name = TextBoxProductName.Text,
                    brand_id = (int)ComboBoxBrand.SelectedValue,
                    category_id = (int)ComboBoxCatalog.SelectedValue,
                    model_year = int.Parse(TextBoxModleYear.Text),
                    list_price = decimal.Parse(TextBoxPrice.Text)
                };

                int _returnValue = _productRepository.Insert(_updateProductSP);

                if (_returnValue == 0)
                {
                    MessageBox.Show("Current Product Inserted", "Insert Info");
                }
                else
                {
                    MessageBox.Show("Current Product haven't Inserted", "Insert Info");
                }
            }
        }
    }
}
