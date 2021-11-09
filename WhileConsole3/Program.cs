using System;

namespace WhileConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, a = 0, s, b = 1;
            p = int.Parse(Console.ReadLine());
            s = p / 10;
            while (a < 200)
            {
                a += 10 + s;
                b++; 
            }
            Console.WriteLine($" дней: {b}   расстояние : {a}    ");
        }
       
    }
}
