#include <iostream>

using namespace std;

class Osoba {
public: 
    string imie, nazwisko;
    Osoba() {
        cout << "Konstruktor osoba" << endl;
    }

    string Info() {
        return imie + " " + nazwisko;
    }
};

class Przedmiot {
public: 
    string przedmiot;
    Przedmiot() {
        cout << "Konstruktor przedmiot" << endl;
    }
    
    string Info() {
        return przedmiot;
    }
};

class Klasa {
public:
    string klasa;
    Klasa() {
        cout << "Konstruktor klasa" << endl;
    }

    string Info() {
        return klasa;
    }
};

class Pracownik : public Osoba {
public: 
    string id;
    Pracownik() {
        cout << "Konstruktor pracownik" << endl;
    }

    string Info() {
        return Osoba::Info() + " " + id;
    }
};

class Nauczyciel : public Pracownik, public Przedmiot {
public :
    Nauczyciel() {
        cout << "Konstruktor nauczyciel" << endl;
    }

    string Info() {
        return Osoba::Info() + " " + przedmiot;
    }
};

class Wychowawca : public Nauczyciel {
public : 
    Wychowawca() {
        cout << "Konstruktor wychowawca" << endl;
    }

    string Info() {
        return Nauczyciel::Info();
    }
};

class Uczen : public Osoba, public Klasa {
public: 
    Uczen() {
        cout << "Konstruktor uczen" << endl;
    }

    string Info() {
        return Osoba::Info() + " " + klasa;
    }
};

int main()
{
    Nauczyciel nauczyciel;
    nauczyciel.imie = "Jan";
    nauczyciel.nazwisko = "Kowalski";
    nauczyciel.id = "123";
    nauczyciel.przedmiot = "Fizyka"; 

    cout << nauczyciel.Info() << endl;

    Uczen uczen;
    uczen.imie = "Jan";
    uczen.nazwisko = "Pilny";
    uczen.klasa = "5TIP";
    cout << uczen.Info();
}
