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
    public partial class moveBoxEquationForm : Form
    {
        List<Equation> equations;
        Grapher graph;
        float timestep;
        float time;
        public moveBoxEquationForm()
        {
            InitializeComponent();


            equations = new List<Equation>()
            {
                new PolarEquation("Circle", theta => PolarToCartisianVector(1, theta)),
                new PolarEquation("Cardioid", (theta) => PolarToCartisianVector(1 + Math.Sin(theta), theta)),
                new PolarEquation("Four Petal", (theta) => PolarToCartisianVector(Math.Sin(2 * theta), theta)),
                //new PolarEquation("Eight Petal", (theta) => PolarToCartisianVector(Math.Sin(4 * theta), theta)),
                new PolarEquation("Limacon", (theta) => PolarToCartisianVector(1 - 2 * Math.Cos(theta), theta)),
                new PolarEquation("Spiral", (theta) => PolarToCartisianVector(theta/3, theta)),
                new PolarEquation("Moth", (theta) => PolarToCartisianVector(Math.Cos(theta/2), theta)),
                new ParametricEquation("Parametric Square", t => Math.Pow(Math.Cos(t), 3), t => Math.Pow(Math.Sin(t), 3)),
                new PolarEquation("Butterfly", t => PolarToCartisianVector(Math.Pow(Math.E, Math.Sin(t)) - 2 * Math.Cos(4 * t) + Math.Pow(Math.Sin((2 * t - Math.PI)/24), 5), t)),
                //new ParametricEquation("Parametric Butterfly", t => Math.Sin(t) * (Math.Pow(Math.E, Math.Cos(t)) - 2 * Math.Cos(4 * t) - Math.Pow(Math.Sin(t/12), 5)),
                //    t => Math.Cos(t) * (Math.Pow(Math.E, Math.Cos(t)) - 2 * Math.Cos(4 * t) - Math.Pow(Math.Sin(t/12), 5))),
                new ParametricEquation("Lissajous Curve", t => Math.Cos(3 * t), t => Math.Sin(2 * t)),
                new ParametricEquation("Circle", t => -Math.Sin(t), t => Math.Cos(t)),

                new PiecewiseParametricEquation("Piecewise Test", new List<Tuple<double, Func<double, double>>>()
                {
                    new Tuple<double, Func<double, double>>(0, x => Math.Sin(x) * x / Math.PI / 2 - 2),
                    new Tuple<double, Func<double, double>>(Math.PI * 4, x => -Math.PI * 4 - 2 + x ),
                    new Tuple<double, Func<double, double>>(Math.PI * 4 + 4, x => -Math.Sin(Math.PI * 8 + 4 - x) *
                    (Math.PI * 8 + 4 - x) / Math.PI / 2 + 2),
                    new Tuple<double, Func<double, double>>(Math.PI * 8 + 4, x => Math.Cos((x - 4) / 4) * 2),
                    new Tuple<double, Func<double, double>>(Math.PI * 12 + 4, x => -2)
                },
                new List<Tuple<double, Func<double, double>>>()
                {
                    new Tuple<double, Func<double, double>>(0, y => -Math.Cos(y) * y / Math.PI / 2),
                    new Tuple<double, Func<double, double>>(Math.PI * 4, y => -2),
                    new Tuple<double, Func<double, double>>(Math.PI * 4 + 4, y => -Math.Cos(Math.PI * 8 + 4 - y) *
                    (Math.PI * 8 + 4 - y) / Math.PI / 2),
                    new Tuple<double, Func<double, double>>(Math.PI * 8 + 4, y => Math.Sin((y - 4) / 4) * 1.5),
                    new Tuple<double, Func<double, double>>(Math.PI * 12 + 4, y => 0) //(Math.PI * 12 + 4) - y)
                }
                )


                //new ParametricEquation("Hypotrochoid Star", t => 2 * Math.Cos(t) + 5 * Math.Cos(2/))
            };

            functionComboBox.Items.AddRange(equations.ToArray());
            functionComboBox.DisplayMember = "Name";
            graph = new Grapher(graphPictureBox, 10, 10, equations[2], 100, 1, 0.1f);
            functionComboBox.SelectedIndex = 0;
            timestep = 0.1f;
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
            elaspedTimeLabel.Text = "Elapsed Time: " + Math.Round(time, 3);
            currentTLabel.Text = "Current T: " + Math.Round(graph.CurrentT, 3);
            time += timerT.Interval / 1000f;
            graph.Update(timestep);
            graph.Draw();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            graph.StartFunction();
            time = 0;
        }

        private void functionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            graph.UpdateEquation(equations[functionComboBox.SelectedIndex]);
            time = 0;
        }

        private void tTimeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && sender is TextBox)
            {
                setValidFloatInput(sender as TextBox, out timestep);
            }
        }

        private void tickTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                float newTicks = 0;
                if (setValidFloatInput(tickTextBox, out newTicks))
                {
                    timerT.Interval = (int)(newTicks * 1000);
                }
            }
        }

        bool setValidFloatInput(TextBox sender, out float value)
        {
            if (!float.TryParse(sender.Text, out value))
            {
                sender.Text = "Invalid Input!";
                return false;
            }
            return true;
        }

        private void curveRadio_CheckedChanged(object sender, EventArgs e)
        {
            graph.CurveDraw = curveRadio.Checked;
        }

        private void lineRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            timerT.Enabled = !timerT.Enabled;
            pauseButton.Text = timerT.Enabled ? "Pause" : "Start";
        }

        private void scaleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            float scale = 1;
            if (e.KeyCode == Keys.Enter)
            {
                if (setValidFloatInput(scaleTextBox, out scale))
                {
                    graph.Scale = scale;
                }
            }
        }

        private void defineNewButton_Click(object sender, EventArgs e)
        {
            AddEquationForm addForm = new AddEquationForm();
            addForm.ShowDialog();
            if (addForm.Success)
            {
                equations.Add(addForm.ToCreate);
                functionComboBox.Items.Clear();
                functionComboBox.Items.AddRange(equations.ToArray());
            }
        }

        private void trailLengthTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            float length = 100;
            if (e.KeyCode == Keys.Enter)
            {
                if (setValidFloatInput(trailLengthTextBox, out length))
                {
                    graph.TrailLength = (int)length;
                }
            }
        }
    }
}
