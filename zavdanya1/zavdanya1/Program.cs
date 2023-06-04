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

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                    fibonacciNumber = a + b;
                    a = b;
                    b = fibonacciNumber;
                }
            }

            Console.ReadLine();
        }
    }
}
