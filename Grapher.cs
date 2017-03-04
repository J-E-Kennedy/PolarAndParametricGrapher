using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveByEquationForms
{
    class Grapher
    {
        public float CurrentT { get; private set; }
        public bool CurveDraw { private get; set; }
        public float Scale { get; set; }
        public int TrailLength { get; set; }

        PictureBox pictureBox;
        Bitmap bitmap;
        Graphics gfx;
        int xUnits;
        int yUnits;
        List<PointF> drawnCurve;
        Equation activeEquation;
        public Grapher(PictureBox pictureBox, int xUnits, int yUnits, Equation activeEquation, int trailLength = 100, float scale = 1, float currentT = 0)
        {
            this.pictureBox = pictureBox;
            this.xUnits = xUnits;
            this.yUnits = yUnits;
            CurrentT = currentT;
            TrailLength = trailLength;
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            gfx = Graphics.FromImage(bitmap);
            this.activeEquation = activeEquation;
            CurveDraw = true;
            Scale = scale;
            DrawGrid();
            StartFunction();
        }

        public void Update(float timestep)
        {
            UpdateFunction(activeEquation);
            CurrentT += timestep;
        }

        public void Draw()
        {
            gfx.Clear(Color.White);
            DrawGrid();
            DrawFunction();
            pictureBox.Image = bitmap;
        }

        void DrawGrid()
        {
            float xSpacing = (float)pictureBox.Width / xUnits;
            float ySpacing = (float)pictureBox.Height / yUnits;
            for (int i = 1; i < xUnits; i++)
            {
                gfx.DrawLine(new Pen(Color.LightGray, 2), new PointF(i * xSpacing, 0), new PointF(i * xSpacing, pictureBox.Height));
            }
            for (int i = 1; i < xUnits; i++)
            {
                gfx.DrawLine(new Pen(Color.LightGray, 2), new PointF(0, i * ySpacing), new PointF(pictureBox.Width,  i * ySpacing));
            }
            gfx.DrawLine(new Pen(Color.Gray, 2), new PointF(xUnits / 2 * xSpacing, 0), new PointF(xUnits / 2 * xSpacing, pictureBox.Height));
            gfx.DrawLine(new Pen(Color.Gray, 2), new PointF(0, yUnits / 2 * ySpacing), new PointF(pictureBox.Width, yUnits / 2 * ySpacing));
        }

        public void StartFunction()
        {
            drawnCurve = new List<PointF>();
            CurrentT = 0;
        }

        void UpdateFunction(Equation e)
        {
            drawnCurve.Add(e.coordinateAtT(CurrentT));
            if(drawnCurve.Count > TrailLength)
            {
                drawnCurve.RemoveAt(0);
            }
        }
        void DrawFunction()
        {
            float xSpacing = (float)pictureBox.Width / xUnits;
            float ySpacing = (float)pictureBox.Height / yUnits;
            float xCenter = xUnits / 2 * xSpacing;
            float yCenter = yUnits / 2 * ySpacing;
            PointF[] scaledCurve = drawnCurve.Select(x => new PointF(Scale * x.X * xSpacing + xCenter, Scale * x.Y * ySpacing + yCenter)).ToArray();


            if(scaledCurve.Length > 1)
            {
                if(CurveDraw)
                {
                    gfx.DrawCurve(Pens.Red, scaledCurve);
                }
                else
                {
                    gfx.DrawLines(Pens.Red, scaledCurve);
                }
            }
            if (scaledCurve.Length > 0)
            {
                gfx.DrawEllipse(new Pen(Color.Blue, 5), scaledCurve[scaledCurve.Length - 1].X, scaledCurve[scaledCurve.Length - 1].Y, 1, 1);
            }
        }
        public void UpdateEquation(Equation e)
        {
            activeEquation = e;
            StartFunction();
        }
    }
}
