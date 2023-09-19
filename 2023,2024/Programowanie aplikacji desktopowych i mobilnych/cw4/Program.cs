Console.WriteLine("Podaj rozmiar tablicy");
try{
    int size = Int32.Parse(Console.ReadLine());
    int[] numbers = new int[size];
    Fillarray(numbers);
    ShowArray(numbers);
}catch(FormatException ex){
    Console.WriteLine("Error");
    Console.WriteLine(ex.Message);
}

void Fillarray(int[] nums){
    Random rnd = new Random();
    for(int i=0; i<nums.Length; i++){
        nums[i] = rnd.Next(0,100);
    }
}

void ShowArray(int[] nums){
    foreach(int elem in nums){
        Console.WriteLine($"element tablicy : {elem} ");
    }    
}