Random rnd = new Random();
int toFind = rnd.Next(0,50);

Console.WriteLine(toFind);


Console.WriteLine("Podaj liczbe: ");
int number =  Convert.ToInt32(Console.ReadLine());

Check();

void Check() {

    if(number == toFind){
        Console.WriteLine("Gratulacje");
    }else{
        switch(number > toFind) 
        {
        case true:
            Console.WriteLine("numer jest mniejszy");

            Console.WriteLine("Podaj liczbe: ");
            number =  Convert.ToInt32(Console.ReadLine());
            Check();
            break;
        case false:
            Console.WriteLine("numer jest wiekszy");

            Console.WriteLine("Podaj liczbe: ");
            number =  Convert.ToInt32(Console.ReadLine());
            Check();
            break;
        }
    }

}

