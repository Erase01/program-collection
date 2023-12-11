using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Programmsammlung
{
    public partial class Formvariablen : Form
    {
        // ganzzahlige Datentypen

        Boolean bit = true;       // 1 Byte  true oder false
        byte b = 0;               // 1 Byte  0 bis 255
        Int16 s = 32000;          // 2 Byte  -32.768 bis 32.767
        int minInt = -2147483648; // 4 Byte  -2.147.483.648
        int maxInt = 2147483647;  // 4 Byte  2.147.483.647
        long lng = 2147483647;    // 8 Byte  -2^63 bis 2^63-1

        // Fließkomma Zahlen
        Single sng = 12.47f;       // 4 Byte  -+ 3,4E38 mit 8 Stellen
        Double dbl = 13.12345;    // 8 Byte  -+1,8E308 mit 16 Stellen
        Decimal dec = 67.9999m;    // 12 Byte -+9,99E27 mit 28 Stellen
        string wert1 = "Hallo Welt";
        struct Person
        {
          public  string name;
          public int Zahlenwert;
          public bool Wahrheit;
        }

        Person Person1;
        enum Monate : byte
        { Januar = 1, Februar = 2, März = 3, April = 4, Mai = 5, Juni = 6, Juli = 7, August = 8, September = 9, Oktober = 10, November = 11, Dezember = 12 }
        Monate Monat1, Monat2;
        //###########################################################################
        public Formvariablen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text =Convert.ToString( bit);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(s); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(minInt);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(maxInt);
        }

        private void Formvariablen_Load(object sender, EventArgs e)
        {
            this.Refresh();
            this.CenterToParent();
            // Bild hinzufügen
            //pictureBox1.Image = Image.FromFile(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "Dateien-Hilfe/PAP-Bilder/Ausgabe einer Variablen über ein Button_Click_Ereignis.jpg"));
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label6.Text = Convert.ToString(lng);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label7.Text = Convert.ToString(sng);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label8.Text = Convert.ToString(dbl);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label9.Text = Convert.ToString(dec);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Person1.name = "Werner";
            Person1.Wahrheit = true;
            Person1.Zahlenwert = 100;
            label10.Text = Person1.name;
            label11.Text = Convert.ToString(Person1.Wahrheit);
            label12.Text = Convert.ToString(Person1.Zahlenwert);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            label13.Text = wert1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Monat1 = Monate.Januar;
            Monat2 = Monat1;
            label14.Text = Convert.ToString(Monat2);
            label15.Text = Convert.ToString(Monat2+1);
            label16.Text = Convert.ToString(Monat2+2);
        }

       
    }
}
