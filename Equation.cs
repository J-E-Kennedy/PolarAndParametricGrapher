
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MoveByEquationForms
{
    public abstract class Equation
    {
        public string Name { get; private set; }

        public Equation(string name)
        {
            Name = name;
        }
        public abstract PointF coordinateAtT(double t);
    }
}
