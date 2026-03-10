namespace cw9_classlib
{
    public class Cezar
    {
        public string Licz(int klucz, char[] tekst)
        {
            string output = string.Empty;
            char[] alfabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            foreach (char znak in tekst)
            {
                if (char.IsLetter(znak))
                {
                    char litera = char.ToLower(znak);
                    int index = (Array.IndexOf(alfabet, litera) + klucz) % 26;
                    index = (index + 26) % 26;
                    output += alfabet[index];
                }
                else
                {
                    output += znak;
                }
            }

            return output;
        }
    }
}
