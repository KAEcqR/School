using cw11.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw11
{
    public partial class Form2 : Form
    {

        private Form1 _form;

        public Form2(Form1 form)
        {
            _form = form;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var products = _form.Products;
            var lastId = products.Max(p => p.Id);
            var product = new Product
            {
                Id = lastId + 1,
                Name = tbName.Text.Trim(),
                Description = tbDescription.Text.Trim(),
                Category = cbCategory.Text.Trim(),
                Price = Convert.ToDecimal(nmPrice.Text)
            };

            products.Add(product);
            Close(); 
        }
    }
}
