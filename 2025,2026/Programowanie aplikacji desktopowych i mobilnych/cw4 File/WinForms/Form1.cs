using System.Windows.Forms;
using ClassLibrary;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String filePath = string.Empty;

        public void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                label1.Text = filePath;
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            FileOperations op = new FileOperations(filePath);
            if (checkBox1.Checked)
            {
                var (output, count) = op.SearchString(textBox1.Text);
                label3.Text = output;
                label5.Text = count.ToString();
            } else
            {
                var (output, count) = op.SearchStringSensitive(textBox1.Text);
                label3.Text = output;
                label5.Text = count.ToString();
            }
        }
    }
}
