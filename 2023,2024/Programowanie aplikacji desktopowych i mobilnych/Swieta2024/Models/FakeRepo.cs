using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swieta2024.Models
{
    public class FakeRepo : IRepository
    {
        public List<Danie> GetDanie()
        {
            return new List<Product> {
                new Danie { Id = 1 , Description = "Opis", Name = "Barszcz", Ingredients = "Burak"};
            }
        }

        public Danie? GetDanieById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
