using System;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = 1, n, b;
            n = double.Parse(Console.ReadLine());
            b = 1;
            while (b < n)
            {
                b = Math.Pow(3, k);
                k++;

            }
            Console.WriteLine($"k = {k}");
        }
    }
}