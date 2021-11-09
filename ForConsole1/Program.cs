using System;

namespace ISMPrakt03
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 1, i, A, B;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            for (i = A; i <= B; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine($"Сумма чисел {sum}");
        }
        }
                    
            }

        
