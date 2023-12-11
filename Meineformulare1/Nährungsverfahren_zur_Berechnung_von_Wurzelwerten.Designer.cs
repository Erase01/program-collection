namespace Programmsammlung
{
    partial class Nährungsverfahren_zur_Berechnung_von_Wurzelwerten
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            listBox2 = new ListBox();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(354, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(524, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(184, 39);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 21);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 3;
            label1.Text = "Startwert der Nährung";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 21);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 4;
            label2.Text = "Vorgegebener Radikant";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(527, 21);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 5;
            label3.Text = "Wurzelexponent";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(285, 97);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(63, 289);
            listBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 79);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 7;
            label4.Text = "Anzahl der Iterationen:";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(398, 97);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(143, 289);
            listBox2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 79);
            label5.Name = "label5";
            label5.Size = new Size(134, 15);
            label5.TabIndex = 9;
            label5.Text = "Anzahl der Wurzelwerte:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(92, 119);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 10;
            // 
            // Nährungsverfahren_zur_Berechnung_von_Wurzelwerten
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(listBox2);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Nährungsverfahren_zur_Berechnung_von_Wurzelwerten";
            Text = "Nährungsverfahren_zur_Berechnung_von_Wurzelwerten";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private Label label4;
        private ListBox listBox2;
        private Label label5;
        private NumericUpDown numericUpDown1;
    }
}