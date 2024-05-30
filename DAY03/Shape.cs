using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY03
{
    public abstract class Shape
    {
        private string Colour {  get; set; }
        private int X {  get; set; }
        private int Y { get; set; }

        public Shape(int x, int y, string colour = "BLACK") { 
            this.X = x; 
            this.Y = y; 
            Colour = colour;
        }

        public abstract void Draw();
    }
}
