using System;
using System.Globalization;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] dados = Console.ReadLine().Split(" ");
            string nome1 = (dados[0]);
            int idade1 = int.Parse(dados[1]);

            dados = Console.ReadLine().Split(" ");
            string nome2 = (dados[0]);
            int idade2 = int.Parse(dados[1]);

            double idadeMedia = (idade1 + idade2) / 2.0;

            Console.WriteLine($"A idade media de {nome1} e {nome2} é de {idadeMedia.ToString("F1",CultureInfo.InvariantCulture)} anos ");

        }
    }
}