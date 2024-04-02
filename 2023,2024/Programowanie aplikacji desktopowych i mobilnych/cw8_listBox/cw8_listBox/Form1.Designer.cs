namespace cw8_listBox
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnDelete = new Button();
            btnAdd = new Button();
            lbCoumt = new Label();
            label1 = new Label();
            btnLoad = new Button();
            lbProducts = new ListBox();
            fakeRepoBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fakeRepoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(lbCoumt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLoad);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 158);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(172, 50);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Usuń wybrany produkt";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 87);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(172, 50);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Nowy produkt";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbCoumt
            // 
            lbCoumt.AutoSize = true;
            lbCoumt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbCoumt.ForeColor = Color.DarkRed;
            lbCoumt.Location = new Point(125, 406);
            lbCoumt.Name = "lbCoumt";
            lbCoumt.Size = new Size(0, 25);
            lbCoumt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 414);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "Ilość produktów:";
            label1.Click += label1_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 17);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(172, 50);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Wyświetl produkty";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lbProducts
            // 
            lbProducts.Dock = DockStyle.Fill;
            lbProducts.FormattingEnabled = true;
            lbProducts.ItemHeight = 15;
            lbProducts.Location = new Point(200, 0);
            lbProducts.Name = "lbProducts";
            lbProducts.Size = new Size(600, 450);
            lbProducts.TabIndex = 1;
            lbProducts.DataSourceChanged += lbProducts_DataSourceChanged;
            // 
            // fakeRepoBindingSource
            // 
            fakeRepoBindingSource.DataSource = typeof(Models.FakeRepo);
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
            ((System.ComponentModel.ISupportInitialize)fakeRepoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLoad;
        private ListBox lbProducts;
        private BindingSource fakeRepoBindingSource;
        private Label lbCoumt;
        private Label label1;
        private Button btnAdd;
        private Button btnDelete;
    }
}
