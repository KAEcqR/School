using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw8_listBox.Models
{
    public class FileRepoCSV :IRepository
    {
        public List<Product>? Products { get; set; }

        public FileRepoCSV(string filename="products.csv") {
            Products = ProductsFromFile(filename);
        }

        private List<Product>? ProductsFromFile(string filename) {
            //todo
            List<string> lines = new List<string>();
            if (File.Exists(filename)) {
                lines = File.ReadAllLines(filename).ToList();
            }
            return null;
        }

        public List<Product> GetProducts() {
            return Products?? new List<Product>();
        }

        public Product? GetProductById(int id) {
            throw new NotImplementedException();
        }

        public void AddProduct(Product? product) {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id) {
            throw new NotImplementedException();
        }

        private int getMaxId() {
            return 0;//fake
        }
    }
}
