using System;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0, c;
            Console.WriteLine("Для завершення програми введіть 0");
            do
            {
                a = int.Parse(Console.ReadLine());
                b += a;
            } while (a != 0);
            Console.WriteLine($"sum = {b} ");

        }
    }
}
