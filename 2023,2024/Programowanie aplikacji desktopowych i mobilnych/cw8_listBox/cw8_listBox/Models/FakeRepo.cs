using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw8_listBox.Models
{
    public class FakeRepo : IRepository
    {
        public List<Product> GetProducts() {
            return new List<Product> {
                new Product {
                    Id = 1, Name = "marchewka",
                    Category = "warzywa", Price = 3.88m, Description = "ala ma kota"
                },
                new Product {
                    Id = 2, Name = "truskawki",
                    Category = "owoce", Price = 23.88m, Description = "ala ma kota"
                },
                new Product {
                    Id = 3, Name = "cebula",
                    Category = "warzywa", Price = 5.88m, Description = "ala ma kota"
                },
                new Product {
                    Id = 4, Name = "jabłka",
                    Category = "owoce", Price = 8.88m, Description = "ala ma kota"
                },
            };
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
    }
}
