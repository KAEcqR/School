using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw11.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Nazwa: {Name}, Opis: {Description}, Kategoria: {Category}, Cena: {Price}";
        }

    }

}
