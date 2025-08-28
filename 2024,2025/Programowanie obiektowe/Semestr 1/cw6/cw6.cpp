#include <iostream>

using namespace std;

class Pracownik {
    string imie, nazwisko;
public :
    string Info() {
        return imie + " " + nazwisko;
    }

    void setImie(string nimie) {
        imie = nimie;
    }

    void setNazwisko(string nnazwisko) {
        nazwisko = nnazwisko;
    }
};

class Nauczyciel : public Pracownik {
    string przedmiot;
public :
    string Info() {
        return Pracownik::Info() + " " + przedmiot;
    }

    void setPrzedmiot(string nprzedmiot) {
        przedmiot = nprzedmiot;
    }
};

int main()
{
    Nauczyciel nauczyciel;
    nauczyciel.setImie("Jan");
    nauczyciel.setNazwisko("Kowalski");
    nauczyciel.setPrzedmiot("matematyka");
    cout << nauczyciel.Info();
}
