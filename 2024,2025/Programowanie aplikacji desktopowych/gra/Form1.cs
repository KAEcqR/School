namespace gra
{
    public partial class Form1 : Form
    {
        private int rozmiarPlanszy;
        private Button[,] planszaButtons;
        private bool turn = true;

        public Form1()
        {
            InitializeComponent();

            string input = Microsoft.VisualBasic.Interaction.InputBox("Podaj rozmiar planszy: \n (od 3 do 10)", "Rozmiar planszy", "3");

            if (!int.TryParse(input, out rozmiarPlanszy) || rozmiarPlanszy < 3 || rozmiarPlanszy > 10)
            {
                MessageBox.Show("Nieprawid³owy rozmiar. Ustawiam domyœlnie 3.");
                rozmiarPlanszy = 3;
            }

            StworzPlansze();
        }

        private void StworzPlansze()
        {
            int buttonSize = 100;
            planszaButtons = new Button[rozmiarPlanszy, rozmiarPlanszy];

            this.ClientSize = new Size(buttonSize * rozmiarPlanszy, buttonSize * rozmiarPlanszy);

            for (int y = 0; y < rozmiarPlanszy; y++)
            {
                for (int x = 0; x < rozmiarPlanszy; x++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(x * buttonSize, y * buttonSize);
                    btn.Size = new Size(buttonSize, buttonSize);
                    btn.Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold);
                    btn.Click += button_Click;
                    Controls.Add(btn);
                    planszaButtons[x, y] = btn;
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null || clickedButton.Text != "") return;

            clickedButton.Text = turn ? "X" : "O";
            turn = !turn;
        }
    }
}
