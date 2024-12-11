using System;
using System.Globalization;

namespace ExericioResolvido3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] A;

            N = int.Parse(Console.ReadLine());

            A = new double[N];

            string[] valores = Console.ReadLine().Split(' ');
            for(int index=0; index<N; index+=1)
            {
                A[index] = double.Parse(valores[index],CultureInfo.InvariantCulture);
            }

            for (int index = 0; index < N; index += 1)
            {
                Console.Write(A[index].ToString("F1",CultureInfo.InvariantCulture) + $" ");
            }
            Console.WriteLine();

            double soma = 0.0;
            for (int index = 0; index < N; index += 1)
            {
                soma += A[index];
            }

            double media = soma / N;
            Console.WriteLine($"{soma.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{media.ToString("F2", CultureInfo.InvariantCulture)}");            
        }
    }
}