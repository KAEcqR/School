namespace cw8_listBox
{
    partial class AddProductForm
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
            tbPrice = new NumericUpDown();
            label3 = new Label();
            tbDescription = new TextBox();
            cbCategory = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)tbPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Nazwa produktu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 59);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Cena produktu";
            // 
            // tbName
            // 
            tbName.Location = new Point(129, 23);
            tbName.Name = "tbName";
            tbName.Size = new Size(117, 23);
            tbName.TabIndex = 2;
            // 
            // tbPrice
            // 
            tbPrice.DecimalPlaces = 2;
            tbPrice.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            tbPrice.Location = new Point(126, 57);
            tbPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(120, 23);
            tbPrice.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 92);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "Opis";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(126, 92);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(371, 119);
            tbDescription.TabIndex = 5;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "warzywa", "owoce", "nabiał", "napoje", "pieczywo", "słodycze" });
            cbCategory.Location = new Point(130, 235);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(121, 23);
            cbCategory.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 238);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Kategoria";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Location = new Point(131, 270);
            button1.Name = "button1";
            button1.Size = new Size(174, 40);
            button1.TabIndex = 8;
            button1.Text = "Zapisz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Location = new Point(311, 270);
            button2.Name = "button2";
            button2.Size = new Size(174, 40);
            button2.TabIndex = 9;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 331);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(cbCategory);
            Controls.Add(tbDescription);
            Controls.Add(label3);
            Controls.Add(tbPrice);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProductForm";
            Text = "Dodaj nowy produkt";
            ((System.ComponentModel.ISupportInitialize)tbPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private NumericUpDown tbPrice;
        private Label label3;
        private TextBox tbDescription;
        private ComboBox cbCategory;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}