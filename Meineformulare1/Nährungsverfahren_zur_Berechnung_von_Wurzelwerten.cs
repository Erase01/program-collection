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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int startNae = Convert.ToInt32(textBox3.Text);
        }

    }
}
