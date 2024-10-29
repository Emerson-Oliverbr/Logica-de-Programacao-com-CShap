using System;
using System.Globalization;

namespace Bee1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dadosDasPecas = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(dadosDasPecas[0]);
            int quantidadeDePecas1 = int.Parse(dadosDasPecas[1]);
            double valorDaPeca1 = double.Parse(dadosDasPecas[2],CultureInfo.InvariantCulture);            
            dadosDasPecas = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(dadosDasPecas[0]);
            int quantidadeDePecas2 = int.Parse(dadosDasPecas[1]);
            double valorDaPeca2 = double.Parse(dadosDasPecas[2],CultureInfo.InvariantCulture);

            double totalAPagar = (quantidadeDePecas1 * valorDaPeca1) + (quantidadeDePecas2 * valorDaPeca2);

            Console.WriteLine($"VALOR A PAGAR: R$ {totalAPagar.ToString("F2",CultureInfo.InvariantCulture)}");


        }
    }
}