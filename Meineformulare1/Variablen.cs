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
    public partial class Variablen : Form
    {
        public Variablen()
        {
            InitializeComponent();
        }
        public long LongRandom(long min, long max, Random rand)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string stext = "Hello World";
            char cinhalt = 'A';
            int tvalue = 1;
            int fvalue = 0;

            Random rnd = new Random();
            int _int16 = rnd.Next(-32768, 32767);
            int _int32 = rnd.Next(-2147483648, 2147483647);
            int _byte = rnd.Next(0, 255);
            int _sbyte = rnd.Next(-128, 127);
            //int _long = rnd.Next(-9223372036854775808, 9223372036854775807);


            string boxItem = listBox1.SelectedItem.ToString();

            string[] gvar = {   "int16",
                                "int32",
                                "byte",
                                "sbyte",
                                "long",
                                "ulong",
                                "bool"
                                        };

            string[] kvar = {   "double",
                                "float",
                                "decimal"
                                        };

            string[] zvar = {
                                "string",
                                "char"
                                        };

            if (gvar.Contains(boxItem))
            {
                switch (boxItem)
                {
                    case "int16":
                        textBox1.Text = Int16.MinValue.ToString();
                        textBox2.Text = Int16.MaxValue.ToString();
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;

                    case "int32":
                        textBox1.Text = Int32.MinValue.ToString();
                        textBox2.Text = Int32.MaxValue.ToString();
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;

                    case "byte":
                        textBox1.Text = byte.MinValue.ToString();
                        textBox2.Text = byte.MaxValue.ToString();
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;

                    case "sbyte":
                        textBox1.Text = sbyte.MinValue.ToString();
                        textBox2.Text = sbyte.MaxValue.ToString();
                        textBox4.Clear();
                        textBox4.Visible = false;
                        break;

                    case "long":
                        textBox1.Text = long.MinValue.ToString();
                        textBox2.Text = long.MaxValue.ToString();
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;

                    case "ulong":
                        textBox1.Text = ulong.MinValue.ToString();
                        textBox2.Text = ulong.MaxValue.ToString();
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;

                    case "bool":
                        textBox1.Text = fvalue.ToString();
                        textBox2.Text = tvalue.ToString();
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;
                }
            }
            else if (kvar.Contains(boxItem))
            {

                switch (boxItem)
                {
                    case "double":
                        textBox1.Text = double.MinValue.ToString();
                        textBox2.Text = double.MaxValue.ToString();
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;

                    case "float":
                        textBox1.Text = float.MinValue.ToString();
                        textBox2.Text = float.MaxValue.ToString();
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;

                    case "decimal":
                        textBox1.Text = decimal.MinValue.ToString();
                        textBox2.Text = decimal.MaxValue.ToString();
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;
                }
            }
            else if (zvar.Contains(boxItem))
            {

                switch (boxItem)
                {
                    case "string":
                        label4.Visible = true;
                        textBox4.Visible = true;
                        textBox4.Text = stext;
                        textBox1.Clear();
                        textBox2.Clear();
                        break;

                    case "char":
                        label4.Visible = true;
                        textBox4.Visible = true;
                        textBox4.Text = cinhalt.ToString();
                        textBox1.Clear();
                        textBox2.Clear();
                        break;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
