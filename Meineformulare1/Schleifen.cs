using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
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

            int count = 0;
            string ws = "Das ist eine while-Schleife";
            string dws = "Das ist eine do-while-Schleife";

            string[] sart = {   "Das ist eine for-Schleife",
                                "Das ist eine for-Schleife",
                                "Das ist eine for-Schleife",
                                "Das ist eine for-Schleife",
                                "Das ist eine for-Schleife",
                                "Das ist eine for-Schleife"
                                                    };

            switch (comItem)
            {
                case "for-Schleife":
                    for(int i = 0; i < sart.Length; i++)
                    {
                        listBox1.Items.Add(sart[i]);
                        
                    }
                    listBox1.Items.Add("\n");
                break;

                case "while-Schleife":
                    while(count < 6) 
                    { 
                        listBox1.Items.Add(ws);
                        count++;
                    }
                    listBox1.Items.Add("\n");
                    break;

                case "do-while-Schleife":
                    do 
                    { 
                        listBox1.Items.Add(dws);
                        count++;
                    } while(count < 6);
                    listBox1.Items.Add("\n");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
