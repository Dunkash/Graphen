using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphen
{
    public partial class Form1 : Form
    {
        int marW=400;
        int marH=225;
        int sample = 100;

        Graphics g;
        Bitmap buf;

        public Form1()
        {
            InitializeComponent();
            buf = new Bitmap(pictureBox1.Width,pictureBox1.Height);  // с размерами
            pictureBox1.BackgroundImage = buf;
            g = Graphics.FromImage(buf);   // инициализация g
            g.Clear(Color.White);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            //g.RenderingOrigin = new Point(400, 225);
            //Coordinates(225);

            //Draw(Math.PI*(-1), Math.PI, Math.Sin);

        }


        public List<Double> values(double beg,double end, Func<double, double> graph)
        {
            var x = new List<Double> { };
            for (int i=0;i<sample; i+=1)
            {
                x.Add(beg + i* (end - beg) / sample);
            }
            var values = new List<Double> { };
            for (int i =0;i<sample; i+=1)
            {
                values.Add(graph(x[i]));
            }
            double scalY = 450 / (values.Max() + Math.Abs(values.Min()));
            for (int i = 0; i < values.Count; i += 1)
                values[i] *= scalY;
            return values;
        }

        public List<Double> xes(double beg, double end)
        {
            var x = new List<Double> { };
            for (int i = 0; i < sample; i += 1)
            {
                x.Add(beg + i * (end - beg) / sample);
            }
            double scalX = 800 / (x.Max() + Math.Abs(x.Min()));
            for (int i = 0; i < sample; i += 1)
                x[i] *= scalX;
            return x;
        }

        public void Graph(List<Double> x, List<Double> y, Graphics g)
        {
            var black = new Pen(Color.Red, 2);

            var yscale = y.Max() / Math.Abs(y.Min());
            var heig = 450 / (1 + yscale);

            var xscale = x.Max() / Math.Abs(x.Min());
            var wid = 800 / (1 + xscale);

            Coordinates(((int)(wid)), ((int)(450-heig)));

            for (int i =0; i<x.Count-1; i++)
            {
                g.DrawLine(black, (float)x[i]+marW, -1*(float)y[i]+marH, (float)x[i + 1]+marW, -1*(float)y[i + 1]+marH);
            }
        }

        private void Coordinates(int x, int y)
        {
            g.Clear(Color.White);
            var black = new Pen(Color.Black, 2);
            g.DrawLine(black, x, 0, x, 450);
            g.DrawLine(black, 0, y, 800, y);
        }

        private void Draw(double beg, double end, Func<double,double> func)
        {
            g.Clear(Color.White);
            var red = new Pen(Color.Red, 2);

            var x = xes(beg, end);
            var y = values(beg, end, func);

            var yscale = y.Max() / Math.Abs(y.Min());
            var heig = 450 / (1 + yscale);

            var xscale = x.Max() / Math.Abs(x.Min());
            var wid = 800 / (1 + xscale);

            Coordinates(((int)(wid)), ((int)(450 - heig)));

            for (int i = 0; i < x.Count - 1; i++)
            {
                g.DrawLine(red, (float)x[i] + (float)wid, -1 * (float)y[i] + (float)(450 - heig), (float)x[i + 1] + (float)wid, -1 * (float)y[i + 1] + (float)(450-heig)); ;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == "X")
            {
                Draw(-5, 10, x => x);
            }
            else if (comboBox1.SelectedItem.ToString() == "Sin")
            {
                Draw(Math.PI * (-1), Math.PI, Math.Sin);
            }
            else if (comboBox1.SelectedItem.ToString() == "Cos")
            {
                Draw(Math.PI * (-1), Math.PI, Math.Cos);
            }
            else if (comboBox1.SelectedItem.ToString() == "X^2")
            {
                Draw(-5, 10, x => x * x);
            }

        }

    }
}
