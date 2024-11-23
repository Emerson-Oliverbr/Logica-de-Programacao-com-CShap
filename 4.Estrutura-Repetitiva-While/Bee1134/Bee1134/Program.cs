using System;

namespace Bee1134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0;
            int tipoDeCombustivel = int.Parse(Console.ReadLine());

            while (tipoDeCombustivel != 4)
            {
                tipoDeCombustivel = int.Parse(Console.ReadLine());

                if(tipoDeCombustivel == 1)
                {
                    alcool = alcool + 1;
                }
                if (tipoDeCombustivel == 2)
                {
                    gasolina = gasolina + 1;
                }
                if (tipoDeCombustivel == 3)
                {
                    diesel = diesel + 1;
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
            Console.ReadKey();
        }
    }
}