using System;

namespace Bee1060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1 = double.Parse(Console.ReadLine());
            double v2 = double.Parse(Console.ReadLine());
            double v3 = double.Parse(Console.ReadLine());
            double v4 = double.Parse(Console.ReadLine());
            double v5 = double.Parse(Console.ReadLine());
            double v6 = double.Parse(Console.ReadLine());

            int valoresPositivos = 0;

            if(v1 >0)
            {
                valoresPositivos += 1;
            }
            if (v2 > 0)
            {
                valoresPositivos += 1;
            }
            if (v3 > 0)
            {
                valoresPositivos += 1;
            }
            if (v4 > 0)
            {
                valoresPositivos += 1;
            }
            if (v5 > 0)
            {
                valoresPositivos += 1;
            }
            if (v6 > 0)
            {
                valoresPositivos += 1;
            }

            Console.WriteLine($"{valoresPositivos} valores positivos");
            Console.ReadKey();
        }
    }
}