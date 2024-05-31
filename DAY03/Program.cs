namespace DAY03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2);
            p1.Draw();
            p1.MoveBy(1, 2);
            Console.WriteLine(p1.ToString());

            Circle c1 = new Circle(1, 1, 5);
            c1.Draw();
            c1.MoveBy(1, 2);
            c1.AddScale(3);
            Console.WriteLine(c1.ToString());

        }
    }
}
