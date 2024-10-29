using System;
using System.Globalization;

namespace Bee1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDoFuncionario = int.Parse(Console.ReadLine());
            int quantidadeHorasTrabalhadas = int.Parse(Console.ReadLine());
            double valorHoraDeTrabalho = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double salarioLiquido = quantidadeHorasTrabalhadas * valorHoraDeTrabalho;

            Console.WriteLine($"NUMBER = {numeroDoFuncionario}");
            Console.WriteLine($"SALARY = U$ {salarioLiquido.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}