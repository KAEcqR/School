using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace kosci_egzamin
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private int gameScore = 0;
        private PictureBox[] dice;

        public Form1()
        {
            InitializeComponent();
            dice = new PictureBox[] { pbDice1, pbDice2, pbDice3, pbDice4, pbDice5 };

            btnRoll.Click += btnRoll_Click;
            btnReset.Click += btnReset_Click;

            ResetGame();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int[] rollCounts = new int[7]; 
            int[] rolledValues = new int[dice.Length]; 

            for (int i = 0; i < dice.Length; i++)
            {
                int rollValue = rand.Next(1, 7);
                rolledValues[i] = rollValue;
                rollCounts[rollValue]++;

                Image image = null;
                switch (rollValue)
                {
                    case 1: image = LoadImage("k1.jpg"); break;
                    case 2: image = LoadImage("k2.jpg"); break;
                    case 3: image = LoadImage("k3.jpg"); break;
                    case 4: image = LoadImage("k4.jpg"); break;
                    case 5: image = LoadImage("k5.jpg"); break;
                    case 6: image = LoadImage("k6.jpg"); break;
                    default: image = LoadImage("question.jpg"); break;
                }

                if (image != null)
                {
                    dice[i].Image = image;
                }
            }

            int rollSum = 0;
            for (int i = 1; i <= 6; i++)
            {
                if (rollCounts[i] >= 2)
                {
                    rollSum += rollCounts[i] * i;
                }
            }

            gameScore += rollSum;
            lbResult.Text = $"Wynik tego losowania: {rollSum}";
            lbScore.Text = $"Wynik gry: {gameScore}";

            SaveToFile(rolledValues, rollSum);

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            foreach (var pb in dice)
            {
                string path = Path.Combine(Application.StartupPath, "Resources", "question.jpg");
                pb.Image = Image.FromFile(path);
            }
            gameScore = 0; 
            lbResult.Text = "Wynik tego losowania: 0";
            lbScore.Text = "Wynik gry: 0";

            string path2 = Path.Combine(Application.StartupPath, "wynik.txt");
            File.WriteAllText(path2, "");
        }

        private Image LoadImage(string fileName)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "Resources", fileName);
                return Image.FromFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"B³¹d ³adowania obrazu: {fileName}\n{ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void SaveToFile(int[] values, int suma)
        {
            string path = Path.Combine(Application.StartupPath, "wynik.txt");
            try
            {
                File.AppendAllText(path, "Rzut | " + string.Join(", ", values) + " Suma | " + suma + "\n");
                File.AppendAllText(path, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n");
                File.AppendAllText(path, "=====================================" + "\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"B³¹d zapisu do pliku:\n{ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
