using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Task.Math
{
    internal static class Factorial
    {
        public static void PrintFactorial(int num)
        {
            IEnumerable<int> numbers = Enumerable.Range(1, num);
            foreach (int n in numbers)
            {
                Console.WriteLine($"{n}! = {numbers.SkipLast(num - n).Aggregate((x, y) => x * y)}");
            }
            Console.WriteLine();
        }
    }
}
