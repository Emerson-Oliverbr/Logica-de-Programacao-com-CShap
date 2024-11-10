using System;

namespace Bee1044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int valor1 = int.Parse(valores[0]);
            int valor2 = int.Parse(valores[1]);

            if(valor1 % valor2 == 0 || valor2 % valor1 ==0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

            Console.ReadKey();
        }
    }
}