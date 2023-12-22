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

            if (comItem == null || com2Item == null)
                return;

            ShapeType selectedShapeType = GetShapeType(com2Item);
            
            switch (comItem)
            {
                case "Methode mit Rückgabewert":

                    label1.Visible = true;
                    textBox1.Visible= true;
                    textBox1.Text = "Höhe:";
                    trackBar1.Visible = true;
                    whForm = DrawSelectedShapeWithReturn(selectedShapeType);
                    textBox1.Text = whForm;

                    break;

                case "Methode ohne Rückgabewert":

                    DrawSelectedShape(selectedShapeType);
                    trackBar1.Visible = false;
                    textBox1.Visible = false;
                    label1.Visible = false;

                    break;

                case "Methode mit Referenz":

                    trackBar1.Visible= false;
                    textBox1.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Anzahl der gezeichneten Formen:";
                    int numberOfShaps = 0;
                    string updatedNumberOfShapes = DrawSelectedShapeWithReference(selectedShapeType, ref numberOfShaps);
                    textBox1.Text = updatedNumberOfShapes;
                    
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
                        whForm = DrawParallelogramm(g, 150 + breite, 100 + breite, 300 + höhe, 100 + breite, 350 + höhe, 200 + höhe, 200 + breite, 200 + höhe);
                        break;

                    case ShapeType.Raute:
                        whForm = DrawRaute(g, 250, 200 + höhe, 350 + höhe, 100, 250, 0 + breite, 150 + breite, 100);
                        break;

                    case ShapeType.Trapez:
                        whForm = DrawTrapez(g, 200 + breite, 100 + breite, 300 + höhe, 100 + breite, 350 + höhe, 200 + höhe, 150 + breite, 200 + höhe);
                        break;

                    case ShapeType.Dreieck:
                        whForm = DrawDreieck(g, 250, 0 + breite, 150 + breite, 200 + höhe, 350 + höhe, 200 + höhe);
                       break;

                    case ShapeType.Kreis:
                        whForm = DrawKreis(g, 150, 0, 200 + höhe, 200 + höhe);
                        break;

                    default:
                        MessageBox.Show("Error: Gewählte Form ist nicht verfügbar!");
                        break;
                }
            }

            return whForm;
        }

        private string DrawSelectedShapeWithReference(ShapeType shapeType, ref int numberOfShapsDrawn ) 
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

                numberOfShapsDrawn++;
                return Convert.ToString(numberOfShapsDrawn);
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

        private string DrawRechteck(Graphics g, int x = 150, int y = 0, int width = 200, int height = 200 )
        {
            Pen p = new(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Red);
            g.DrawRectangle(p, x, y, width, height);
            g.FillRectangle(sb, x, y, width, height);

            //trackBar1_Scroll(ShapeType.Parallelogramm, this, EventArgs.Empty);

            return $"a: {width} | b: {height}";
        }

        private string DrawParallelogramm(Graphics g, int x1 = 150, int y1 = 100, int x2 = 300, int y2 = 100, int x3 = 350, int y3 = 200, int x4 = 200, int y4 = 200 )
        {
            Point[] parallelogrammPoints = {
                new Point(x1, y1),     //100,100   125,100
                new Point(x2, y2),     //200,100   275,100
                new Point(x3, y3),     //250,200   350,200
                new Point(x4, y4)      //150,200   200,200
            };

            SolidBrush sb = new SolidBrush(Color.Blue);
            g.FillPolygon(sb, parallelogrammPoints);

            return $"b: {x3 - x1} | h: {y3 - y1}";
        }
        private string DrawRaute(Graphics g, int x1 = 250, int y1 = 200, int x2 = 350, int y2 = 100, int x3 = 250, int y3 = 0, int x4 = 150, int y4 = 100 )
        {
            Point[] rautePoints = {
                new Point(x1, y1),    //200,100
                new Point(x2, y2),    //300,200
                new Point(x3, y3),    //200,300
                new Point(x4, y4)     //100,200
            };

            SolidBrush sb = new SolidBrush(Color.Green);
            g.FillPolygon(sb, rautePoints);

            return $"e: {x2 - x4} | f: {y1 - y3}";
        }
        private string DrawTrapez(Graphics g, int x1 = 200, int y1 = 100, int x2 = 300, int y2 = 100, int x3 = 350, int y3 = 200, int x4 = 150, int y4 = 200 )
        {
            Point[] trapezPoints = {
                new Point(x1, y1),    //300,100   125, 100
                new Point(x2, y2),    //400,100   275, 100
                new Point(x3, y3),    //350,200   350, 200
                new Point(x4, y4)     //250,200    50, 200
            };
            SolidBrush sb = new SolidBrush(Color.Yellow);
            g.FillPolygon(sb, trapezPoints);

            return $"m: {((x3 - x4) + (x2 - x1)) / 2} | h: {y3 - y2}";
        }
        private string DrawDreieck(Graphics g, int x1 = 250, int y1 = 0, int x2 = 150, int y2 = 200, int x3 = 350, int y3 = 200 )
        {
            Point[] dreieckPoints = {
                new Point(x1, y1),    //150,200
                new Point(x2, y2),    //100,300
                new Point(x3, y3)     //200,300
                
            };

            SolidBrush sb = new SolidBrush(Color.Pink);
            g.FillPolygon(sb, dreieckPoints);

            return $"g: {x3 - x2} | h: {y3 - y1}";
        }
        private string DrawKreis(Graphics g, int x = 150, int y = 0, int width = 200, int height = 200 )
        {
            Pen p = new(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Orange);
            g.DrawEllipse(p, x, y, width, height);
            g.FillEllipse(sb, x, y, width, height);

            return $"U: { Math.PI * (width / 2) * 2} | r: {height / 2}";
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

    }
}
