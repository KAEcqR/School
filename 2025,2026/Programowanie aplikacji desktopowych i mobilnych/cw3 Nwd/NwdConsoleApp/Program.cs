using NwdClassLib;

try
{
    NwdCalculator nwd = new();
    Console.Write("Podaj a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Podaj b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int resultRec = nwd.CalculateNwd(a, b);
    int resultIter = nwd.CalculateNwdIteratively(a, b);

    Console.WriteLine("Rekurencja: " + resultRec);
    Console.WriteLine("Iteracja: " + resultIter);
} catch (FormatException ex)
{
    Console.WriteLine("Bledne dane! " + ex.Message);
}