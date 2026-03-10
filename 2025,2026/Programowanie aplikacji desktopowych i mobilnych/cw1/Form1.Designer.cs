namespace cw1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Osoba_imie = new TextBox();
            Osoba_nazwisko = new TextBox();
            Osoba_wycieczka = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            Wycieczka_miejsce = new TextBox();
            Wycieczka_nazwa = new TextBox();
            Wycieczka_rozpoczecie = new DateTimePicker();
            Wycieczka_zakonczenie = new DateTimePicker();
            label4 = new Label();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            Dodaj_osobe = new Button();
            Dodaj_wycieczke = new Button();
            SuspendLayout();
            // 
            // Osoba_imie
            // 
            Osoba_imie.Location = new Point(107, 92);
            Osoba_imie.Name = "Osoba_imie";
            Osoba_imie.Size = new Size(100, 23);
            Osoba_imie.TabIndex = 0;
            // 
            // Osoba_nazwisko
            // 
            Osoba_nazwisko.Location = new Point(107, 121);
            Osoba_nazwisko.Name = "Osoba_nazwisko";
            Osoba_nazwisko.Size = new Size(100, 23);
            Osoba_nazwisko.TabIndex = 1;
            // 
            // Osoba_wycieczka
            // 
            Osoba_wycieczka.FormattingEnabled = true;
            Osoba_wycieczka.Location = new Point(107, 150);
            Osoba_wycieczka.Name = "Osoba_wycieczka";
            Osoba_wycieczka.Size = new Size(121, 23);
            Osoba_wycieczka.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 95);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 3;
            label1.Text = "Imie";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 124);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 153);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Wycieczka";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(466, 124);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 10;
            label5.Text = "Miejsce";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(466, 95);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 9;
            label6.Text = "Nazwa";
            // 
            // Wycieczka_miejsce
            // 
            Wycieczka_miejsce.Location = new Point(580, 121);
            Wycieczka_miejsce.Name = "Wycieczka_miejsce";
            Wycieczka_miejsce.Size = new Size(100, 23);
            Wycieczka_miejsce.TabIndex = 7;
            // 
            // Wycieczka_nazwa
            // 
            Wycieczka_nazwa.Location = new Point(580, 92);
            Wycieczka_nazwa.Name = "Wycieczka_nazwa";
            Wycieczka_nazwa.Size = new Size(100, 23);
            Wycieczka_nazwa.TabIndex = 6;
            // 
            // Wycieczka_rozpoczecie
            // 
            Wycieczka_rozpoczecie.Location = new Point(580, 153);
            Wycieczka_rozpoczecie.Name = "Wycieczka_rozpoczecie";
            Wycieczka_rozpoczecie.Size = new Size(200, 23);
            Wycieczka_rozpoczecie.TabIndex = 11;
            // 
            // Wycieczka_zakonczenie
            // 
            Wycieczka_zakonczenie.Location = new Point(580, 182);
            Wycieczka_zakonczenie.Name = "Wycieczka_zakonczenie";
            Wycieczka_zakonczenie.Size = new Size(200, 23);
            Wycieczka_zakonczenie.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(466, 159);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 13;
            label4.Text = "Data rozpoczecia";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(466, 188);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 14;
            label7.Text = "Data zakonczenia";
            label7.Click += label7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 30F);
            label9.Location = new Point(96, 17);
            label9.Name = "label9";
            label9.Size = new Size(137, 54);
            label9.TabIndex = 15;
            label9.Text = "Osoba";
            label9.Click += Osoba_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 30F);
            label8.Location = new Point(523, 17);
            label8.Name = "label8";
            label8.Size = new Size(204, 54);
            label8.TabIndex = 16;
            label8.Text = "Wycieczka";
            // 
            // Dodaj_osobe
            // 
            Dodaj_osobe.Location = new Point(38, 230);
            Dodaj_osobe.Name = "Dodaj_osobe";
            Dodaj_osobe.Size = new Size(75, 23);
            Dodaj_osobe.TabIndex = 17;
            Dodaj_osobe.Text = "Dodaj";
            Dodaj_osobe.UseVisualStyleBackColor = true;
            Dodaj_osobe.Click += Dodaj_osobe_Click_1;
            // 
            // Dodaj_wycieczke
            // 
            Dodaj_wycieczke.Location = new Point(466, 230);
            Dodaj_wycieczke.Name = "Dodaj_wycieczke";
            Dodaj_wycieczke.Size = new Size(75, 23);
            Dodaj_wycieczke.TabIndex = 18;
            Dodaj_wycieczke.Text = "Dodaj";
            Dodaj_wycieczke.UseVisualStyleBackColor = true;
            Dodaj_wycieczke.Click += Dodaj_wycieczke_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Dodaj_wycieczke);
            Controls.Add(Dodaj_osobe);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(Wycieczka_zakonczenie);
            Controls.Add(Wycieczka_rozpoczecie);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(Wycieczka_miejsce);
            Controls.Add(Wycieczka_nazwa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Osoba_wycieczka);
            Controls.Add(Osoba_nazwisko);
            Controls.Add(Osoba_imie);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Osoba_imie;
        private TextBox Osoba_nazwisko;
        private ComboBox Osoba_wycieczka;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox Wycieczka_miejsce;
        private TextBox Wycieczka_nazwa;
        private DateTimePicker Wycieczka_rozpoczecie;
        private DateTimePicker Wycieczka_zakonczenie;
        private Label label4;
        private Label label7;
        private Label label9;
        private Label label8;
        private Button Dodaj_osobe;
        private Button Dodaj_wycieczke;
    }
}
