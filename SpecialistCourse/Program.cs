namespace DAY01
{
    internal class Program
    {
        enum Figures { Triangle, Rectangle, Circle}

        struct FiguresData
        {
            public int x, y;
            public string colour;
            public Figures ftype;

        }
        static void Main(string[] args)
        {
            // MOD1
            // Console.WriteLine("Hello, Specialist Course!");

            // MOD2
            FiguresData figuresData = new FiguresData();
            figuresData.ftype = Figures.Rectangle;
            figuresData.x = 23;
            figuresData.y = figuresData.x;
            figuresData.colour = "red";

            Console.WriteLine($"Figures type = {figuresData.ftype};\n" +
                              $"Figures colour = {figuresData.colour};\n" +
                              $"Figures coordinate = ({figuresData.x},{figuresData.y})");

            Console.ReadLine();

        }

    }
    
}
