using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveByEquationForms
{
    public partial class Form1 : Form
    {
        List<Equation> equations;
        Grapher graph;
        float timestep;

        public Form1()
        {
            InitializeComponent();


            equations = new List<Equation>()
            {
                new PolarEquation("Circle", theta => PolarToCartisianVector(1, theta)),
                new PolarEquation("Cardioid", (theta) => PolarToCartisianVector(1 + Math.Sin(theta), theta)),
                new PolarEquation("Four Petal", (theta) => PolarToCartisianVector(Math.Sin(2 * theta), theta)),
                new PolarEquation("Eight Petal", (theta) => PolarToCartisianVector(Math.Sin(4 * theta), theta)),
                new PolarEquation("Limacon", (theta) => PolarToCartisianVector(1 - 2 * Math.Cos(theta), theta)),
                new PolarEquation("Spiral", (theta) => PolarToCartisianVector(theta/3, theta)),
                new PolarEquation("Moth", (theta) => PolarToCartisianVector(Math.Cos(theta/2), theta)),
                new ParametricEquation("Parametric Square", t => Math.Pow(Math.Cos(t), 3), t => Math.Pow(Math.Sin(t), 3)),
                new PolarEquation("Polar Butterfly", t => PolarToCartisianVector(Math.Pow(Math.E, Math.Sin(t)) - 2 * Math.Cos(4 * t) + Math.Pow(Math.Sin((2 * t - Math.PI)/24), 5), t)),
                new ParametricEquation("Parametric Butterfly", t => Math.Sin(t) * (Math.Pow(Math.E, Math.Cos(t)) - 2 * Math.Cos(4 * t) - Math.Pow(Math.Sin(t/12), 5)),
                    t => Math.Cos(t) * (Math.Pow(Math.E, Math.Cos(t)) - 2 * Math.Cos(4 * t) - Math.Pow(Math.Sin(t/12), 5))),
                new ParametricEquation("Test", t => Math.Pow(t, 3) - 3 * t, t => 3 * t * t - 9)
            };

            functionComboBox.Items.AddRange(equations.ToArray());
            functionComboBox.DisplayMember = "Name";

            graph = new Grapher(graphPictureBox, 10, 10, equations[2], 0.1f);
            timestep = 0.5f;
            graph.Draw();
        }

        public PointF PolarToCartisianVector(double r, double theta)
        {
            float x = (float)(r * Math.Cos(theta));
            float y = -(float)(r * Math.Sin(theta));
            return new PointF(x, y);
        }

        private void timerT_Tick(object sender, EventArgs e)
        {
            graph.Update(timestep);
            graph.Draw();
        }

        private void timeTrackBar_Scroll(object sender, EventArgs e)
        {
            timestep = timeTrackBar.Value / 10f + 0.1f;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            graph.StartFunction();
        }

        private void functionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            graph.UpdateEquation(equations[functionComboBox.SelectedIndex]);
        }
    }
}
