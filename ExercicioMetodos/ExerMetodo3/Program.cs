using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerMetodo3
{
    internal class Program
    {
        static bool EhPar(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main()
        {
            Console.Write("Digite um número para saber se é par: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(EhPar(num));


        }
    }
}
