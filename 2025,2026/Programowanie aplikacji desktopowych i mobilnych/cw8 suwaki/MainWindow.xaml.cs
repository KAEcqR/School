using System;
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

namespace cw8_suwaki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string path = "dane.txt";

        public MainWindow()
        {
            InitializeComponent();
            LabelR.Text = ((int)SuwakR.Value).ToString();
            LabelG.Text = ((int)SuwakG.Value).ToString();
            LabelB.Text = ((int)SuwakB.Value).ToString();
            LabelA.Text = ((float)SuwakA.Value).ToString();

            LoadHistory();
        }

        private void LoadHistory()
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                return;
            }

            HistoryGrid.Children.Clear();

            string[] lines = File.ReadAllLines(path);

            var last10 = lines.TakeLast(10);

            foreach (string line in last10)
            {
                string[] parts = line.Split(',');

                if (parts.Length != 4)
                    continue;

                byte r = byte.Parse(parts[0]);
                byte g = byte.Parse(parts[1]);
                byte b = byte.Parse(parts[2]);
                byte a = byte.Parse(parts[3]);

                Canvas c = new Canvas();
                c.Width = 80;
                c.Height = 50;
                c.Margin = new Thickness(5);
                c.Background = new SolidColorBrush(Color.FromArgb(a, r, g, b));

                HistoryGrid.Children.Add(c);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            byte valueR = (byte)SuwakR.Value;
            byte valueG = (byte)SuwakG.Value;
            byte valueB = (byte)SuwakB.Value;
            byte valueA = (byte)SuwakA.Value;

            RgbTextBlock.Text = $"{valueR}, {valueG}, {valueB}, {valueA}";

            RgbTextBlock.Background = new SolidColorBrush(Color.FromArgb(valueA, valueR, valueG, valueB));

            string line = $"{valueR},{valueG},{valueB},{valueA}";

            File.AppendAllText(path, line + Environment.NewLine);

            LoadHistory();
        }

        private void Suwak_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (LabelR == null || LabelG == null || LabelB == null || LabelA == null)
                return;

            byte valueR = (byte)SuwakR.Value;
            byte valueG = (byte)SuwakG.Value;
            byte valueB = (byte)SuwakB.Value;
            byte valueA = (byte)SuwakA.Value;

            if (LabelR == null || LabelG == null || LabelB == null || LabelA == null)
                return;
            LabelR.Text = valueR.ToString();
            LabelG.Text = valueG.ToString();
            LabelB.Text = valueB.ToString();
            LabelA.Text = valueA.ToString();


            ColorPreview.Background = new SolidColorBrush(Color.FromArgb(valueA, valueR, valueG, valueB));
        }

    }
}