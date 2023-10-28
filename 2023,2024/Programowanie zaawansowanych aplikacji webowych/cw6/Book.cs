class Book {
    private string title; 
    private string author;
    private int price;

    public Book (string title, string author, int price){
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public int Price{
        get
        {
            return price;
        }
        set
        {
            price = Math.Abs(value);
        }
    }


        public string Author{
        get
        {
            return author;
        }
        set
        {
            author = value;
        }
    }

        public string Title{
        get
        {
            return title;
        }
        set
        {
            title = value;
        }
    }

    public string Show(){
        return $"tytul: {Title}, autor: {Author}, cena: {Price}";
    }
    
}