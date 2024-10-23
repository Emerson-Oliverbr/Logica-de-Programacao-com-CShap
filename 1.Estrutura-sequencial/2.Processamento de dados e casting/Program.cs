using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            x = 5;
            y = 2 * x;

            System.Console.WriteLine("Valor de x é: " + x);
            System.Console.WriteLine("Valor de y é: " + y);

            double b, B, h, area;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;

            System.Console.WriteLine("Area é = " + area);
        }
    }
}