using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmsammlung
{
    public partial class Methoden : Form
    {
        public Methoden()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(string comb2value, object sender, EventArgs e)
        {
            string comItem = comboBox1.SelectedItem.ToString();

            switch (comItem)
            {
                case "Methode mit Rückgabewert":

                    if (comb2value == "Rechteck")
                    {

                    }

                    else if (comb2value == "Parallelogramm")
                    {

                    }

                    else if (comb2value == "Raute")
                    {

                    }

                    else if (comb2value == "Trapez")
                    {

                    }

                    else if (comb2value == "Dreieck")
                    {

                    }

                    else if (comb2value == "Kreis")
                    {

                    }
                    else
                    {
                        comboBox1.Text = "Enter valid input!";
                    }
                    break;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comBox = comboBox2.SelectedItem.ToString();
            string value;

            switch (comBox)
            {
                case "Rechteck":
                    value = "Rechteck";
                    comboBox1_SelectedIndexChanged(value, sender, e);
                    break;
                case "Parallelogramm":
                    value = "Parallelogramm";
                    comboBox1_SelectedIndexChanged(value, sender, e);
                    break;
                case "Raute":
                    value = "Raute";
                    comboBox1_SelectedIndexChanged(value, sender, e);
                    break;
                case "Trapez":
                    value = "Trapez";
                    comboBox1_SelectedIndexChanged(value, sender, e);
                    break;
                case "Dreieck":
                    value = "Dreieck";
                    comboBox1_SelectedIndexChanged(value, sender, e);
                    break;
                case "Kreis":
                    value = "Kreis";
                    comboBox1_SelectedIndexChanged(value, sender, e);
                    break;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }
    }
}
