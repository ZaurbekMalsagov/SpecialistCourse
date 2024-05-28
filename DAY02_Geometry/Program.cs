using System;

namespace Geometry
{
    enum Figures { Romb, Rect, RightTriangle, Circle }
    struct Fdata
    {
        public int x0, y0;
        public double a, b;
        public int color;
        public Figures type;
    }
    class Program
    {

        static void Main(string[] args)
        {
            //Fdata fd = new Fdata() { a = 4, b = 3, type = Figures.Romb };
            //Console.WriteLine(area(fd));
            Console.WriteLine("Ok");
        }

        private static double CalculateSquare(Fdata fd)
        {
            double square = 0;
            switch (fd.type)
            {
                case Figures.Romb:
                    square = 0.5 * fd.a *fd.b;
                    break;
                case Figures.Rect:
                    square = fd.a * fd.b;
                    break;
                case Figures.RightTriangle:
                    square = (fd.a * fd.b)/2;
                    break;
                case Figures.Circle:
                    square = Math.PI * Math.Pow(fd.a,2);
                    break;
            }

            return square;
        }
    }
}
