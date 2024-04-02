using cw11.Models;

namespace cw11
{
    public partial class Form1 : Form
    {

        private IRepository _repository;
        public List<Product> Products { get; set; }

        public Form1()
        {
            InitializeComponent();
            _repository = new FakeRepo();
            Products = _repository.GetProduct();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lbProducts.DataSource = Products;
        }

        private void lbProducts_DataSourceChanged(object sender, EventArgs e)
        {
            lbCount.Text = _repository.GetProduct().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Products.Add(new Product { Id = 6, Name = "ssss", Price = 23.89m });
            //lbProducts.DataSource = null;
            //lbProducts.DataSource = Products;
            new Form2(this).ShowDialog();
            lbProducts.DataSource = null;
            lbProducts.DataSource = Products;
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
