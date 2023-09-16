using System.Globalization;

Console.WriteLine("Podaj tekst");
string tekst = Console.ReadLine();

Console.WriteLine("Ile razy");
int numer = int.Parse(Console.ReadLine());


if(numer < 100){
    Console.WriteLine("for");
    for(int i = 0; i < numer; i++){
        Console.WriteLine(tekst);
    };

    int x = 0;

    Console.WriteLine("while");
    while(numer > x){
        Console.WriteLine(tekst);
        x++;
    };

    x = 0;

    Console.WriteLine("do while");
    do{
        Console.WriteLine(tekst);
        x++;
    }while(numer > x);
}else{
    Console.WriteLine("Liczba nie może przekraczać 100");
}
