using System;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, n, sum = 1;
            n = double.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                sum += 1 / i;
            }
            Console.WriteLine($"Сума = {sum} ");
        }
    }
}
