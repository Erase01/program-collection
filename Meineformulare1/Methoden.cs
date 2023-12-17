using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmsammlung
{
    public partial class Methoden : Form
    {
        private Panel drawingPanel;
        public Methoden()
        {
            InitializeComponent();

            drawingPanel = new Panel();
            drawingPanel.Location = new Point(301, 57);
            drawingPanel.Size = new Size(450, 350);

            this.Controls.Add(drawingPanel);

            //drawingPanel.Paint += new PaintEventHandler(DrawingPanel_Paint);
        }

        private void comboBox1_SelectedIndexChanged(string com2value, object sender, EventArgs e)
        {
            string comItem = comboBox1.SelectedItem.ToString();

            switch (comItem)
            {
                case "Methode mit Rückgabewert":

                    DrawSelectedShape(com2value, drawingPanel.CreateGraphics());

                break;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comBox = comboBox2.SelectedItem.ToString();
            comboBox1_SelectedIndexChanged(comBox, sender, e);

        }

        private void DrawSelectedShape(string com2Value, Graphics g)
        {
            switch (com2Value)
            {
                case "Rechteck":
                    


                    break;

                case "Parallelogramm":



                    break;

                case "Raute":



                    break;

                case "Trapez":



                    break;

                case "Dreieck":

                    Point[] dreieckPoints = { new Point(50,50), new Point(150,50), new Point(100,150)};
                    g.FillPolygon(Brushes.Red, dreieckPoints);

                    break;

                case "Kreis":



                    break;

                default: 
                    
                    
                    break;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }
    }
}
