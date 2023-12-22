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
    public partial class Verzweigungen : Form
    {
        public Verzweigungen()
        {
            InitializeComponent();
            
            label3.Visible = false;
            label6.Visible = false;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int items = comboBox1.SelectedIndex;

            if (items == 0)
            {
                label3.Visible = true;
                label3.ForeColor = Color.Green;
                label3.Text = "Kuchen ist gut geworden!";
            }
            else if (items == 1)
            {
                label3.Visible = true;
                label3.ForeColor = Color.Orange;
                label3.Text = "Kuchen ist noch roh!";
            }
            else
            {
                label3.Visible = true;
                label3.ForeColor = Color.Red;
                label3.Text = "Kuchen ist verbrannt!";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox2.SelectedIndex)
            {
                case 0:
                    label6.Visible = true;
                    label6.ForeColor = Color.Green;
                    label6.Text = "Pflanze wurder genau richtig gegossen!";
                    break;

                case 1:
                    label6.Visible = true;
                    label6.ForeColor = Color.OrangeRed;
                    label6.Text = "Pflanze verdurstet!";
                    break;

                case 2:
                    label6.Visible = true;
                    label6.ForeColor = Color.Red;
                    label6.Text = "Pflanze ertrinkt!";
                    break;
            }
        }
    }
}
