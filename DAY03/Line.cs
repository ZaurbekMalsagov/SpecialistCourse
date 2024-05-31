using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DAY03
{
    internal class Line : Shape
    {
        private int X1 { get; set; }
        private int Y1 { get; set; }
        private int X2 { get; set; }
        private int Y2 { get; set; }


        public Line(int x1 = 0, int y1 =0, int x2 = 0, int y2 = 0, string colour = defaultColour) : base (colour)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
        }

        public override void Draw() => Console.WriteLine($"This Line points ({X1},{Y1},{X2},{Y2}), colour = {Colour}");

        public override string ToString() => $"This Line points ({X1},{Y1},{X2},{Y2}), colour = {Colour}";

        public void MoveBy(int dx, int dy)
        {
            this.X2 += dx;
            this.Y2 += dy;
        }

        public void Scale(double factor)
        {
            X2 = (int)Math.Round((X2 - X1) * factor) + X1;
            Y2 = (int)Math.Round((Y2 - Y1) * factor) + Y1;
        }
    }
}
