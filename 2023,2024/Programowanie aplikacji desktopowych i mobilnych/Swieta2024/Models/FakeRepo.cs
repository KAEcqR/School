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
            return new List<Danie> {
                new Danie { Id = 1 , Description = "Opis", Name = "Barszcz", Ingredients = "Burak"},
                new Danie { Id = 2 , Description = "Opis2", Name = "Żurek", Ingredients = "Kiełbaska, jajko"}
            };
        }

        public Danie? GetDanieById(int id)
        {
            throw new NotImplementedException();
        }
    }

}
