/*
Converter Celsius para Fahrenheit -Crie um método chamado ConverterParaFahrenheit
que receba uma temperatura em Celsius e retorne o valor correspondente em Fahrenheit.
Fórmula: F = C * 1.8 + 32
*/
using System;

public class Program
{
    static double ConverterParaFahrenheit(double x)
    {
        double f = (x * 1.8) + 32;
        return f;
    }
    public static void Main()
    {
        Console.Write("Digite a temperatura desejada em Celsius para  ");
        double num = double.Parse(Console.ReadLine());

        double f = ConverterParaFahrenheit(num);

        Console.WriteLine(num + "°C em farenheit são " + f + "°F.");


    }
}