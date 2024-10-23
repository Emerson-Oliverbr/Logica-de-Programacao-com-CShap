using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double resultado;

            a = 5;
            b = 2;
            System.Console.WriteLine();
            double x = 5.4;
            int y = (int) x;

            resultado = (double) a / b;

            System.Console.WriteLine(resultado.ToString("F1",CultureInfo.InvariantCulture));
            System.Console.WriteLine(y);
        }
    }
}