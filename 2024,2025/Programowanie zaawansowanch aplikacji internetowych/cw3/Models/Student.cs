using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw3.Models;

public class Student
{
    public int Id { get; set; }

    [DisplayName("Imie")]
    [Required(ErrorMessage = "Pole imie jest wymagane ")]
    [MaxLength(50, ErrorMessage = "Maksymalna dlugosc to 50 znakow")]
    public string? Firstname { get; set; }

    [DisplayName("Nazwisko")]
    [Required(ErrorMessage = "Pole nazwisko jest wymagane ")]
    [MaxLength(50, ErrorMessage = "Maksymalna dlugosc to 50 znakow")]
    public string? Lastname { get; set; }

    [DisplayName("GrupaName")]
    public string? GroupName { get; set; }

    [DisplayName("Grupa")]
    public int GroupId { get; set; }

}
