using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerMetodo2
{
    internal class Program
    {
        static double Maior(double x, double y)
        {
            return (x > y) ? x : y;

        }
        public static void Main()
        {
            double num1, num2;

            Console.WriteLine("Insira 2 números: ");

            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());

            Console.Write("O maior número é: "+Maior(num1, num2));
        }
    }
}
