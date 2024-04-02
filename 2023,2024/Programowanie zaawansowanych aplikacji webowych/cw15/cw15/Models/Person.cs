using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace cw15.Models
{
    public class Person
    {
        public Person() {
            Id = Guid.NewGuid().ToString();
        }
        public string? Id { get; set; }

        [DisplayName("Podaj imie")]
        [Required(ErrorMessage = "Podaj imie")]
        public string? Firstname { get; set; }

        [DisplayName("Podaj nazwisko")]
        [Required(ErrorMessage = "Podaj nazwisko")]
        public string? Lastname { get; set; }

        [DisplayName("Podaj kontent")]
        [Required(ErrorMessage = "Podaj kontent")]
        public string? Content { get; set; }

        [DisplayName("Podaj date")]
        [Required(ErrorMessage = "Podaj date")]
        public DateOnly? PartyDate { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Firstname} | {Lastname} | {Content} | {PartyDate?.ToShortDateString()}";
        }
    }
}
