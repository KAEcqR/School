namespace cw11
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbName = new TextBox();
            nmPrice = new NumericUpDown();
            label3 = new Label();
            tbDescription = new TextBox();
            label4 = new Label();
            cbCategory = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nmPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 0;
            label1.Text = "Nazwa Produktu :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 1;
            label2.Text = "Cena Produktu :";
            label2.Click += label2_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(234, 14);
            tbName.Name = "tbName";
            tbName.Size = new Size(144, 23);
            tbName.TabIndex = 2;
            tbName.TextChanged += textBox1_TextChanged;
            // 
            // nmPrice
            // 
            nmPrice.Location = new Point(234, 54);
            nmPrice.Name = "nmPrice";
            nmPrice.Size = new Size(144, 23);
            nmPrice.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 5;
            label3.Text = "Opis Produktu :";
            label3.Click += label3_Click;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(234, 99);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(291, 121);
            tbDescription.TabIndex = 6;
            tbDescription.TextChanged += textBox2_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(12, 238);
            label4.Name = "label4";
            label4.Size = new Size(192, 28);
            label4.TabIndex = 7;
            label4.Text = "Kategoria Produktu: ";
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "owoce", "warzywa" });
            cbCategory.Location = new Point(234, 243);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(144, 23);
            cbCategory.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(381, 278);
            button1.Name = "button1";
            button1.Size = new Size(144, 46);
            button1.TabIndex = 9;
            button1.Text = "Anuluj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(231, 278);
            button2.Name = "button2";
            button2.Size = new Size(144, 46);
            button2.TabIndex = 10;
            button2.Text = "Zapisz";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 345);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cbCategory);
            Controls.Add(label4);
            Controls.Add(tbDescription);
            Controls.Add(label3);
            Controls.Add(nmPrice);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)nmPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private NumericUpDown nmPrice;
        private Label label3;
        private TextBox tbDescription;
        private Label label4;
        private ComboBox cbCategory;
        private Button button1;
        private Button button2;
    }
}