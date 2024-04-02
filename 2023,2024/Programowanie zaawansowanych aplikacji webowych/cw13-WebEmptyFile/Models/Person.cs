using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebEmptyFile.Models
{
    public class Person
    {
        public Person() {
            Id = Guid.NewGuid().ToString();
        }
        
        
        public string Id { get; set; }

        [DisplayName("Podaj imię")]
        [Required(ErrorMessage = "Podaj imię")]
        public string? Firstname { get; set; }

        [DisplayName("Podaj nazwisko")]
        [Required(ErrorMessage = "Podaj nazwisko")]
        public string? Lastname { get; set; }

        [DisplayName("Podaj co przyniesiesz")]
        [Required(ErrorMessage = "Podaj co przyniesiesz")]
        public string? Content { get; set; }

        [DisplayName("Wybierz datę")]
        [Required(ErrorMessage = "Wybierz datę")]
        public DateOnly? PartyDate { get; set; }

        public override string ToString() {
            return $"{Id}|{Firstname}|{Lastname}|{Content}|{PartyDate?.ToShortDateString()}";
        }
    }
}
