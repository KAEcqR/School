namespace kosci_egzamin
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
            btnRoll = new Button();
            btnReset = new Button();
            lbResult = new Label();
            lbScore = new Label();
            pbDice2 = new PictureBox();
            pbDice4 = new PictureBox();
            pbDice3 = new PictureBox();
            pbDice5 = new PictureBox();
            pbDice1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbDice2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDice4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDice3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDice5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDice1).BeginInit();
            SuspendLayout();
            // 
            // btnRoll
            // 
            btnRoll.BackColor = Color.FromArgb(216, 104, 24);
            btnRoll.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoll.ForeColor = Color.White;
            btnRoll.Location = new Point(336, 131);
            btnRoll.Margin = new Padding(3, 4, 3, 4);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(184, 48);
            btnRoll.TabIndex = 0;
            btnRoll.Text = " RZUĆ KOŚĆMI";
            btnRoll.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold);
            btnReset.Location = new Point(336, 492);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(184, 51);
            btnReset.TabIndex = 9;
            btnReset.Text = "ZRESETUJ WYNIK";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Italic);
            lbResult.Location = new Point(256, 372);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(158, 20);
            lbResult.TabIndex = 10;
            lbResult.Text = "Wynik tego losowania:";
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.Location = new Point(286, 425);
            lbScore.Name = "lbScore";
            lbScore.Size = new Size(78, 20);
            lbScore.TabIndex = 12;
            lbScore.Text = "Wynik Gry:";
            // 
            // pbDice2
            // 
            pbDice2.AccessibleName = "";
            pbDice2.Location = new Point(203, 209);
            pbDice2.Margin = new Padding(6, 4, 3, 4);
            pbDice2.Name = "pbDice2";
            pbDice2.Size = new Size(128, 135);
            pbDice2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDice2.TabIndex = 13;
            pbDice2.TabStop = false;
            // 
            // pbDice4
            // 
            pbDice4.AccessibleName = "";
            pbDice4.Location = new Point(526, 209);
            pbDice4.Margin = new Padding(6, 4, 3, 4);
            pbDice4.Name = "pbDice4";
            pbDice4.Size = new Size(128, 135);
            pbDice4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDice4.TabIndex = 15;
            pbDice4.TabStop = false;
            // 
            // pbDice3
            // 
            pbDice3.AccessibleName = "";
            pbDice3.Location = new Point(367, 209);
            pbDice3.Margin = new Padding(6, 4, 3, 4);
            pbDice3.Name = "pbDice3";
            pbDice3.Size = new Size(128, 135);
            pbDice3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDice3.TabIndex = 14;
            pbDice3.TabStop = false;
            // 
            // pbDice5
            // 
            pbDice5.AccessibleName = "";
            pbDice5.Location = new Point(680, 209);
            pbDice5.Margin = new Padding(6, 4, 3, 4);
            pbDice5.Name = "pbDice5";
            pbDice5.Size = new Size(128, 135);
            pbDice5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDice5.TabIndex = 16;
            pbDice5.TabStop = false;
            // 
            // pbDice1
            // 
            pbDice1.AccessibleName = "";
            pbDice1.Location = new Point(44, 209);
            pbDice1.Margin = new Padding(6, 4, 3, 4);
            pbDice1.Name = "pbDice1";
            pbDice1.Size = new Size(128, 135);
            pbDice1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDice1.TabIndex = 5;
            pbDice1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 600);
            Controls.Add(pbDice5);
            Controls.Add(pbDice4);
            Controls.Add(pbDice3);
            Controls.Add(pbDice2);
            Controls.Add(lbScore);
            Controls.Add(lbResult);
            Controls.Add(btnReset);
            Controls.Add(pbDice1);
            Controls.Add(btnRoll);
            Font = new Font("Segoe UI Emoji", 11F, FontStyle.Italic);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbDice2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDice4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDice3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDice5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDice1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRoll;
        private Button btnReset;
        private Label lbResult;
        private Label lbScore;
        private PictureBox pbDice2;
        private PictureBox pbDice4;
        private PictureBox pbDice3;
        private PictureBox pbDice5;
        private PictureBox pbDice1;
    }
}
