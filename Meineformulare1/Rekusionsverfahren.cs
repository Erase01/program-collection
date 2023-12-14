using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Programmsammlung
{
    public partial class Rekusionsverfahren : Form
    {


        public Rekusionsverfahren()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            var fx1 = Convert.ToDouble(numericUpDown1.Value);
            var fx2 = Convert.ToDouble(numericUpDown2.Value);
            var fx3 = Convert.ToDouble(numericUpDown3.Value);
            var fx4 = Convert.ToDouble(numericUpDown4.Value);
            var fx5 = Convert.ToDouble(numericUpDown5.Value);

            var gx1 = Convert.ToDouble(numericUpDown10.Value);
            var gx2 = Convert.ToDouble(numericUpDown9.Value);
            var gx3 = Convert.ToDouble(numericUpDown8.Value);
            var gx4 = Convert.ToDouble(numericUpDown7.Value);
            var gx5 = Convert.ToDouble(numericUpDown6.Value);

            var startw = Convert.ToDouble(numericUpDown11.Value);
            double preResult = 0;
            double epsilon = 0.000001;
            int maxIterations = 1000;
            int iterationCount = 0;
            label15.Visible = false;

            while (true)
            {
                startw = startw - ((fx1 - gx1) * Math.Pow(startw, 4) + (fx2 - gx2) * Math.Pow(startw, 3) + (fx3 - gx3) * Math.Pow(startw, 2) + (fx4 - gx4) * Math.Pow(startw, 1) + (fx5 - gx5)) /
                                  (4 * (fx1 - gx1) * Math.Pow(startw, 3) + (fx2 - gx2) * Math.Pow(startw, 2) + (fx3 - gx3) * Math.Pow(startw, 1) + (fx4 - gx4));
                //listBox1.Items.Add(Convert.ToString(startw));

                if (Math.Abs(startw - preResult) < epsilon)
                {
                    textBox1.Text = Convert.ToString(startw);
                    textBox2.Text = Convert.ToString(0);
                    break;
                }

                else if (iterationCount >= maxIterations)
                {
                    label15.ForeColor = Color.Orange;
                    label15.Text = "Ungültige Funktion: Keine Konvergenz nach " + maxIterations + " Iterationen";
                    label15.Visible = true;
                    break;
                }

                iterationCount++;
                preResult = startw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown10.Value = 0;
            numericUpDown11.Value = 0;
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
