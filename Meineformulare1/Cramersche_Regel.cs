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
    public partial class Cramersche_Regel : Form
    {
        public Cramersche_Regel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                double[,] matrix =
                {
                    { Convert.ToDouble(numericUpDownA11.Value), Convert.ToDouble(numericUpDownA12.Value), Convert.ToDouble(numericUpDownA13.Value), Convert.ToDouble(numericUpDownB1.Value) },
                    { Convert.ToDouble(numericUpDownA21.Value), Convert.ToDouble(numericUpDownA22.Value), Convert.ToDouble(numericUpDownA23.Value), Convert.ToDouble(numericUpDownB2.Value) },
                    { Convert.ToDouble(numericUpDownA31.Value), Convert.ToDouble(numericUpDownA32.Value), Convert.ToDouble(numericUpDownA33.Value), Convert.ToDouble(numericUpDownB3.Value) }
                };

                double detGesamt = DeterminanteNachSpaltenErsatz(0, matrix, 0, GetBVector(matrix));

                if (detGesamt == 0)
                { 
                    MessageBox.Show("Das Gleichungssystem hat keine eindeutige Lösung.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                double detX = DeterminanteNachSpaltenErsatz(detGesamt, matrix, 0, GetBVector(matrix));
                double detY = DeterminanteNachSpaltenErsatz(detGesamt, matrix, 1, GetBVector(matrix));
                double detZ = DeterminanteNachSpaltenErsatz(detGesamt, matrix, 2, GetBVector(matrix));

                double x = detX / detGesamt;
                double y = detY / detGesamt;
                double z = detZ / detGesamt;

                listBox1.Items.Add($"Lösung x = {x},");
                listBox1.Items.Add($"y = {y},");
                listBox1.Items.Add($"z = {z}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte geben Sie gültige Zahlen ein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static double DeterminanteNachSpaltenErsatz(double alteDeterminante, double[,] matrix, int spaltenIndex, double[] neueSpalte)
        {
            if (matrix.GetLength(0) != neueSpalte.Length)
            {
                throw new ArgumentException("Die Länge der neuen Spalte muss zur Anzahl der Zeilen in der Matrix passen.");
            }

            if (spaltenIndex < 0 || spaltenIndex >= matrix.GetLength(1))
            {
                throw new ArgumentException("Ungültiger Spaltenindex.");
            }

            double det = alteDeterminante;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                det -= matrix[i, spaltenIndex] * DeterminanteFaktorNachErsatz(matrix, spaltenIndex, i);
                matrix[i, spaltenIndex] = neueSpalte[i];
                det += matrix[i, spaltenIndex] * DeterminanteFaktorNachErsatz(matrix, spaltenIndex, i);
            }

            return det;
        }

        private static double DeterminanteFaktorNachErsatz(double[,] matrix, int spaltenIndex, int zeilenIndex)
        {
            int n = matrix.GetLength(0);

            int nextRow = (zeilenIndex + 1) % n;
            int nextNextRow = (zeilenIndex + 2) % n;

            double factor = matrix[zeilenIndex, spaltenIndex] * matrix[nextRow, (spaltenIndex + 1) % n] * matrix[nextNextRow, (spaltenIndex + 2) % n];

            return factor;
        }

        private double Determinante(double[,] matrix)
        {
            double det = 0.0;

            det = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] +
                  matrix[0, 1] * matrix[1, 2] * matrix[2, 0] +
                  matrix[0, 2] * matrix[1, 0] * matrix[2, 1] -
                  matrix[0, 2] * matrix[1, 1] * matrix[2, 0] -
                  matrix[0, 0] * matrix[1, 2] * matrix[2, 1] -
                  matrix[0, 1] * matrix[1, 0] * matrix[2, 2];
        
            return det;
        }

        private double[,] ErsetzeSpalte(double[,] matrix, int spaltenIndex, double[] neueSpalte)
        {
            matrix[0, spaltenIndex] = neueSpalte[0];
            matrix[1, spaltenIndex] = neueSpalte[1];
            matrix[2, spaltenIndex] = neueSpalte[2];

            return matrix;
        }

        private double[] GetBVector(double[,] matrix)
        {
            double[] bVector = new double[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bVector[i] = matrix[i, matrix.GetLength(1) - 1];
            }
            return bVector;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDownA11.Value = 0;
            numericUpDownA12.Value = 0;
            numericUpDownA13.Value = 0;
            numericUpDownA21.Value = 0;
            numericUpDownA22.Value = 0;
            numericUpDownA23.Value = 0;
            numericUpDownA31.Value = 0;
            numericUpDownA32.Value = 0;
            numericUpDownA33.Value = 0;
            numericUpDownB1.Value = 0;
            numericUpDownB2.Value = 0;
            numericUpDownB3.Value = 0;
            listBox1.Items.Clear();

        }
    }
}
