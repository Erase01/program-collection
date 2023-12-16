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
    public partial class Arrays : Form
    {

        public Arrays()
        {
            InitializeComponent();

            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            panel1.Controls.Add(dataGridView1);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            string comItem = comboBox1.SelectedItem.ToString();

            label2.Text = "Array Dimension";

            switch (comItem)
            {
                case "Eindimensionales Array":

                    label2.Text = "Eindimensionales Array";

                    string[] eindimArray = new string[4] { "Max", "Müller", "47", "Berlin" };

                    dataGridView1.DataSource = CreateDataTable(eindimArray);

                break;

                case "Zweidimensionales Array":

                    label2.Text = "Zweidimensionales Array";

                    string[,] zweidimArray = new string[3,4] { { "Max", "Müller", "47", "Berlin" }, { "Sheldon", "Cooper", "38", "Pasadena" }, { "John", "Doe", "25", "New York" } };

                    dataGridView1.DataSource = CreateDataTable(zweidimArray);

                break;
            }
        }

        private System.Data.DataTable CreateDataTable(string[] data)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            dt.Columns.Add("Data", typeof(string));

            foreach (string item in data)
            {
                dt.Rows.Add(item);
            }

            return dt;
        }

        private System.Data.DataTable CreateDataTable(string[,] data)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            for (int col = 0; col < data.GetLength(0); col++)
            {
                dt.Columns.Add($"Column{col + 1}", typeof(string));
            }

            for (int row = 0; row < data.GetLength(1); row++)
            {
                DataRow newRow = dt.NewRow();
                for (int col = 0; col < data.GetLength(0); col++)
                {
                    newRow[col] = data[col, row];
                }
                dt.Rows.Add(newRow);
            }
            
            return dt;
        }
    }
}
