using cw3.Models;

namespace cw3;

public partial class Form1 : Form
{
    private GameRepo _repo;
    public Form1()
    {
        InitializeComponent();
        _repo = new GameRepo();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        var games = _repo.GetGames();
        dataGridView1.DataSource = games;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedColumn = comboBox1.SelectedItem.ToString();

        var games = _repo.Sort(selectedColumn);
        dataGridView1.DataSource = games;
    }
}
