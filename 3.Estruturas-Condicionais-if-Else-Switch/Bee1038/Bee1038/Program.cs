using System;
using System.Globalization;

namespace Bee1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double valorAPagar = 0.0;
            if(codigo == 1)
            {
                valorAPagar = quantidade * 4.00;
            }
            else if (codigo == 2)
            {
                valorAPagar = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                valorAPagar = quantidade * 5.00;
            }
            else if (codigo == 4)
            {
                valorAPagar = quantidade * 2.00;
            }
            else if (codigo == 5)
            {
                valorAPagar = quantidade * 1.50;
            }

            Console.WriteLine($"Total: R$ {valorAPagar.ToString("F2",CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}