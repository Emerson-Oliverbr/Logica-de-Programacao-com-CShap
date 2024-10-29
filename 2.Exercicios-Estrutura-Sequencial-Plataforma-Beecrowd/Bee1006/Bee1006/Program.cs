using System;
using System.Globalization;

namespace Bee1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double MEDIA = (A * 2.0 + B * 3.0 + C * 5.0) / 10.0;

            Console.WriteLine($"MEDIA {MEDIA.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}