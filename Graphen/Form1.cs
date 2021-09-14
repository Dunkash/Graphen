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
            comboBox1.Items.Add("Sin");
            comboBox1.Items.Add("Cos");
            comboBox1.Items.Add("X");
            comboBox1.Items.Add("X^2");
            //g.RenderingOrigin = new Point(400, 225);
            Coordinates();
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
            double scalY = 225 / Math.Max(values.Max(), Math.Abs(values.Min()));
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
            double scalX = 400 / Math.Max(x.Max(), Math.Abs(x.Min()));
            for (int i = 0; i < sample; i += 1)
                x[i] *= scalX;
            return x;
        }

        public void Graph(List<Double> x, List<Double> y, Graphics g)
        {
            var black = new Pen(Color.Red, 2);
            for (int i =0; i<x.Count-1; i++)
            {
                g.DrawLine(black, (float)x[i]+marW, -1*(float)y[i]+marH, (float)x[i + 1]+marW, -1*(float)y[i + 1]+marH);
            }
        }

        private void Coordinates()
        {
            g.Clear(Color.White);
            var black = new Pen(Color.Black, 2);
            g.DrawLine(black, 400, 0, 400, 450);
            g.DrawLine(black, 0, 225, 800, 225);
        }

        private void comboBox1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == "X")
            {
                Coordinates();
                var x = xes(-10, 10);
                var y = values(-10, 10, z => z);
                Graph(x, y, g);
                Update();
            }
            else if (comboBox1.SelectedItem.ToString() == "Sin")
            {
                Coordinates();
                var x = xes(Math.PI * (-1), Math.PI);
                var y = values(Math.PI * (-1), Math.PI, Math.Sin);
                Graph(x, y, g);
                Update(); 
            }
            else if (comboBox1.SelectedItem.ToString() == "Cos")
            {
                Coordinates();
                var x = xes(Math.PI * (-1), Math.PI);
                var y = values(Math.PI * (-1), Math.PI, Math.Cos);
                Graph(x, y, g);
                Update();
            }
            else if (comboBox1.SelectedItem.ToString() == "X^2")
            {
                Coordinates();
                var x = xes(-10, 10);
                var y = values(-10, 10, z => z * z);
                Graph(x, y, g);
                Update();
            }

        }
    }
}
