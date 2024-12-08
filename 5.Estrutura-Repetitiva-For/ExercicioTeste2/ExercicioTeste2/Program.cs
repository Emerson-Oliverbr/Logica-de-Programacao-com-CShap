using System;

namespace ExercicioTeste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            for(int i=1; i<=10; i++)
            {
                Console.WriteLine($"{i} x {n} = {n*i}");
            }
        }
    }
}