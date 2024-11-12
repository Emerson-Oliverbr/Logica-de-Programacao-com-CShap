using System;
using System.Globalization;

namespace Bee1154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());

            int contadorDeIdades = 0;
            double mediaDeIdades = 0.0;
            double somaIdades = 0.0;

            while (idade >= 0)
            {
                somaIdades = somaIdades + idade;
                contadorDeIdades = contadorDeIdades + 1;
                idade = int.Parse(Console.ReadLine());
            }

            mediaDeIdades = somaIdades / contadorDeIdades;

            Console.WriteLine($"{mediaDeIdades.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}