using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cw8_listBox.Models;

namespace cw8_listBox
{
    public partial class AddProductForm : Form
    {
        private Form1 _form;
        public AddProductForm(Form1 form)
        {
            _form = form;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var products = _form.Products;
            var lastId = products.Max(p => p.Id);
            //BRAK WALIDACJI
            var product = new Product {
                Id = lastId + 1,
                Name = tbName.Text.Trim(),
                Description = tbDescription.Text.Trim(),
                Category = cbCategory.SelectedItem?.ToString(),
                Price = Convert.ToDecimal(tbPrice.Text)
            };
            products.Add(product);
            Close();
        }
    }
}
