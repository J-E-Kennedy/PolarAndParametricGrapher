using NCalc;
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
    public partial class AddEquationForm : Form
    {
        public bool Success;
        public Equation ToCreate;
        public AddEquationForm()
        {
            InitializeComponent();
            polarRadio.Checked = true;
        }

        private void polarRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(polarRadio.Checked)
            {
                secondFunctionLabel.Visible = false;
                secondFunctionTextBox.Visible = false;
                firstFunctionLabel.Text = "f(t) = ";
            }
            else
            {
                secondFunctionTextBox.Visible = true;
                secondFunctionLabel.Visible = true;
                firstFunctionLabel.Text = "x = ";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Expression newFunction;
            string response = firstFunctionTextBox.Text.ToLower();
            response.Replace("t", "[t]");
            response.Replace("pi", "[pi]");
            newFunction = new Expression(response, EvaluateOptions.IgnoreCase);
            newFunction.Parameters["Pi"] = Math.PI;
            if (polarRadio.Checked)
            {
                Func<double, PointF> polar = t => 
                {
                    newFunction.Parameters["t"] = t;
                    var hi = Convert.ToDouble(newFunction.Evaluate());
                    return PolarToCartisianVector(hi, t);
                };
                ToCreate = new PolarEquation(nameTextBox.Text, polar);
            }
            else
            {
                Expression yFunction;
                string yResponse = secondFunctionTextBox.Text.ToLower();
                yResponse.Replace("t", "[t]");
                yResponse.Replace("pi", "[pi]");
                yFunction = new Expression(yResponse, EvaluateOptions.IgnoreCase);
                yFunction.Parameters["pi"] = Math.PI;
                
                Func<double, double> parametricX = t =>
                {
                    newFunction.Parameters["t"] = t;
                    return Convert.ToDouble(newFunction.Evaluate());
                };
                Func<double, double> parametricY = t =>
                {
                    yFunction.Parameters["t"] = t;
                    return Convert.ToDouble(yFunction.Evaluate());
                };
                ToCreate = new ParametricEquation(nameTextBox.Text, parametricX, parametricY);
            }
            Success = true;
            Close();
        }

        public PointF PolarToCartisianVector(double r, double theta)
        {
            float x = (float)(r * Math.Cos(theta));
            float y = -(float)(r * Math.Sin(theta));
            return new PointF(x, y);
        }
    }
}
