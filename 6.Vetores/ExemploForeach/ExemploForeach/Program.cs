using System;

namespace ExemploForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] vet = new string[N];

            for(int index=0; index<N; index+=1)
            {
                vet[index] = Console.ReadLine();
            }
            Console.WriteLine($"Nomes lidos: ");
            foreach (string elemento in vet)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}