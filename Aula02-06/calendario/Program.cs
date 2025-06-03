//Faça um programa que leia um número inteiro de 1 a 12 e, utilizando switch case, exiba o nome correspondente ao mês. Se o número não for correspondente ao mês escreva: "Inválido"
//✔️ Regras:
//1 → Janeiro   2 → Fevereiro
//3 → Março		4 → Abril
//5 → Maio	    6 → Junho
//7 → Julho	   8 → Agosto
//9 → Setembro	10 → Outubro
//11 → Novembro 12 → Dezembro

using System;


namespace calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe um número do mês: \n  1 → Janeiro   2 → Fevereiro\r\n  3 → Março\t4 → Abril\r\n  5 → Maio\t6 → Junho\r\n  7 → Julho\t8 → Agosto\r\n  9 → Setembro\t10 → Outubro\r\n  11 → Novembro 12 → Dezembro");
            int mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break;
                default:
                    Console.WriteLine("Número de mês inválido!");
                    break;
            }
        }
    }
}
