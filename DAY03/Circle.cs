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
        private double _radius;

        private double Radius {
            get => _radius;
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    throw new ArgumentException("radius <= 0");
                }
            }
        }

        public Circle(int x, int y, double radius, string colour = defaultColour) : base(colour)
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius;

        }

        public override void Draw() => Console.WriteLine($"This circle point ({X},{Y}), radius = {Radius}, colour = {Colour}");

        public override string ToString() => $"This circle point ({X},{Y}), radius = {Radius}, colour = {Colour}";

        public void MoveBy(int dx, int dy)
        {
            this.X += dx;
            this.Y += dy;
        }

        public void Scale (double factor){
            Radius = (int) Math.Round(factor* Radius);
        }
    }
}
