using System;
using System.Globalization;

namespace Bee1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double MEDIA = (A * 3.5 + B * 7.5) / 11.0;

            Console.WriteLine($"MEDIA {MEDIA.ToString("F5",CultureInfo.InvariantCulture)}");
        }
    }
}