using System;
using System.Globalization;

namespace Bee1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int r = 0, s = 0, c = 0;          

            for (int index = 0; index < n; index += 1)
            {
                string[] cobaias = Console.ReadLine().Split(' ');
                int quantidade = int.Parse(cobaias[0]);
                char tipoCobaia = char.Parse(cobaias[1]);

                if (tipoCobaia == 'R' || tipoCobaia == 'r')
                {
                    r += quantidade;
                }
                else if (tipoCobaia == 'S' || tipoCobaia == 's')
                {
                    s += quantidade;
                }
                else 
                {
                    c += quantidade;
                }
            }

            int totalCobais = r + s + c;
            double porcentagemCoelhos = (double)c / totalCobais * 100.0;
            double porcentagemSapos = (double)s / totalCobais * 100.0;
            double porcentagemRatos = (double)r / totalCobais * 100.0;
            Console.WriteLine($"Total: {totalCobais} cobaias");
            Console.WriteLine($"Total de coelhos: {c}");
            Console.WriteLine($"Total de ratos: {r}");
            Console.WriteLine($"Total de sapos: {s}");
            Console.WriteLine($"Percentual de colehos: {porcentagemCoelhos.ToString("F2",CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de ratos: { porcentagemRatos.ToString("F2",CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de sapos: {porcentagemSapos.ToString("F2",CultureInfo.InvariantCulture)}%");
        }
    }
}