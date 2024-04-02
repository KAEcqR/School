using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swieta2024.Models
{
    public class Danie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Ingredients { get; set; }

        public override string ToString()
        {
            return $"Nazwa: {Name}, Opis: {Description}, Składniki: {Ingredients}";
        }
    }
}
