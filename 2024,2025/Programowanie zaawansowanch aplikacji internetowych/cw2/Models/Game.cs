using System;

namespace cw2.Models;

public class Game
{
    public int Id { get; set; }
    public string? Nazwa { get; set; }
    public int Rok { get; set; }
    public string? Producent { get; set; }
    public decimal Cena { get; set; }
}