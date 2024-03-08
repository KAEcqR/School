using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cw10
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? currentColor = CbColors.SelectedItem as string;
            panel2.BackColor = Color.FromName(currentColor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? currentColor = CbColors.SelectedItem as string;
            if (currentColor != null)
            {
                listColors.Items.Add(currentColor);
            }
            else
            {
                MessageBox.Show("Wybierz Kolor!!!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listColors.Items.Clear();
        }

        private void btWstaw_Click(object sender, EventArgs e)
        {
            if (listColors.SelectedItems.Count > 0)
            {
                int currentIndex = listColors.SelectedIndex;

                string currentColor = CbColors.SelectedItem as string;

                if (!string.IsNullOrEmpty(currentColor))
                {
                    listColors.Items.Insert(currentIndex, currentColor);
                }
                else
                {
                    MessageBox.Show("Wybierz Kolor!!!");
                }
            }
            else
            {
                MessageBox.Show("Wybierz element w liscie");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelColor_Click(object sender, EventArgs e)
        {
            int currentIndex = listColors.SelectedIndex;
            listColors.Items.RemoveAt(currentIndex);
        }
    }
}
