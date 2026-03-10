using cw9_classlib;

namespace cw9_test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PrzesunNormalnie()
        {
            int klucz = 1;
            Cezar silnik = new Cezar();
            char[] tekst = "abc".ToCharArray();

            // Act
            string wynik = silnik.Licz(klucz, tekst);

            // Assert
            Assert.That(wynik, Is.EqualTo("bcd"));
        }

        [Test]
        public void PrzesunPowyzej26()
        {
            int klucz = 27;
            Cezar silnik = new Cezar();
            char[] tekst = "abc".ToCharArray();

            // Act
            string wynik = silnik.Licz(klucz, tekst);

            // Assert
            Assert.That(wynik, Is.EqualTo("bcd"));
        }

        [Test]
        public void PrzesunUjemna()
        {
            int klucz = -1;
            Cezar silnik = new Cezar();
            char[] tekst = "abc".ToCharArray();

            // Act
            string wynik = silnik.Licz(klucz, tekst);

            // Assert
            Assert.That(wynik, Is.EqualTo("zab"));
        }

        [Test]
        public void PrzesunZero()
        {
            int klucz = 0;
            Cezar silnik = new Cezar();
            char[] tekst = "abc".ToCharArray();

            // Act
            string wynik = silnik.Licz(klucz, tekst);

            // Assert
            Assert.That(wynik, Is.EqualTo("abc"));
        }
    }
}
