using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY03_Geometry
{
    internal class Circle
    {
        private int X { get; set; }
        private int Y { get; set; }
        private double _radius;
        private double Radius {
            get => _radius;
            set
            {
                if (value > 0) _radius = value;
                else throw new ArgumentException("Radius <=0");
            }
        }


        public Circle(int x, int y, double radius) {
            this.X = x;
            this.Y = y;
            this.Radius = radius;
        }

        public double Area() => Math.PI * Math.Pow(Radius, 2);

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public void PrintInfo() =>  Console.WriteLine($"Circle ({X},{Y}) with radius = {Radius} ");
        
    }
}
