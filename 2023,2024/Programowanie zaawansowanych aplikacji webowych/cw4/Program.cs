void ex1(){
    List<int> numbers = new List<int>();
    numbers.Add(32);
    numbers.Add(42);
    numbers.Add(-4);
    numbers.Add(23);
    show(numbers);
    insertToList(numbers);
    show(numbers);
}
ex1();

void show(List<int> elements){
    foreach(int elem in elements){
        Console.WriteLine(elem);
    }
}

void insertToList(List<int> list, int finisher = 10){
    Console.WriteLine($"Podaj liczbe, {finisher} konczy");
    int odpowiedz = int.Parse(Console.ReadLine());
    do
    {
        list.Add(odpowiedz);
        Console.WriteLine($"Podaj liczbe {finisher} konczy");
        int odpowiedz2 = int.Parse(Console.ReadLine());
        odpowiedz = odpowiedz2;
    } while (odpowiedz != finisher);
}

