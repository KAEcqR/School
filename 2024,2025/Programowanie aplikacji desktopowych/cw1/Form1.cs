using System.Diagnostics.Eventing.Reader;

namespace cw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int liczba = 0;
        int losowaLiczba = 0;
        int licznik = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            liczba--;
            label1.Text = liczba.ToString();
            if (liczba == -20)
            {
                button1.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            liczba++;
            label1.Text = liczba.ToString();
            if (liczba == 20)
            {
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            losowaLiczba = random.Next(0, 101);
            label5.Text = "Wylosowano liczbe";
            licznik = 0;
            label3.Text = licznik.ToString();
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            int cyfra = (int)numericUpDown1.Value;
            licznik++;
            label3.Text = licznik.ToString();

            if ( cyfra > losowaLiczba)
            {
                label5.Text = "Nizej";
            } else
            {
                label5.Text = "Wyzej";
            }

            if (cyfra == losowaLiczba)
            {
                label5.Text = "Wygrana";
                button4.Enabled = false;
                button3.Enabled = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
