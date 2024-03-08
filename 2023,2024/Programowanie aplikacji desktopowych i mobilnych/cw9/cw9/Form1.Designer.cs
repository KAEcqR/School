namespace cw9
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
            panel1 = new Panel();
            btClose = new Button();
            btGen = new Button();
            label1 = new Label();
            tbSize = new TextBox();
            tbNumbers = new TextBox();
            label2 = new Label();
            lbNum = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbMin = new Label();
            lbMax = new Label();
            lbParzyste = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btClose);
            panel1.Controls.Add(btGen);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbSize);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btClose.Location = new Point(12, 397);
            btClose.Name = "btClose";
            btClose.Size = new Size(178, 41);
            btClose.TabIndex = 3;
            btClose.Text = "zamknij";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btGen
            // 
            btGen.Location = new Point(12, 80);
            btGen.Name = "btGen";
            btGen.Size = new Size(178, 45);
            btGen.TabIndex = 2;
            btGen.Text = "generuj";
            btGen.UseVisualStyleBackColor = true;
            btGen.Click += btGen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(178, 28);
            label1.TabIndex = 1;
            label1.Text = "ROZMIAR TABLICY ";
            // 
            // tbSize
            // 
            tbSize.Location = new Point(12, 51);
            tbSize.Name = "tbSize";
            tbSize.Size = new Size(178, 23);
            tbSize.TabIndex = 0;
            // 
            // tbNumbers
            // 
            tbNumbers.Dock = DockStyle.Left;
            tbNumbers.Location = new Point(200, 0);
            tbNumbers.Multiline = true;
            tbNumbers.Name = "tbNumbers";
            tbNumbers.ScrollBars = ScrollBars.Vertical;
            tbNumbers.Size = new Size(118, 450);
            tbNumbers.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(456, 43);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 2;
            label2.Text = "Ilosc Liczb : ";
            // 
            // lbNum
            // 
            lbNum.AutoSize = true;
            lbNum.Font = new Font("Segoe UI", 15F);
            lbNum.Location = new Point(564, 43);
            lbNum.Name = "lbNum";
            lbNum.Size = new Size(0, 28);
            lbNum.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(456, 80);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 4;
            label3.Text = "Min : ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(456, 117);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 5;
            label4.Text = "Max : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(456, 154);
            label5.Name = "label5";
            label5.Size = new Size(92, 28);
            label5.TabIndex = 6;
            label5.Text = "Parzyste: ";
            // 
            // lbMin
            // 
            lbMin.AutoSize = true;
            lbMin.Font = new Font("Segoe UI", 15F);
            lbMin.Location = new Point(505, 80);
            lbMin.Name = "lbMin";
            lbMin.Size = new Size(0, 28);
            lbMin.TabIndex = 7;
            // 
            // lbMax
            // 
            lbMax.AutoSize = true;
            lbMax.Font = new Font("Segoe UI", 15F);
            lbMax.Location = new Point(505, 117);
            lbMax.Name = "lbMax";
            lbMax.Size = new Size(0, 28);
            lbMax.TabIndex = 8;
            // 
            // lbParzyste
            // 
            lbParzyste.AutoSize = true;
            lbParzyste.Font = new Font("Segoe UI", 15F);
            lbParzyste.Location = new Point(536, 154);
            lbParzyste.Name = "lbParzyste";
            lbParzyste.Size = new Size(0, 28);
            lbParzyste.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbParzyste);
            Controls.Add(lbMax);
            Controls.Add(lbMin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbNum);
            Controls.Add(label2);
            Controls.Add(tbNumbers);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "OKNO GŁÓWNE";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox tbNumbers;
        private TextBox tbSize;
        private Button btClose;
        private Button btGen;
        private Label label1;
        private Label label2;
        private Label lbNum;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbMin;
        private Label lbMax;
        private Label lbParzyste;
    }
}
