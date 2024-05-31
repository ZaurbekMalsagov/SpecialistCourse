using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY03
{
    internal class Circle : Shape
    {
        private int X { get; set; }
        private int Y { get; set; }
        private double Scale { get; set; }
        private double Radius {  get; set; }

        public Circle(int x, int y, double radius, int scale = 1, string colour = "Black")
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius * scale;
            this.Scale = scale;
            this.Colour = colour;

        }

        public override void Draw() =>  Console.WriteLine($"This circle point ({X},{Y}), radius = {Radius}, colour = {Colour} and Scale = {Scale}");

        public override string ToString() => $"This circle point ({X},{Y}), radius = {Radius}, colour = {Colour} and Scale = {Scale}";

        public void MoveBy(int dx, int dy)
        {
            this.X += dx;
            this.Y += dy;
        }

        public void AddScale(double factor)
        {
            Scale = factor;
            this.Radius *= factor;
        }
    }
}
