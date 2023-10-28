//Zdefiniowac klase Book z polami prywatnymi title author price
//w pliku Book.cs
//dorobic property get set tak aby cena byla dodatnia

//Stworzyc liste ksiazek
//List<Book> books = new List<Book>();
// books.Add(new Book(.....))
//dodac kilka ksiazek i wyswietlic wszystki foreach-em

internal class Program
{
    private static void Main(string[] args)
    {
        List<Book> books = new List<Book>();
        books.Add(new Book("Wiedzmin","Sapkowski",20));
        books.Add(new Book("Hobbit","Tolkien",25));

        foreach(Book book in books){
            Console.WriteLine(book.Show());
        }

    }
}
