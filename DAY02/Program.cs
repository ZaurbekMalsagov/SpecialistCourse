using System.Diagnostics;

namespace DAY02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Лабораторная 1
            // RavenCounterLab1Mod3();


            // Лабораторная 2
            FibonachiNumbers();
        }

        // День 2, Модуль 3, Лабораторная 1 
        private static void RavenCounterLab1Mod3()
        {
            Console.Write("Введите число ворон на ветке: ");
            int inputNumber = int.Parse(Console.ReadLine());
            string resultString = "На ветке ";
            if (inputNumber % 100 > 10 && inputNumber % 100 < 15) resultString += $"{inputNumber} ворон";
            else 
                switch(inputNumber%10)
                {
                    case 1:
                        resultString += $"{inputNumber} ворона.";
                        break;
                    case int i when i > 1 && i < 5:
                        resultString += $"{inputNumber} вороны.";
                        break;
                    default:
                        resultString += $"{inputNumber} ворон.";
                        break;
                }

            

            Console.WriteLine(resultString);
        }

        // День 2, Модуль 3, Лабораторная 2
        private static void FibonachiNumbers()
        {
            int fiboNumber = 0, 
                previousNumber = 1, 
                temporaryNumber = fiboNumber;
            Console.WriteLine(fiboNumber + "\n" + previousNumber);

            while ( (fiboNumber = temporaryNumber+ previousNumber) < 1000)
            {
                temporaryNumber = previousNumber;
                previousNumber = fiboNumber;
                Console.WriteLine(fiboNumber);
            }
        }
    }
}
