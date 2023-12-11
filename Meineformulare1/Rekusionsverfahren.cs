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


            startw = startw - ((a1 - b1) * Math.Pow(startw, 4) + (a2 - b2) * Math.Pow(startw, 3) + (a3 - b3) * Math.Pow(startw, 2) + (a4 - b4) * Math.Pow(startw, 1) + (a5 - b5)) /
                              (4 * (a1 - b1) * Math.Pow(startw, 3) + (a2 - b2) * Math.Pow(startw, 2) + (a3 - b3) * Math.Pow(startw, 1) + (a4 - b4)); */
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
        }
    }
}
