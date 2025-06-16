/*
Calcular potência - Crie um método chamado Potencia que receba dois números inteiros (base e expoente)
e retorne o resultado da potência sem usar Math.Pow.
*/

using System;

public class Program
{
    static int Potencia(int x, int y)
    {
        int result = 1;
        //caso o expoente seja 0 o resultado será 1;
        if (y == 0)
        {
            return result;
        }
        else
        {
            for (int i = 1; i <= y; i++)
            {
                //int i recebe um como valor incial;
                //enquanto ele for menor que o expoente, ele é incrementado;
                result *= x;
                //O resultado se dá pela base se multiplicando até chegar ao nº do expoente; 
            }
            return result;
        }
    }

    public static void Main()
    {
        Console.WriteLine("--Calculadora de Potência--");

        Console.Write("\nDiga um número para ser a base da potencia:");
        int numbase = int.Parse(Console.ReadLine());
        Console.Write("Diga um número para ser o expoente da potencia:");
        int numexpo = int.Parse(Console.ReadLine());

        Console.WriteLine(Potencia(numbase, numexpo));
    }
}