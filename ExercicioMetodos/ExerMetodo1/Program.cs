using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerMetodo1
{
    internal class Program
    {
        static int Media(int x, int y, int z)
        {
            int media = (x + y + z) / 3;
            return media;
        }
        public static void Main()
        {
            int num1, num2, num3;

            Console.WriteLine("digite 3 números: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            int result = Media(num1, num2, num3);
            Console.WriteLine("A média é: " + result);
        }
    }
}
