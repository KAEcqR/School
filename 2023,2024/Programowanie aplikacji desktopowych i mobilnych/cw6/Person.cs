namespace cw6;

public class Person
{
    private string firstname;
    private string lastname;
    private DateTime birthDay;
    public Person(string firstname,string lastname,DateTime birthDay)
    {
        Firstname = firstname;
        Lastname = lastname;
        BirthDay = birthDay;

    }
    public Person(){
        this.firstname = "Adam";
        this.lastname = "Kowalski";
        this.birthDay = new DateTime(2000,1,1);
    }
    public void Show(){
        Console.WriteLine($"Imie: {firstname} Nazwisko: {lastname} Data urodzenia: {birthDay.ToShortDateString()}");
    }

    public void Age(){
        var today = DateTime.Now;
        var diffOfDates = today - birthDay;
        var years = diffOfDates.Days / 365; 
        Console.WriteLine($"{firstname} ma :" + years + " lat");
    }
    
    public string Firstname{
        get{
            return firstname;
        }
        set{
            firstname = value.ToUpper();
        }
    }
    public string Lastname{
        get{
            return firstname;
        }
        set{
            lastname = value.ToUpper();
        }
    }
    public DateTime BirthDay{
        get{
            return birthDay;
        }
        set{
           
        }
    }
}

