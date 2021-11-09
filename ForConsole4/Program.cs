using System;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, i, A, B;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            for (i = A; i <= B; i++)
            {
                sum += Math.Pow(i, 2);
            }
            Console.WriteLine($"Сумма чисел {sum}");
        }
    }
}
