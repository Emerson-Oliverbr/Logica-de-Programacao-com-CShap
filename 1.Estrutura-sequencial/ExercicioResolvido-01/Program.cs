using System;
using System.Globalization;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            String nome = "Emerson";
            int idade = 39;

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(x.ToString("F4", CultureInfo.InvariantCulture) + "\n");                    
            Console.WriteLine("Resultado é " + x);
            Console.WriteLine("Resultado é " + x.ToString("F3",CultureInfo.InvariantCulture));
            System.Console.WriteLine("O valor do troco é R$: " + x + " Reais");
            System.Console.WriteLine($"Meu nome é {nome} eu tenho {idade} anos");
        }
    }
}