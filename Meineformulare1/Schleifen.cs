using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Programmsammlung
{
    public partial class Schleifen : Form
    {
        public Schleifen()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comItem = comboBox1.SelectedItem.ToString();

            string fs = "Das ist eine for-Schleife";

            string[] sart = {   "for-Schleife",
                                "while-Schleife",
                                "do-while-Schleife"
                                                    };

            switch (comItem)
            {
                case "for-Schleife":
                    for(int i = 0; i < sart.Length; i++)
                    {
                        listBox1.Text = fs;
                        
                    }
                break;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
