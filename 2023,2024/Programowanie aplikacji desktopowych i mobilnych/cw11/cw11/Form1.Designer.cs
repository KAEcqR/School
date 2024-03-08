namespace cw11
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
            button1 = new Button();
            lbCount = new Label();
            label1 = new Label();
            btnLoad = new Button();
            lbProducts = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lbCount);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLoad);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 450);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(12, 63);
            button1.Name = "button1";
            button1.Size = new Size(208, 45);
            button1.TabIndex = 3;
            button1.Text = "Dodaj Produkt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Font = new Font("Segoe UI", 15F);
            lbCount.Location = new Point(166, 111);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(0, 28);
            lbCount.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 1;
            label1.Text = "Ilość Produktów : ";
            label1.Click += label1_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 15F);
            btnLoad.Location = new Point(12, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(208, 45);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Wyświetl Produkty";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lbProducts
            // 
            lbProducts.Dock = DockStyle.Fill;
            lbProducts.FormattingEnabled = true;
            lbProducts.ItemHeight = 15;
            lbProducts.Location = new Point(234, 0);
            lbProducts.Name = "lbProducts";
            lbProducts.Size = new Size(566, 450);
            lbProducts.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbProducts);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLoad;
        private ListBox lbProducts;
        private Label label1;
        private Label lbCount;
        private Button button1;
    }
}
