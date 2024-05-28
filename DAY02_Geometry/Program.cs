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
            Fdata fd = new Fdata() { a = 4, b = 3, type = Figures.Romb };
            Console.WriteLine(AreaNew(fd));
            Console.WriteLine("Ok");
        }

        private static double Area(Fdata fd)
        {
            double area = 0;
            switch (fd.type)
            {
                case Figures.Romb:
                    area = 0.5 * fd.a *fd.b;
                    break;
                case Figures.Rect:
                    area = fd.a * fd.b;
                    break;
                case Figures.RightTriangle:
                    area = (fd.a * fd.b)/2;
                    break;
                case Figures.Circle:
                    area = Math.PI * Math.Pow(fd.a,2);
                    break;
            }

            return area;
        }

        private static double AreaNew(Fdata fd) => fd.type switch
        {
            Figures.Romb            => 0.5 * fd.a * fd.b,

            Figures.Rect            => fd.a * fd.b,
            Figures.RightTriangle   => (fd.a * fd.b) / 2,
            Figures.Circle          => Math.PI * Math.Pow(fd.a, 2),
            _                       => 0
        };

         
    }
}
