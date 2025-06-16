using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerMetodo5
{
    internal class Program
    {
        static long Fatorial(int x)
        {
            long result = 1;
            if (x <= 1)
            {
                return result;
            }
            else
            {

                for (int i = x; i > 1; i--)
                {
                    result *= i;
                }
                return result;
            }
        }

        public static void Main()
        {
            Console.Write("Diga um número para descobrir seu fatorial: ");
            int num = int.Parse(Console.ReadLine());


            Console.WriteLine($"{num}! = " + Fatorial(num));
        }
    }
}
