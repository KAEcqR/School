using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw2_Student.Models;

public class Student
{
    public int Id { get; set; }

    [DisplayName("Imie")]
    [Required(ErrorMessage = "Nieprawidlowe imie")]
    public string? Name { get; set; }

    [DisplayName("Data urodzenia")]
    [Required(ErrorMessage = "Nieprawidlowa data")]
    public DateOnly? DataUrodzenia { get; set; }

    public string? Index { get; set; }

}
