using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw14;

public class Film
{   
    [DisplayName("Tytuł Filmu")]
    [Required(ErrorMessage = "Podaj tytuł filmu")]
    public string? Title{get;set;} 

    [DisplayName("Typ filmu")]
    [Required(ErrorMessage = "Podaj typ filmu")]
    public string? Genre{get;set;} 

    [DisplayName("Cena filmu")]
    [Required(ErrorMessage = "Podaj cene filmu")]
    public decimal? Price{get;set;} 

    [DataType(DataType.Date)]
    [DisplayName("Data filmu")]
    [Required(ErrorMessage = "Podaj date filmu")]
    public DateOnly? DateOf{get;set;}  
}
