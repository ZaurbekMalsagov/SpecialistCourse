using System.Text;

namespace DAY02_DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputString = new StringBuilder();
            int resultNumber = 0;
            
            foreach (var arg in args) { 
                inputString.Append(arg);
                inputString.Append(' ');
                resultNumber+= Convert.ToInt32(arg);

            }
            Console.WriteLine($"Input data string = {inputString}");
            Console.WriteLine($"Result of adding input numbers = {resultNumber}");

            
        }
    }
}
