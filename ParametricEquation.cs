
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MoveByEquationForms
{
    class ParametricEquation : Equation
    {
        Func<double, double> xEquation;
        Func<double, double> yEquation;
        public ParametricEquation(string name, Func<double, double> xEquation, Func<double, double> yEquation) : base(name)
        {
            this.xEquation = xEquation;
            this.yEquation = yEquation;
        }

        public override PointF coordinateAtT(double t)
        {
            return new PointF((float)xEquation(t), -(float)yEquation(t));
        }

    }
}
