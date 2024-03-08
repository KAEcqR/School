using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw11
{
    public class FileRepoCSV : IRepository
    {
        public List<Product>? Products { get; set; }

        public FileRepoCSV(string filename = "products.csv")
        {
            Products = ProductFromFile(filename);
        }

        private List<Product>? ProductFromFile(string filename)
        {
            //todo
            List<string> lines = new List<string>();
            if (File.Exists(filename))
            {
                lines = File.ReadAllLines(filename).ToList();
            }
            return null;
        }

        public int GetMaxId()
        {
            return 0;
        }

        public List<Product> GetProduct()
        {
            return Products ?? new List<Product>();
        }

        public Product? GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(Product? product)
        {
            throw new NotImplementedException();
        }

        public void DelProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
