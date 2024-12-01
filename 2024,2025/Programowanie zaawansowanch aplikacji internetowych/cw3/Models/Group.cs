using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace cw3.Models;

public class Group
{
    public int Id { get; set; }

    [DisplayName("Name")]
    [Required(ErrorMessage = "Pole imie jest wymagane ")]
    [MaxLength(50, ErrorMessage = "Maksymalna dlugosc to 50 znakow")]
    public string? Name { get; set; }

    [DisplayName("Opis")]
    [Required(ErrorMessage = "Pole opis jest wymagane ")]
    [MaxLength(50, ErrorMessage = "Maksymalna dlugosc to 50 znakow")]
    public string? Description { get; set; }

    [DisplayName("Wychowawca")]
    [Required(ErrorMessage = "Pole wychowawca jest wymagane ")]
    [MaxLength(50, ErrorMessage = "Maksymalna dlugosc to 50 znakow")]
    public string? Teacher { get; set; }

}
