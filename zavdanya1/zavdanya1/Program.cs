using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdanya1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 40;

            Console.WriteLine("Перші {0} чисел Фібоначчі:", n);

            long a = 0;
            long b = 1;
            long fibonacciNumber;

            Console.WriteLine(a);

            for (int i = 2; i <= n; i++)
            {
                fibonacciNumber = a + b;
                Console.WriteLine(fibonacciNumber);

                a = b;
                b = fibonacciNumber;
            }
            Console.ReadLine();
        }
    }
}
