namespace Programmsammlung
{
    partial class Methoden
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
            trackBar1 = new TrackBar();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            trackBar2 = new TrackBar();
            textBox2 = new TextBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 99);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(173, 45);
            trackBar1.TabIndex = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(299, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 340);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Methode mit Rückgabewert ", "Methode ohne Rückgabewert", "Methode mit Referenz" });
            comboBox1.Location = new Point(12, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(12, 214);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(173, 45);
            trackBar2.TabIndex = 5;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 265);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 7;
            label1.Text = "Höhe:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Rechteck", "Parallelogramm", "Raute", "Trapez", "Dreieck", "Kreis" });
            comboBox2.Location = new Point(139, 22);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 8;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 196);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 9;
            label2.Text = "Breite:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 4);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 10;
            label3.Text = "Methodenart:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 4);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "Form:";
            // 
            // Methoden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(trackBar2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Controls.Add(trackBar1);
            Name = "Methoden";
            Text = "Methoden";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TrackBar trackBar1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TrackBar trackBar2;
        private TextBox textBox2;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}