using System;
using System.Globalization;

namespace Bee1079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double media = 0;
            for(int i=0; i<=n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double v1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double v2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double v3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                media = (v1 * 2.0 + v2 * 3.0 + v3 * 5.0) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }            
        }
    }
}