using Swieta2024.Models;

namespace Swieta2024
{
    public partial class Form1 : Form
    {

        private IRepository _repository;
        public List<Danie> Dania { get; set; }

        public Form1()
        {
            InitializeComponent();

            _repository = new FileRepoCSV();
            Dania = _repository.GetDanie();
            listBox1.DataSource = Dania;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            button1.Text = curItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
