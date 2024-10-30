using System;
using System.Globalization;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            int r = int.Parse(Console.ReadLine());

            double volume = (4.0 / 3.0) * pi * Math.Pow(r, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}