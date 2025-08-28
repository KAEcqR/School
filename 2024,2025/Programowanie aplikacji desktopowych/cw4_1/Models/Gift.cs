using Microsoft.Data.Sqlite;
using System.ComponentModel;

namespace cw4_1.Models
{
    public class Gift
    {
        public int Id { get; set; }

        [DisplayName("Co na prezent")]
        public string Name { get; set; }

        [DisplayName("Od kogo")]
        public string From_sb { get; set; }

        [DisplayName("Dla kogo")]
        public string For_sb { get; set; }

        [DisplayName("Cena")]
        public int Price { get; set; }

        [DisplayName("W co jest zapakowane")]
        public string Packaging { get; set; }
    }

}