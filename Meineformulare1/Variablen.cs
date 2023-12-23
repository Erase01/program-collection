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

        private bool button1Clicked = false;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            UpdateTextBoxes(listBox1.SelectedItem?.ToString());
        }

        public void button1_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            UpdateTextBoxes(listBox1.SelectedItem?.ToString());
        }

        private void UpdateTextBoxes(string selectedItem)
        {
            string stext = "Hello World";
            char cinhalt = 'A';
            int tvalue = 1;
            int fvalue = 0;

            Random rnd = new Random();
            //int _long = rnd.Next(-9223372036854775808, 9223372036854775807);

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

            if (gvar.Contains(selectedItem))
            {
                switch (selectedItem)
                {
                    case "int16":
                        textBox1.Text = Int16.MinValue.ToString();
                        textBox2.Text = Int16.MaxValue.ToString();
                        if (button1Clicked)
                        {
                            textBox3.Text = rnd.Next(Int16.MinValue, Int16.MaxValue).ToString();
                            button1Clicked = false;
                        }
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;

                    case "int32":
                        textBox1.Text = Int32.MinValue.ToString();
                        textBox2.Text = Int32.MaxValue.ToString();
                        if (button1Clicked)
                        {
                            textBox3.Text = rnd.Next(Int32.MinValue, Int32.MaxValue).ToString();
                            button1Clicked = false;
                        }
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;

                    case "byte":
                        textBox1.Text = byte.MinValue.ToString();
                        textBox2.Text = byte.MaxValue.ToString();
                        if (button1Clicked)
                        {
                            textBox3.Text = rnd.Next(Byte.MinValue, Byte.MaxValue).ToString();
                            button1Clicked = false;
                        }
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;

                    case "sbyte":
                        textBox1.Text = sbyte.MinValue.ToString();
                        textBox2.Text = sbyte.MaxValue.ToString();
                        if (button1Clicked)
                        {
                            textBox3.Text = rnd.Next(SByte.MinValue, SByte.MaxValue).ToString();
                            button1Clicked = false;
                        }
                        textBox4.Clear();
                        textBox4.Visible = false;
                        break;

                    case "long":
                        textBox1.Text = long.MinValue.ToString();
                        textBox2.Text = long.MaxValue.ToString();
                        long randomLongVal = longRandom(rnd);
                        if (button1Clicked)
                        {
                            textBox3.Text = randomLongVal.ToString();
                            button1Clicked = false;
                        }
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;

                    case "ulong":
                        textBox1.Text = ulong.MinValue.ToString();
                        textBox2.Text = ulong.MaxValue.ToString();
                        ulong randomUlongVal = ulongRandom(rnd);
                        if (button1Clicked)
                        {
                            textBox3.Text = randomUlongVal.ToString();
                            button1Clicked = false;
                        }
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;

                    case "bool":
                        textBox1.Text = fvalue.ToString();
                        textBox2.Text = tvalue.ToString();
                        if (button1Clicked)
                        {
                            bool randomBool = rnd.Next(2) == 0;
                            textBox3.Text = randomBool.ToString();
                            button1Clicked = false;
                        }
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;
                }
            }
            else if (kvar.Contains(selectedItem))
            {

                switch (selectedItem)
                {
                    case "double":
                        textBox1.Text = double.MinValue.ToString();
                        textBox2.Text = double.MaxValue.ToString();
                        double randomDoubleVal = doubleRandom(17976931348623, -17976931348623, rnd);
                        if (button1Clicked)
                        {
                            textBox3.Text = randomDoubleVal.ToString();
                            button1Clicked = false;
                        }
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;

                    case "float":
                        textBox1.Text = float.MinValue.ToString();
                        textBox2.Text = float.MaxValue.ToString();
                        float randomFloatVal = floatRandom(34028234663852, -34028234663852, rnd);
                        if (button1Clicked)
                        {
                            textBox3.Text = randomFloatVal.ToString();
                            button1Clicked = false;
                        }
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;

                    case "decimal":
                        textBox1.Text = decimal.MinValue.ToString();
                        textBox2.Text = decimal.MaxValue.ToString();
                        decimal randomDecimalVal = DecimalRandom(-79228162514264, 79228162514264,rnd);
                        if (button1Clicked)
                        {
                            textBox3.Text = randomDecimalVal.ToString();
                            button1Clicked = false;
                        }
                        textBox4.Clear();
                        label4.Visible = false;
                        textBox4.Visible = false;
                        break;
                }
            }
            else if (zvar.Contains(selectedItem))
            {

                switch (selectedItem)
                {
                    case "string":
                        label4.Visible = true;
                        textBox4.Visible = true;
                        textBox4.Text = stext;
                        List<string> myStringList = new List<string> { "Option1", "Option2", "Option3" };
                        string randomString = RandomString(myStringList, rnd);
                        if (button1Clicked)
                        {
                            textBox3.Text = randomString;
                            button1Clicked = false;
                        }
                        textBox1.Clear();
                        textBox2.Clear();
                        break;

                    case "char":
                        label4.Visible = true;
                        textBox4.Visible = true;
                        textBox4.Text = cinhalt.ToString();
                        List<char> myCharList = new List<char> { 'A', 'B', 'C', 'D' };
                        char randomChar = RandomChar(myCharList, rnd);
                        if (button1Clicked)
                        {
                            textBox3.Text = randomChar.ToString();
                            button1Clicked = false;
                        }
                        textBox1.Clear();
                        textBox2.Clear();
                        break;
                }
            }
        }

        public long longRandom(Random rnd)
        {
            byte[] buffer = new byte[8];
            rnd.NextBytes(buffer);
            long randomLong = BitConverter.ToInt64(buffer, 0);

            return (randomLong);
        }

        public ulong ulongRandom(Random rnd)
        {
            ulong randomUlong = ((ulong)rnd.Next() << 32) | (ulong)rnd.Next();

            return randomUlong;
        }

        public double doubleRandom(double lowerBound, double upperBound ,Random rnd)
        {
            var rDouble = rnd.NextDouble();
            var rRangeDouble = rDouble * (upperBound - lowerBound) + lowerBound;
            return rRangeDouble;
        }
    
        public float floatRandom(float lowerBound, float upperBound ,Random rnd)
        {
            var rFloat = rnd.NextDouble();
            var rRangeFloat = rFloat * (upperBound - lowerBound) + lowerBound;
            return (float)rRangeFloat;
        }

        public decimal DecimalRandom(decimal minValue, decimal maxValue, Random rnd)
        {
            byte scale = (byte)rnd.Next(29);
            bool sign = rnd.Next(2) == 1;

            decimal randomDecimal = new decimal(
                rnd.Next(),
                rnd.Next(),
                rnd.Next(),
                sign,
                scale
            );

            return Math.Clamp(randomDecimal, minValue, maxValue);
        }

        public string RandomString(List<string> stringList, Random rnd)
        {
            if (stringList == null || stringList.Count == 0)
            {
                return null;
            }

            int randomIndex = rnd.Next(stringList.Count);
            return stringList[randomIndex];
        }

        public char RandomChar(List<char> charList, Random rnd)
        {
            if (charList == null || charList.Count == 0)
            {
                throw new ArgumentException("Die Liste der Zeichen darf nicht leer sein!");
            }

            int randomIndex = rnd.Next(charList.Count);
            return charList[randomIndex];
        }
    }
}
