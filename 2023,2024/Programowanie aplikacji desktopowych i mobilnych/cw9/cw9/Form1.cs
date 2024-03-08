using cw9.models;

namespace cw9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btGen_Click(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(tbSize.Text);
                if (size < 2) return;
                Numbers numbers = new(size);
                tbNumbers.Lines = Array.ConvertAll<int, string>
                    ([.. numbers.GetNumbers], s => s.ToString());
                lbNum.Text = size.ToString();

                lbMin.Text = numbers.getMin();
                lbMax.Text = numbers.getMax();
                
            }
            
            catch (FormatException)
            {
                MessageBox.Show("NIEPOPRAWNE DANE DO ROZMIARU");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
