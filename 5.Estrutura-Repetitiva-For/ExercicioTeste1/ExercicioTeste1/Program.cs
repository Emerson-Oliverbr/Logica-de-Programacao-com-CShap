using System;

namespace ExercicioTeste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, soma;

            n = int.Parse(Console.ReadLine());

            soma = 0;
            for(int i=1; i<=n; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma += x;
            }
            Console.WriteLine(soma);
        }
    }
}