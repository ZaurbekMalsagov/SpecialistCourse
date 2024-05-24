namespace DAY01
{
    internal class Program
    {
        enum Figures { Triangle, Rectangle, Circle}

        struct FiguresData
        {
            public int X, Y;
            public string Colour;
            public Figures FType;

        }
        static void Main(string[] args)
        {
            // MOD1
            // Console.WriteLine("Hello, Specialist Course!");

            // MOD2
            FiguresData figuresData = new FiguresData();
            figuresData.FType = Figures.Rectangle;
            figuresData.X = 23;
            figuresData.Y = figuresData.X;
            figuresData.Colour = "red";

            Console.WriteLine($"Figures type = {figuresData.FType};\n" +
                              $"Figures colour = {figuresData.Colour};\n" +
                              $"Figures coordinate = ({figuresData.X},{figuresData.Y})");

            Console.ReadLine();

        }

    }
    
}
