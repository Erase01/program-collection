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
        private Bitmap drawingBitmap;
        public Methoden()
        {
            InitializeComponent();

            drawingPanel = new Panel();
            drawingPanel.Location = new Point(301, 57);
            drawingPanel.Size = new Size(450, 350);

            this.Controls.Add(drawingPanel);

            //drawingPanel.Paint += new PaintEventHandler(DrawingPanel_Paint);
            drawingBitmap = new Bitmap(drawingPanel.Width, drawingPanel.Height);

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string com2Item = comboBox2.SelectedItem?.ToString();
            string comItem = comboBox1.SelectedItem?.ToString();

            /*while (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                comItem = comboBox1.SelectedItem.ToString();
                com2Item = comboBox2.SelectedItem.ToString();
            }*/

            if (comItem == null || com2Item == null)
                return;

            ShapeType selectedShapeType = GetShapeType(com2Item);

            switch (comItem)
            {
                case "Methode mit Rückgabewert":

                    

                    break;

                case "Methode ohne Rückgabewert":

                    DrawSelectedShape(selectedShapeType);

                    break;

                case "Methode mit Referenz":
                    break;

            }

            drawingPanel.CreateGraphics().DrawImage(drawingBitmap, Point.Empty);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                comboBox1_SelectedIndexChanged(sender, e);
            }
            
        }

        private void DrawSelectedShape(ShapeType shapeType)
        {
            using (Graphics g = Graphics.FromImage(drawingBitmap))
            {
                switch (shapeType)
                {
                    case ShapeType.Rechteck:



                        break;

                    case ShapeType.Parallelogramm:



                        break;

                    case ShapeType.Raute:



                        break;

                    case ShapeType.Trapez:



                        break;

                    case ShapeType.Dreieck:

                        Point[] dreieckPoints = { new Point(50, 50), new Point(150, 50), new Point(100, 150) };
                        g.FillPolygon(Brushes.Red, dreieckPoints);
                        break;

                    case ShapeType.Kreis:



                        break;

                    default:


                        break;
                }
            }
        }
        private ShapeType GetShapeType(string shapeName)
        {
            switch(shapeName)
            {
                case "Rechteck":
                    return ShapeType.Rechteck;
                    break;

                case "Parallelogramm":
                    return ShapeType.Parallelogramm;
                    break;

                case "Raute":
                    return ShapeType.Raute;
                    break;

                case "Trapez":
                    return ShapeType.Trapez;
                    break;

                case "Dreieck":
                    return ShapeType.Dreieck;
                    break;

                case "Kreis":
                    return ShapeType.Kreis;
                    break;

                default:
                    return ShapeType.Default;
                    break;
            }
        }

        public enum ShapeType
        {
            Rechteck,
            Parallelogramm,
            Raute,
            Trapez,
            Dreieck,
            Kreis,
            Default
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }
    }
}
