using Tyuiu.EvseevEI.Sprint0.Task5.V0.Lib;
namespace Tyuiu.EvseevEI.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A+B=" + DataService.Addition(1, 5));
            Console.WriteLine("A-B=" + DataService.Subtraction(15, 5));
            Console.WriteLine("A*B=" + DataService.Multiplications(10, 10));
            Console.WriteLine("A/B=" + DataService.Division(5, 5));
            Console.ReadKey();
        }
    }
}
