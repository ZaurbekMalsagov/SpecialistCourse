namespace DAY03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Point p1 = new Point(1, 2);
            p1.Draw();
            p1.MoveBy(1, 2);
            Console.WriteLine(p1.ToString());
            shapes.Add(p1);

            Circle c1 = new Circle(1, 1, 5);
            c1.Draw();
            c1.MoveBy(1, 2);
            c1.Scale(3);
            Console.WriteLine(c1.ToString());
            shapes.Add(c1);


            Line l1 = new Line(1, 2, 3, 4);
            l1.Draw();
            l1.MoveBy(1, 2);
            l1.Scale(3);
            Console.WriteLine(l1.ToString());
            shapes.Add(l1);

            Console.WriteLine("Than task 2");
            foreach (Shape shape in shapes) { 
                shape.Draw();
            }
            
        }
    }
}
