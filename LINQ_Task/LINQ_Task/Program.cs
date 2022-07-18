using LINQ_Task.Math;

namespace LINQ_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num <= 0)
            {
                Console.Write("Input the number: ");
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Input is not valid for int data type. \nTry again!");
                    if (num <= 0)
                        Console.WriteLine("Input value must be more than zero. \nTry again!");
                }
            }
            Console.WriteLine();
            Factorial.PrintFactorial(num);
            Fibonacci.PrintFibonacci(num);
        }
    }
}