using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw11.Models
{
    public class FakeRepo : IRepository
    {
        public void AddProduct(Product? product)
        {
            throw new NotImplementedException();
        }

        public void DelProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProduct()
        {
            return new List<Product> { 
                new Product { Id = 1, Name = "marchewka", Category = "warzywa", Description = "jest dobra", Price = 261 },
                new Product { Id = 2, Name = "cebula", Category = "warzywa", Description = "jest dobra", Price = 212 },
                new Product { Id = 3, Name = "banan", Category = "owoce", Description = "jest dobra", Price = 231 },
            };
        }

        public Product? GetProductById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
