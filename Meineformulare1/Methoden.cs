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

        private string DrawSelectedShapeWithReturn(ShapeType shapeType, int höhe = 0)
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

        private string DrawRechteck(Graphics g, int x = 150, int y = 0, int width = 200, int height = 200)
        {
            Pen p = new(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Red);
            g.DrawRectangle(p, x, y, width, height);
            g.FillRectangle(sb, x, y, width, height);

            //trackBar1_Scroll(ShapeType.Parallelogramm, this, EventArgs.Empty);

            return $"Seite a: {width} | Seite b: {height}";
        }

        private void DrawParallelogramm(Graphics g)
        {
            Point[] parallelogrammPoints = {
                new Point(150,100),     //100,100   125,100
                new Point(300,100),     //200,100   275,100
                new Point(350,200),     //250,200   350,200
                new Point(200,200)      //150,200   200,200
            };

            SolidBrush sb = new SolidBrush(Color.Blue);
            g.FillPolygon(sb, parallelogrammPoints);
        }
        private void DrawRaute(Graphics g)
        {
            Point[] rautePoints = {
                new Point(250, 200),    //200,100
                new Point(350, 100),    //300,200
                new Point(250, 0),    //200,300
                new Point(150, 100)     //100,200
            };

            SolidBrush sb = new SolidBrush(Color.Green);
            g.FillPolygon(sb, rautePoints);

            //trackBar1_Scroll(ShapeType.Raute, this, EventArgs.Empty);

            
        }
        private void DrawTrapez(Graphics g)
        {
            Point[] trapezPoints = {
                new Point(200, 100),    //300,100   125, 100
                new Point(300, 100),    //400,100   275, 100
                new Point(350, 200),    //350,200   350, 200
                new Point(150, 200)     //250,200    50, 200
            };
            SolidBrush sb = new SolidBrush(Color.Yellow);
            g.FillPolygon(sb, trapezPoints);
        }
        private void DrawDreieck(Graphics g)
        {
            Point[] dreieckPoints = {
                new Point(250, 0),    //150,200
                new Point(150, 200),    //100,300
                new Point(350, 200)     //200,300
                
            };

            SolidBrush sb = new SolidBrush(Color.Pink);
            g.FillPolygon(sb, dreieckPoints);
        }
        private void DrawKreis(Graphics g)
        {
            Pen p = new(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Orange);
            g.DrawEllipse(p, 150, 0, 200, 200);
            g.FillEllipse(sb, 150, 0, 200, 200);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int value = trackBar1.Value;

            if (value > lastv)
            {
                lasth += höhe;
                höhe += -25;
                whForm = DrawSelectedShapeWithReturn(current, höhe);
            }
            else if (value < lastv)
            {
                höhe += 25;
                whForm = DrawSelectedShapeWithReturn(current, höhe);
            }
            textBox1.Text = whForm;
            lastv = value;
            lasth = höhe;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int breite = trackBar2.Value;
        }
    }
}
