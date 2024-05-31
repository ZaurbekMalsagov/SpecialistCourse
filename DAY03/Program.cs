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

        }
    }
}
