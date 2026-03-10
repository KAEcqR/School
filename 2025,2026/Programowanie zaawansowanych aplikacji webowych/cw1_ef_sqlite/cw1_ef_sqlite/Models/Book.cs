using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw1_ef_sqlite.Models
{
    public class Book
    {
        public int Id { get; set; }

        [DisplayName("Tytuł")]
        [Required(ErrorMessage = "Podaj tytuł")]
        public string Title { get; set; }

        [DisplayName("Autor")]
        [Required(ErrorMessage = "Podaj autora")]
        public string Author { get; set; }

        [DisplayName("Rok wydania")]
        [Required(ErrorMessage = "Podaj rok")]
        public int? Year { get; set; }
    }
}
