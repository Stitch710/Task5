using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int lim = 1000;
            for (int i = 0; i < lim; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
