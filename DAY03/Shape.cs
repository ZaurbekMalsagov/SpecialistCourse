using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY03
{
    public abstract class Shape
    {
        private const string defaultColour = "BLACK";
        protected string Colour {  get; set; }

        public Shape(string colour = defaultColour) { 

            this.Colour = colour;
        }

        public abstract void Draw();
        
    }
}
