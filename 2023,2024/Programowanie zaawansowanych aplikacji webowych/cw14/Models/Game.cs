using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw14;

public class Game
{   
    [DisplayName("Tytuł gry")]
    [Required(ErrorMessage = "Podaj tytuł gry")]
    public string? Title{get;set;} 

    [DisplayName("Typ gry")]
    [Required(ErrorMessage = "Podaj typ gry")]
    public string? Genre{get;set;} 

    [DisplayName("Cena gry")]
    [Required(ErrorMessage = "Podaj cene gry")]
    public decimal? Price{get;set;} 

    [DataType(DataType.Date)]
    [DisplayName("Data gry")]
    [Required(ErrorMessage = "Podaj date gry")]
    public DateOnly? DateOf{get;set;}  
}
