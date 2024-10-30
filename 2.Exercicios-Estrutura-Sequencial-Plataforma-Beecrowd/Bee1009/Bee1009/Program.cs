using System;
using System.Globalization;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double totalDeVendas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double salarioBruto = totalDeVendas * 15.0 / 100.0 + salarioFixo;

            Console.WriteLine($"TOTAL = R$ {salarioBruto.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}