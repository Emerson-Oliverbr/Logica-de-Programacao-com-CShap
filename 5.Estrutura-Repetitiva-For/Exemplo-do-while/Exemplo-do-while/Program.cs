using System;
using System.Globalization;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            char resposta;

            do
            {
                Console.Write("Digite a temperatura em Celcius: ");
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                f = 9.0 * c / 5.0 + 32.0;

                Console.WriteLine($"Temperatuira em fahrenheit: {f.ToString("f1", CultureInfo.InvariantCulture)}");

                Console.Write("Deseja repetir (s/n)? ");
                resposta = char.Parse(Console.ReadLine());
            } while (resposta == 's' || resposta == 'S');   

        }
    }
}