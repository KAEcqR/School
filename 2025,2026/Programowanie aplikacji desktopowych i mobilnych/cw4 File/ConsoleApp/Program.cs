using ClassLibrary;

FileOperations plik = new FileOperations("tekst.txt");

string text = "Test";

Console.WriteLine(plik.SearchString(text));