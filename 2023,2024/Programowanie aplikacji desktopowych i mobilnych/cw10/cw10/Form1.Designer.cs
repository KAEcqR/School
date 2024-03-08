namespace cw10
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
            listColors = new ListBox();
            btnDelColor = new Button();
            btWstaw = new Button();
            btnClearColor = new Button();
            btnAddColor = new Button();
            CbColors = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(listColors);
            panel1.Controls.Add(btnDelColor);
            panel1.Controls.Add(btWstaw);
            panel1.Controls.Add(btnClearColor);
            panel1.Controls.Add(btnAddColor);
            panel1.Controls.Add(CbColors);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 450);
            panel1.TabIndex = 0;
            // 
            // listColors
            // 
            listColors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listColors.Font = new Font("Segoe UI", 15F);
            listColors.FormattingEnabled = true;
            listColors.ItemHeight = 28;
            listColors.Location = new Point(0, 54);
            listColors.Name = "listColors";
            listColors.Size = new Size(198, 396);
            listColors.TabIndex = 0;
            // 
            // btnDelColor
            // 
            btnDelColor.Location = new Point(204, 107);
            btnDelColor.Name = "btnDelColor";
            btnDelColor.Size = new Size(183, 23);
            btnDelColor.TabIndex = 5;
            btnDelColor.Text = "Usun Kolor";
            btnDelColor.UseVisualStyleBackColor = true;
            btnDelColor.Click += btnDelColor_Click;
            // 
            // btWstaw
            // 
            btWstaw.Location = new Point(204, 136);
            btWstaw.Name = "btWstaw";
            btWstaw.Size = new Size(183, 23);
            btWstaw.TabIndex = 4;
            btWstaw.Text = "Wstaw Kolor";
            btWstaw.UseVisualStyleBackColor = true;
            btWstaw.Click += btWstaw_Click;
            // 
            // btnClearColor
            // 
            btnClearColor.Location = new Point(204, 165);
            btnClearColor.Name = "btnClearColor";
            btnClearColor.Size = new Size(183, 23);
            btnClearColor.TabIndex = 1;
            btnClearColor.Text = "Wyczysc Kolory";
            btnClearColor.UseVisualStyleBackColor = true;
            btnClearColor.Click += button1_Click_1;
            // 
            // btnAddColor
            // 
            btnAddColor.Location = new Point(204, 78);
            btnAddColor.Name = "btnAddColor";
            btnAddColor.Size = new Size(183, 23);
            btnAddColor.TabIndex = 3;
            btnAddColor.Text = "Dodaj Kolor";
            btnAddColor.UseVisualStyleBackColor = true;
            btnAddColor.Click += button1_Click;
            // 
            // CbColors
            // 
            CbColors.BackColor = SystemColors.Window;
            CbColors.DropDownStyle = ComboBoxStyle.DropDownList;
            CbColors.FormattingEnabled = true;
            CbColors.Items.AddRange(new object[] { "red", "green", "blue", "yellow", "purple", "orange", "white", "grey", "pink" });
            CbColors.Location = new Point(204, 49);
            CbColors.Name = "CbColors";
            CbColors.Size = new Size(183, 23);
            CbColors.TabIndex = 1;
            CbColors.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(204, 9);
            label2.Name = "label2";
            label2.Size = new Size(183, 37);
            label2.TabIndex = 2;
            label2.Text = "Wybierz Kolor";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 37);
            label1.TabIndex = 0;
            label1.Text = "Zbior Kolorow";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(397, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 450);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox CbColors;
        private Label label2;
        private Button btnAddColor;
        private Button btnClearColor;
        private Button btWstaw;
        private Panel panel2;
        private Button btnDelColor;
        private ListBox listColors;
    }
}
