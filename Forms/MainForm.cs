using DapperSample.Windows.UI.Repositories;

namespace DapperSample.Windows.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetAllProducts();
        }

        private void GetAllProducts()
        {
            using (ProductRepository productRepository = new())
            {
                DataGridProductDataSource.DataSource = productRepository.GetAll();
            }
        }

        private void ButtonProductInsert_Click(object sender, EventArgs e)
        {

        }

        private void DataGridProductDataSource_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int productId = (int)DataGridProductDataSource.SelectedRows[0].Cells[0].Value; // This grid's first column is int value
            Forms.UpdateProductForm _updateProductForm = new Forms.UpdateProductForm(productId);
            _updateProductForm.ShowDialog(this);
        }
    }
}