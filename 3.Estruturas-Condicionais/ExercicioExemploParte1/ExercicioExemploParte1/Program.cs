using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, sima;

            nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double soma = nota1 + nota2;

            Console.WriteLine("Nota Final: " + soma.ToString("F2", CultureInfo.InvariantCulture));

            if(soma < 60.0)
            {
                Console.WriteLine("Aluno Reprovado");
            }

            Console.ReadKey();
        }
    }
}