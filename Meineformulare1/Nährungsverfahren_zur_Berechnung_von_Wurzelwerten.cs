using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmsammlung
{
    public partial class Nährungsverfahren_zur_Berechnung_von_Wurzelwerten : Form
    {
        public Nährungsverfahren_zur_Berechnung_von_Wurzelwerten()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = (double)numericUpDown1.Value;
            double radikant = (double)numericUpDown2.Value;
            double exponent = (double)numericUpDown3.Value;

            double epsilon = 0.000001;

            int iterationen = 0;
            double x = x0;


            while (Math.Abs(Math.Pow(x, exponent) - radikant) > epsilon && iterationen < 1000)
            {
                x = x - (Math.Pow(x, exponent) - radikant) / (exponent * Math.Pow(x, exponent - 1));

                listBox1.Items.Add(iterationen);
                listBox2.Items.Add(x);
                iterationen++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
