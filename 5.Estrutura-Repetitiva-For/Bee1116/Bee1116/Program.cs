using System;
using System.Globalization;

namespace Bee1116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int index=0; index<n; index += 1)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int valor1 = int.Parse(valores[0]);
                int valor2 = int.Parse(valores[1]);

                double resultadoDaDivisao = 0.0;
                if(valor1 < 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    resultadoDaDivisao = (double) valor1 / valor2;
                    Console.WriteLine(resultadoDaDivisao.ToString("F1",CultureInfo.InvariantCulture));
                }
            }
        }
    }
}