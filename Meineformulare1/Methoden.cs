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
        //private Panel drawingPanel;
        //private Bitmap drawingBitmap;
        int x = 301;
        int y = 57;
        public Methoden()
        {
            InitializeComponent();

            //tt drawingPanel = new Panel();
            //tt drawingPanel.Location = new Point(301, 57);
            //tt drawingPanel.Size = new Size(450, 350);

            //tt this.Controls.Add(drawingPanel);

            //drawingPanel.Paint += new PaintEventHandler(DrawingPanel_Paint);
            //drawingBitmap = new Bitmap(drawingPanel.Width, drawingPanel.Height);

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

            //tt drawingPanel.CreateGraphics().DrawImage(drawingBitmap, Point.Empty);
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
            using (Graphics g = panel2.CreateGraphics())
            {

                switch (shapeType)
                {
                    case ShapeType.Rechteck:
                        DrawRechteck(g);
                        //panel2_Paint("test", this, new PaintEventArgs(panel2.CreateGraphics(), panel2.ClientRectangle));
                        break;

                    case ShapeType.Parallelogramm:
                        DrawParallelogramm(g);
                        break;

                    case ShapeType.Raute:
                        DrawRaute(g);
                        break;

                    case ShapeType.Trapez:
                        DrawTrapez(g);
                        break;

                    case ShapeType.Dreieck:
                        DrawDreieck(g);
                        break;

                    case ShapeType.Kreis:
                        DrawKreis(g);
                        break;

                    default:
                        MessageBox.Show("Error: Gewählte Form ist nicht verfügbar!");
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

        private void DrawRechteck(Graphics g)
        {
            Pen p = new(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Red);
            g.DrawRectangle(p, x - 50, y - 50, 50, 50);
            g.FillRectangle(sb,x - 50,y - 50, 50, 50);
        }

        private void DrawParallelogramm(Graphics g)
        {
            Point[] parallelogrammPoints = {
                new Point(100,100),
                new Point(200,100),
                new Point(250,200),
                new Point(150,200)
            };

            SolidBrush sb = new SolidBrush(Color.Blue);
            g.FillPolygon(sb, parallelogrammPoints);
        }
        private void DrawRaute(Graphics g)
        {

        }
        private void DrawTrapez(Graphics g)
        {

        }
        private void DrawDreieck(Graphics g)
        {

        }
        private void DrawKreis(Graphics g)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }
    }
}
