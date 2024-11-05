using System;

namespace ExercicioExemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int valor1 = int.Parse(valores[0]);
            int valor2 = int.Parse(valores[1]);
            int valor3 = int.Parse(valores[2]);

            int menorValor;

            if (valor1 < valor2 && valor1 < valor3)
            {
                menorValor = valor1;
            }
            else 
                if (valor2 < valor1 && valor2 < valor3)
            {
                menorValor = valor2;
            }
            else
            {
                menorValor = valor3;
            }

            Console.WriteLine($"Menor valor é: {menorValor}");

            Console.ReadKey();
        }
    }
}