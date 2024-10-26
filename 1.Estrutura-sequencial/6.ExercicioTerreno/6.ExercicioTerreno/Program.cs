using System;
using System.Globalization;

namespace ExercicioTerreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * comprimento;
            double precoTotal = area * precoMetroQuadrado; 

            Console.WriteLine("Area = " + area.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + precoTotal.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
