using System;

namespace Bee1065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = int.Parse(Console.ReadLine());
            int v2 = int.Parse(Console.ReadLine());
            int v3 = int.Parse(Console.ReadLine());
            int v4 = int.Parse(Console.ReadLine());
            int v5 = int.Parse(Console.ReadLine());

            int valoresPositivos = 0;

            if(v1 % 2 == 0)
            {
                valoresPositivos++;
            }
            if (v2 % 2 == 0)
            {
                valoresPositivos++;
            }
            if (v3 % 2 == 0)
            {
                valoresPositivos++;
            }
            if (v4 % 2 == 0)
            {
                valoresPositivos++;
            }
            if (v5 % 2 == 0)
            {
                valoresPositivos++;
            }

            Console.WriteLine($"{valoresPositivos} valores positivos");
            Console.ReadKey();
        }
    }
}