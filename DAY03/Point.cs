using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY03
{
    internal class Point : Shape
    {
        private int X { get; set; }
        private int Y { get; set; }

        public Point(int x, int y, string colour = "Black")
        {
            this.X = x;
            this.Y = y;
            Colour = colour;

        }

        public override void Draw()
        {
            Console.WriteLine($"This shape point ({X},{Y}) colour = {Colour}");
        }

        public override string ToString() => ($"This shape point ({X},{Y}) colour = {Colour}");

        public void MoveBy(int dx, int dy)
        {
            this.X += dx;
            this.Y += dy;
        }
    }
}
