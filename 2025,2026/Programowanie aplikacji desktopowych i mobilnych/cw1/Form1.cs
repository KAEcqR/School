using System.ComponentModel;

namespace cw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Osoba_wycieczka.DataSource = wycieczki;
            Osoba_wycieczka.DisplayMember = "nazwa";
        }

        public class Wycieczka()
        {
            public string nazwa { get; set; }
            public string miejsce { get; set; }
            public DateOnly data_rozpoczecia { get; set; }
            public DateOnly data_zakonczenia { get; set; }
        }

        public class Osoba()
        {
            public string imie;
            public string nazwisko;
            public Wycieczka wycieczka;
        }

        BindingList<Wycieczka> wycieczki = new BindingList<Wycieczka>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Osoba_Click(object sender, EventArgs e)
        {

        }

        private void Dodaj_osobe_Click_1(object sender, EventArgs e)
        {
            string imie = Osoba_imie.Text;
            string nazwisko = Osoba_nazwisko.Text;
        }

        private void Dodaj_wycieczke_Click(object sender, EventArgs e)
        {
            Wycieczka wycieczka = new Wycieczka
            {
                nazwa = Wycieczka_nazwa.Text,
                miejsce = Wycieczka_miejsce.Text,
                data_rozpoczecia = DateOnly.FromDateTime(Wycieczka_rozpoczecie.Value),
                data_zakonczenia = DateOnly.FromDateTime(Wycieczka_zakonczenie.Value)
            };
           
            wycieczki.Add(wycieczka);
        }
    }
}
