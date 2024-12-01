using System;

namespace cw4.Models;

public class Wycieczka
{
    public string? DataWyjazdu { get; set; }

    public string? Cel { get; set; }
}

public class Zdjecie
{
    public string? Plik { get; set; }

    public string? Podpis { get; set; }
}
