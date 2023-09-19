try
{
    Console.WriteLine("podaj liczbe 1: ");
    string liczba1 = Console.ReadLine();


    Console.WriteLine("podaj liczbe 2: ");
    string liczba2 = Console.ReadLine();

    float a = float.Parse(liczba1);
    float b = float.Parse(liczba2);

    if (b == 0)
    {
        Console.WriteLine("NIE DZIELIMY PRZEZ 0");
    }
    else
    {
        Console.WriteLine($"{a}  +  {b}  = {a + b} ");
        Console.WriteLine($"{a}  -  {b}  = {a - b} ");
        Console.WriteLine($"{a}  *  {b}  = {a * b} ");
        Console.WriteLine($"{a}  /  {b}  = {a / b} ");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


