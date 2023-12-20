using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Programmsammlung.Methoden;

namespace Programmsammlung
{
    public partial class Methoden : Form
    {
        //private Panel drawingPanel;
        //private Bitmap drawingBitmap;
        int x = 301;
        int y = 57;
        string whForm;
        private ShapeType current;

        private int höhe = 0;
        private int lastv = 0;
        private int lasth = 0;
        private int breite = 0;
        private int lastb = 0;
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
            trackBar1.Scroll += trackBar1_Scroll;
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

                    whForm = DrawSelectedShapeWithReturn(selectedShapeType);
                    textBox1.Text = whForm;

                    break;

                case "Methode ohne Rückgabewert":

                    DrawSelectedShape(selectedShapeType);

                    break;

                case "Methode mit Referenz":
                    break;

                default:
                    MessageBox.Show("no");
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
                g.Clear(SystemColors.Control);

                switch (shapeType)
                {
                    case ShapeType.Rechteck:
                        DrawRechteck(g);
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

        private string DrawSelectedShapeWithReturn(ShapeType shapeType, int höhe = 0, int breite = 0)
        {
            current = shapeType;
            using (Graphics g = panel2.CreateGraphics())
            {
                g.Clear(SystemColors.Control);

                switch (shapeType)
                {
                    case ShapeType.Rechteck:
                        whForm = DrawRechteck(g, 150, 0, 200 + höhe, 200 + höhe);
                        break;

                    case ShapeType.Parallelogramm:
                        DrawParallelogramm(g, 150 + breite, 100 + breite, 300 + höhe, 100 + breite, 350 + höhe, 200 + höhe, 200 + breite, 200 + höhe);
                        break;

                    case ShapeType.Raute:
                        DrawRaute(g, 250, 200 + höhe, 350 + höhe, 100, 250, 0 + breite, 150 + breite, 100);
                        break;

                    case ShapeType.Trapez:
                        DrawTrapez(g, 200 + breite, 100 + breite, 300 + höhe, 100 + breite, 350 + höhe, 200 + höhe, 150 + breite, 200 + höhe);
                        break;

                    case ShapeType.Dreieck:
                        DrawDreieck(g, 250, 0 + breite, 150 + breite, 200 + höhe, 350 + höhe, 200 + höhe);
                       break;

                    case ShapeType.Kreis:
                        DrawKreis(g, 150, 0, 200 + höhe, 200 + höhe);
                        break;

                    default:
                        MessageBox.Show("Error: Gewählte Form ist nicht verfügbar!");
                        break;
                }
            }

            return whForm;
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

        private string DrawRechteck(Graphics g, int x = 150, int y = 0, int width = 200, int height = 200 )
        {
            Pen p = new(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Red);
            g.DrawRectangle(p, x, y, width, height);
            g.FillRectangle(sb, x, y, width, height);

            //trackBar1_Scroll(ShapeType.Parallelogramm, this, EventArgs.Empty);

            return $"Seite a: {width} | Seite b: {height}";
        }

        private void DrawParallelogramm(Graphics g, int x1 = 150, int y1 = 100, int x2 = 300, int y2 = 100, int x3 = 350, int y3 = 200, int x4 = 200, int y4 = 200 )
        {
            Point[] parallelogrammPoints = {
                new Point(x1, y1),     //100,100   125,100
                new Point(x2, y2),     //200,100   275,100
                new Point(x3, y3),     //250,200   350,200
                new Point(x4, y4)      //150,200   200,200
            };

            SolidBrush sb = new SolidBrush(Color.Blue);
            g.FillPolygon(sb, parallelogrammPoints);

            //return $"Seite a: {width} | Seite b: {height}";       TODO!
        }
        private void DrawRaute(Graphics g, int x1 = 250, int y1 = 200, int x2 = 350, int y2 = 100, int x3 = 250, int y3 = 0, int x4 = 150, int y4 = 100 )
        {
            Point[] rautePoints = {
                new Point(x1, y1),    //200,100
                new Point(x2, y2),    //300,200
                new Point(x3, y3),    //200,300
                new Point(x4, y4)     //100,200
            };

            SolidBrush sb = new SolidBrush(Color.Green);
            g.FillPolygon(sb, rautePoints);

            //return $"Seite a: {width} | Seite b: {height}";       TODO!
        }
        private void DrawTrapez(Graphics g, int x1 = 200, int y1 = 100, int x2 = 300, int y2 = 100, int x3 = 350, int y3 = 200, int x4 = 150, int y4 = 200 )
        {
            Point[] trapezPoints = {
                new Point(x1, y1),    //300,100   125, 100
                new Point(x2, y2),    //400,100   275, 100
                new Point(x3, y3),    //350,200   350, 200
                new Point(x4, y4)     //250,200    50, 200
            };
            SolidBrush sb = new SolidBrush(Color.Yellow);
            g.FillPolygon(sb, trapezPoints);

            //return $"Seite a: {width} | Seite b: {height}";       TODO!
        }
        private void DrawDreieck(Graphics g, int x1 = 250, int y1 = 0, int x2 = 150, int y2 = 200, int x3 = 350, int y3 = 200 )
        {
            Point[] dreieckPoints = {
                new Point(x1, y1),    //150,200
                new Point(x2, y2),    //100,300
                new Point(x3, y3)     //200,300
                
            };

            SolidBrush sb = new SolidBrush(Color.Pink);
            g.FillPolygon(sb, dreieckPoints);

            //return $"Seite a: {width} | Seite b: {height}";       TODO!
        }
        private void DrawKreis(Graphics g, int x = 150, int y = 0, int width = 200, int height = 200 )
        {
            Pen p = new(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Orange);
            g.DrawEllipse(p, x, y, width, height);
            g.FillEllipse(sb, x, y, width, height);

            //return $"Seite a: {width} | Seite b: {height}";       TODO!
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int value = trackBar1.Value;

            if (value > lastv)
            {
                lastb += breite;
                breite += 25;
                lasth += höhe;
                höhe += -25;
                whForm = DrawSelectedShapeWithReturn(current, höhe, breite);
            }
            else if (value < lastv)
            {
                breite += -25;
                höhe += 25;
                whForm = DrawSelectedShapeWithReturn(current, höhe, breite);
            }
            textBox1.Text = whForm;
            lastv = value;
            lasth = höhe;
            lastb = breite;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int breite = trackBar2.Value;
        }
    }
}
