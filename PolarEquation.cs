
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MoveByEquationForms
{
    public class PolarEquation : Equation
    {
        Func<double, PointF> equation;

        public PolarEquation(string name, Func<double, PointF> equation) : base(name)
        {
            this.equation = equation;
        }

        public override PointF coordinateAtT(double t)
        {
            return equation(t);
        }
    }
}
