using System;
using System.Globalization;

namespace Bee1043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, perimetro, area;

            String[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0],CultureInfo.InvariantCulture);
            B = double.Parse(valores[1],CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if (A < B + C && B < A + C && C < A + B)
            {
                perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((A + B) * C) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}