using System;
using System.Globalization;

namespace Bee1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempoGasto = int.Parse(Console.ReadLine());
            int velocidadeMedia = int.Parse(Console.ReadLine());

            int distancia;
            double combustivelGasto;

            distancia = tempoGasto * velocidadeMedia;
            combustivelGasto = distancia / 12.0;

            Console.WriteLine($"{combustivelGasto.ToString("F3",CultureInfo.InvariantCulture)}");
        }
    }
}