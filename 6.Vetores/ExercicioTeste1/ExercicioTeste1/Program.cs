using System;
using System.Globalization;

namespace ExercicioTeste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] valores;

            int n = int.Parse(Console.ReadLine());
            valores = new double[n];

            for(int index = 0; index<n; index +=1)
            {
                valores[index] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            for (int index = 0; index < n; index += 1)
            {
                Console.WriteLine(valores[index].ToString("F1",CultureInfo.InvariantCulture)); 
            }
        }
    }
}