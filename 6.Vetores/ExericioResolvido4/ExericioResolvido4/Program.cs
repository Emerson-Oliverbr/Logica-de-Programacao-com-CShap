using System;
using System.Globalization;

namespace ExercicioResolvido4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];

            for (int index = 0; index < N; index += 1)
            {
                string[] dadosPessoas = Console.ReadLine().Split(' ');
                nomes[index] = dadosPessoas[0];
                idades[index] = int.Parse(dadosPessoas[1]);
                alturas[index] = double.Parse(dadosPessoas[2], CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int index = 0; index < N; index += 1)
            {
                soma += alturas[index];
            }
            double media = soma / N;
            Console.WriteLine($"Altura media: {media.ToString("F2",CultureInfo.InvariantCulture)}");

            int contador = 0;
            for (int index = 0; index < N; index += 1)
            {
                if (idades[index] < 16)
                {
                    contador += 1;
                }
            }

            double porcentagem = (double) contador / N * 100.0;
            Console.WriteLine($"Pessoas com menos de 16 anos: {porcentagem.ToString("F1",CultureInfo.InvariantCulture)} %");
        }
    }
}