using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw11.Models
{
    public interface IRepository
    {
        List<Product> GetProduct();
        Product? GetProductById(int id);
        void AddProduct(Product? product);
        void DelProduct(int id);
    }
}
