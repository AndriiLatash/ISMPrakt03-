using System;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = 1, n, b = 1, a = 0, r;
            n = double.Parse(Console.ReadLine());
            r = n;
            b = 1;
            while (b <= n)
            {
               
                a += Math.Pow(b, r - k);
                k++;
                b++;

            }
            Console.WriteLine($"sum = {a}");
        }
    }
}