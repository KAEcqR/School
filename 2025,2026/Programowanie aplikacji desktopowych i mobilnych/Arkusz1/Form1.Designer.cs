namespace Arkusz1
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
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            button1 = new Button();
            panel2 = new Panel();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(34, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 78);
            panel1.TabIndex = 0;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(81, 167);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(534, 45);
            trackBar1.TabIndex = 1;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Value = 255;
            trackBar1.ValueChanged += TrackBar_ValueChanged;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(81, 218);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(534, 45);
            trackBar2.TabIndex = 2;
            trackBar2.TickStyle = TickStyle.None;
            trackBar2.Value = 255;
            trackBar2.ValueChanged += TrackBar_ValueChanged;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(81, 269);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(534, 45);
            trackBar3.TabIndex = 3;
            trackBar3.TickStyle = TickStyle.None;
            trackBar3.Value = 255;
            trackBar3.ValueChanged += TrackBar_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Location = new Point(217, 320);
            button1.Name = "button1";
            button1.Size = new Size(225, 41);
            button1.TabIndex = 4;
            button1.Text = "Pobierz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label7);
            panel2.Location = new Point(217, 384);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 29);
            panel2.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1, 7);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 0;
            label7.Text = "label7";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 170);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 6;
            label1.Text = "R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 221);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 7;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 272);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 8;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(621, 269);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 11;
            label4.Text = "255";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(621, 218);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 10;
            label5.Text = "255";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(621, 167);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 9;
            label6.Text = "255";
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Location = new Point(667, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(290, 426);
            panel3.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(586, 384);
            button2.Name = "button2";
            button2.Size = new Size(75, 54);
            button2.TabIndex = 13;
            button2.Text = "Wyczysc";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 450);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private Button button1;
        private Panel panel2;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel3;
        private Button button2;
    }
}
