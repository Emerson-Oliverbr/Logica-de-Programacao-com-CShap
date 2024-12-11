using System;

namespace ExercicioTeste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores;
            int n = int.Parse(Console.ReadLine());
            valores = new int[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int index = 0; index < n; index += 1)
            {
                valores[index] = int.Parse(s[index]);
            }

            for (int index = 0; index < n; index += 1)
            {
                if (valores[index] < 0)
                {
                    Console.WriteLine(valores[index]);
                }
            }
        }
    }
}