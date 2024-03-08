
namespace cw8
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
            next = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            firstname = new TextBox();
            age = new TextBox();
            lastname = new TextBox();
            save = new Button();
            result = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 0;
            label1.Text = "TO JEST OKNO NUMER 2";
            label1.Click += label1_Click;
            // 
            // next
            // 
            next.Location = new Point(32, 43);
            next.Name = "next";
            next.Size = new Size(338, 53);
            next.TabIndex = 1;
            next.Text = "PRZEJDZ DO OKIENKA TRZECIEGO";
            next.UseVisualStyleBackColor = true;
            next.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 121);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 2;
            label2.Text = "IMIE";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 168);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "NAZWISKO";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 213);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 2;
            label4.Text = "WIEK";
            // 
            // firstname
            // 
            firstname.Location = new Point(120, 118);
            firstname.Name = "firstname";
            firstname.Size = new Size(250, 23);
            firstname.TabIndex = 3;
            firstname.TextChanged += textBox1_TextChanged;
            // 
            // age
            // 
            age.Location = new Point(120, 210);
            age.Name = "age";
            age.Size = new Size(250, 23);
            age.TabIndex = 3;
            // 
            // lastname
            // 
            lastname.Location = new Point(120, 165);
            lastname.Name = "lastname";
            lastname.Size = new Size(250, 23);
            lastname.TabIndex = 3;
            // 
            // save
            // 
            save.Location = new Point(44, 255);
            save.Name = "save";
            save.Size = new Size(326, 41);
            save.TabIndex = 4;
            save.Text = "ZAPISZ";
            save.UseVisualStyleBackColor = true;
            save.Click += button2_Click;
            // 
            // result
            // 
            result.BackColor = SystemColors.GradientInactiveCaption;
            result.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            result.ForeColor = SystemColors.HotTrack;
            result.Location = new Point(44, 320);
            result.Name = "result";
            result.Size = new Size(326, 159);
            result.TabIndex = 5;
            result.Text = "label5";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 505);
            Controls.Add(result);
            Controls.Add(save);
            Controls.Add(lastname);
            Controls.Add(age);
            Controls.Add(firstname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(next);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text = "ZAPISANO";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Button next;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox firstname;
        private TextBox age;
        private TextBox lastname;
        private Button save;
        private Label result;
    }
}