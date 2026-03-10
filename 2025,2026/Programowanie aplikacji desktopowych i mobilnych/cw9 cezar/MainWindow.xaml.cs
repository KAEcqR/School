using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using cw9_classlib;
using Microsoft.Win32;

namespace cw9_cezar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Szyfruj(object sender, RoutedEventArgs e)
        {
            OutputText.Text = string.Empty;
            int klucz;
            char[] litery = InputText.Text.ToCharArray();
            char[] alfabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Cezar silnik = new Cezar();

            if (int.TryParse(InputKey.Text, out klucz))
            {
                OutputText.Text = silnik.Licz(klucz, litery);

            } else
            {
                OutputText.Text = InputText.Text;
            };
        }


        private void Zapisz(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FileName = "szyfr.txt";

            if (saveFileDialog.ShowDialog() == true)
            {
                string sciezka = saveFileDialog.FileName;

                File.WriteAllText(sciezka, OutputText.Text);

                MessageBox.Show("Plik został zapisany pomyślnie!");
            }
        }
    }
}