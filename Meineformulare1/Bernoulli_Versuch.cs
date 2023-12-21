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
    public partial class Bernoulli_Versuch : Form
    {
        public Bernoulli_Versuch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int anzahlVersuche = Convert.ToInt32(numericUpDown1.Value);
                double erfolgswahrscheinlichkeit = Convert.ToDouble(numericUpDown2.Value);
                int gewuenschteTrefferzahl = Convert.ToInt32(numericUpDown3.Value);

                double wahrscheinlichkeit = BernoulliBerechnung(erfolgswahrscheinlichkeit, anzahlVersuche, gewuenschteTrefferzahl);

                textBox1.Text = $"Wahrscheinlichkeit: {wahrscheinlichkeit:P}";
            }
            catch(FormatException)
            {
                MessageBox.Show("Bitte geben Sie gültige Zahlen ein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double BernoulliBerechnung(double erfolgswahrscheinlichkeit, int anzahlVersuche, int gewuenschteTrefferzahl)
        {
            // Beroulli-Formel: P(X=k) = C(n, k) * p^k * (1-p)^(n-k)

            double wahrscheinlichkeit = 0.0;

            for (int k = 0; k <= gewuenschteTrefferzahl; k++) 
            {
                double term = Binomialkoeffizient(anzahlVersuche, k) * Math.Pow(erfolgswahrscheinlichkeit, k) * Math.Pow(1 - erfolgswahrscheinlichkeit, anzahlVersuche - k);
                wahrscheinlichkeit += term;
            }

            return wahrscheinlichkeit;
        }

        private double Binomialkoeffizient(int n, int k)
        {
            if (k < 0 || k > n)
            {
                return 0;
            }

            return Fakultät(n) / (Fakultät(k) * Fakultät(n -k));
        }

        private double Fakultät(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            double result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            textBox1.Text = string.Empty;
        }
    }
}
