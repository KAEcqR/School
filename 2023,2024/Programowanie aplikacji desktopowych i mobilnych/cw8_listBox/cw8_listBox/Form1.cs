using cw8_listBox.Models;
using System.Diagnostics;
using System.Windows.Forms;

namespace cw8_listBox
{
    public partial class Form1 : Form
    {
        private IRepository _repository;
        public List<Product> Products { get; set; }
        public Form1()
        {
            InitializeComponent();
            _repository = new FakeRepo();

            Products = _repository.GetProducts();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lbProducts.DataSource = Products;
        }

        private void lbProducts_DataSourceChanged(object sender, EventArgs e)
        {
            lbCoumt.Text = Products.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //otwarcie okienka z formularzem nowego produktu
            //zapisanie danych z formularza do Products
            //Products.Add(new Product{Id = 6,Name = "ssss",Price = 23.89m});
            new AddProductForm(this).ShowDialog();
            //lbProducts.DataSource = null;
            //lbProducts.DataSource = Products;
            //Zapis do pliku ale po zmianie repozytorium
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var products = Products;
            if (lbProducts.SelectedItems != null)
            {
                int productToRemove = lbProducts.SelectedIndex;
                products.RemoveAt(productToRemove);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
