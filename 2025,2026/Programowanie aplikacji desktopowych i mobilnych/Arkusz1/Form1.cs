using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace Arkusz1
{
    public partial class Form1 : Form
    {
        int r = 255;
        int g = 255;
        int b = 255;

        public Form1()
        {
            InitializeComponent();
            label7.Text = $"{r}, {g}, {b}";
            UpdateList();
        }

        private void UpdateList()
        {
            panel3.Controls.Clear();

            string[] linie = File.ReadAllLines("Colors.txt").Reverse().Take(30).ToArray(); 
            int liczbaPaneli = linie.Length;

            int kolumny = 3; 
            int odstep = 10;
            int szerokosc = 80;
            int wysokosc = 80;

            for (int i = 0; i < liczbaPaneli; i++)
            {
                Panel panel = new Panel();
                panel.Width = szerokosc;
                panel.Height = wysokosc;

                string[] elementy = linie[i].Split(',');
                int newR = int.Parse(elementy[0].Trim());
                int newG = int.Parse(elementy[1].Trim());
                int newB = int.Parse(elementy[2].Trim());

                panel.BackColor = Color.FromArgb(newR, newG, newB);

                int x = (i % kolumny) * (szerokosc + odstep);
                int y = (i / kolumny) * (wysokosc + odstep);
                panel.Location = new Point(x, y);

                Label label = new Label();
                label.Text = linie[i];
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;

                panel.Controls.Add(label);

                panel3.Controls.Add(panel);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rgb = $"{r}, {g}, {b}";
            label7.Text = rgb;
            panel2.BackColor = Color.FromArgb(r, g, b);
            File.AppendAllText("Colors.txt", rgb + Environment.NewLine);
            UpdateList();
        }

        private void SetLabels(int r2, int g2, int b2)
        {
            label4.Text = b2.ToString();
            label5.Text = g2.ToString();
            label6.Text = r2.ToString();
            panel1.BackColor = Color.FromArgb(r2, g2, b2);
        }

        private void TrackBar_ValueChanged(object sender, System.EventArgs e)
        {
            r = trackBar1.Value;
            g = trackBar2.Value;
            b = trackBar3.Value;
            SetLabels(r, g, b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Colors.txt", "");
            UpdateList();
        }
    }
}
