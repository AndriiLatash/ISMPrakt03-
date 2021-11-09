using System;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {


            int n, sum = 0, factorial = 1;
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
                sum += factorial;
            }
            Console.WriteLine($"sum = {factorial}");
        }
    }
}
