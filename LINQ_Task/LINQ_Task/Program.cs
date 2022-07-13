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

            IEnumerable<int> numbers = Enumerable.Range(1, num);

            // Factorial
            foreach (int n in numbers)
            {
                Console.WriteLine($"{n}! = {numbers.SkipLast(num - n).Aggregate((x, y) => x * y)}");
            }
            Console.WriteLine();

            // Fibonacci
            foreach (int n in numbers)
            {
                int fibonacci = numbers.SkipLast(num - n + 1).Aggregate(
                    new { previous = 0, current = 1 }, (anonList, _) =>
                    new { previous = anonList.current, current = anonList.previous + anonList.current }
                ).current;
                Console.WriteLine($"The {n}-value of Fibonacci sequence is equal to {fibonacci}");
            }
        }
    }
}