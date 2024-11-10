using System;
using System.Globalization;

namespace Bee1051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, impostoAPagar = 0.0;

            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if(salario <= 2000.00)
            {
                impostoAPagar = 0.0;
            }
            else if (salario <= 3000.0)
            {
                impostoAPagar = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                impostoAPagar = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                impostoAPagar = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (impostoAPagar == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + impostoAPagar.ToString("F2", CultureInfo.InvariantCulture));
            }            
            Console.ReadKey();
        }
    }
}