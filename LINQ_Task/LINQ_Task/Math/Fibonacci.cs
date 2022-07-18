using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Task.Math
{
    internal static class Fibonacci
    {
        public static void PrintFibonacci(int num)
        {
            IEnumerable<int> numbers = Enumerable.Range(1, num);
            foreach (int n in numbers)
            {
                int fibonacci = numbers.SkipLast(num - n + 1).Aggregate(
                    new { previous = 0, current = 1 }, (anonList, _) =>
                    new { previous = anonList.current, current = anonList.previous + anonList.current }
                ).current;
                Console.WriteLine($"The {n}-value of Fibonacci sequence is equal to {fibonacci}");
            }
            Console.WriteLine();
        }
    }
}
