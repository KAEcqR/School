using cw4_1.Models;
using System.Windows.Forms;

namespace cw4_1
{
    public partial class Form1 : Form
    {
        private GiftsRepo _repo;
        public List<Gift> Gifts { get; set; }
        public Form1()
        {
            InitializeComponent();
            _repo = new GiftsRepo();
            Gifts = _repo.GetGifts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Gifts;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox3.Text;
            string From_sb = textBox1.Text;
            string For_sb = textBox2.Text;
            int Price = (int)numericUpDown1.Value;
            string Packaging = comboBox1.Text;

            _repo.AddGift(Name, From_sb, For_sb, Price, Packaging);

            RefreshGridView();
        }
        private void RefreshGridView()
        {
            var updatedGifts = _repo.GetGifts();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = updatedGifts;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }

    }
}
