using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fnTuple = System.Tuple<double, System.Func<double, double>>;

namespace MoveByEquationForms
{
    class PiecewiseParametricEquation : Equation
    {
        List<fnTuple> functionSetX;
        List<fnTuple> functionSetY;
        public PiecewiseParametricEquation(string name, List<fnTuple> functionSetX,
            List<Tuple<double, Func<double, double>>> functionSetY) : base(name)
        {
            this.functionSetX = functionSetX;
            this.functionSetY = functionSetY;
        }

        public override PointF coordinateAtT(double t)
        {
            return new PointF((float)functionSetX.Last(x => x.Item1 <= t).Item2(t), 
                -(float)functionSetY.Last(y => y.Item1 <= t).Item2(t));
        }
    }
}
