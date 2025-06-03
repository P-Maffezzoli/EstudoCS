// Crie um programa que leia dois números e um operador matemático (+, -, *, /). O programa deve usar o comando switch case para realizar a operação escolhida e mostrar o resultado na tela.
// Regras:
// Se o operador for:
// + → soma
// - → subtração
// * → multiplicação
// / → divisão(verificar se o segundo número não é zero)
// Se for digitado um operador inválido, exiba a mensagem: "Operador inválido."

using System;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)          
        {                                        
            Console.Write("Informe 1º número:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("selecione uma operação: \n Adição(+)\n Subtração(-)\n Divisão(/)\n Multiplicação(*)");
            char op= char.Parse(Console.ReadLine());
            Console.Write("Informe 2º número:");
            double num2 = double.Parse(Console.ReadLine());

            switch(op)
            {
                case '+':
                    Console.WriteLine("O resultado é: "+ num1 + num2);
                    break;
                case '-':
                    Console.WriteLine("O resultado é: "+ (num1 - num2));
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("ERRO! Impóssivel dividir por 0.");
                    }
                    else { Console.WriteLine("O resultado é: " + num1 / num2);}
                    break;
                case '*':
                    Console.WriteLine("O resultado é: " + num1 * num2);
                    break;
                default:
                    Console.WriteLine("Operação Inválida! Tente Novamente.");
                    break;
                
                    
            }

        }
    }
}
