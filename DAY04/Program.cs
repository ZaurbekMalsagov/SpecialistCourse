using System.Reflection;

namespace DAY04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateAndKillClass();
            // Type? stringType = Type.GetType("System.String");
            Type? stringInfo = typeof(string).GetTypeInfo();
            foreach (var typeInfo in stringInfo.GetMethods())
            {
                Console.WriteLine(typeInfo.Name);
            }
            Console.WriteLine(stringInfo.Name);
            
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }

        static void CreateAndKillClass()
        {
            DeadClass dead = new DeadClass();
        }

       
        
    }

    class DeadClass
    {
        public DeadClass()
        {
            Console.WriteLine("Я родился");
        }

        ~DeadClass()
        {
            Console.WriteLine("Меня дезинтегрировали");
        }
    }
}
