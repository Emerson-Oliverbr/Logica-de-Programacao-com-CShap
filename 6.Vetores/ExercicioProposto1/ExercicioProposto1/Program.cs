using System;
using System.Globalization;

namespace ExercicioProposto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] numeros = new double[N];
            string[] numerosDigitados = Console.ReadLine().Split(' ');

            for (int index=0; index<N; index+=1)
            {                
                numeros[index] = double.Parse(numerosDigitados[index],CultureInfo.InvariantCulture);
            }

            double maiorValor = numeros[0];
            int posicaoMaior = 0;

            for (int index = 1; index < N; index += 1)
            {
                if (numeros[index] > maiorValor)
                {
                    maiorValor = numeros[index];
                    posicaoMaior = index;
                }
            }
            Console.WriteLine(maiorValor.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicaoMaior);
        }
    }
}