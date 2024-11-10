using System;
using System.Globalization;

namespace Bee1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float notaExame, media, mediaFinal;

            string[] notas = Console.ReadLine().Split(' ');
            float nota1 = float.Parse(notas[0],CultureInfo.InvariantCulture);
            float nota2 = float.Parse(notas[1],CultureInfo.InvariantCulture);
            float nota3 = float.Parse(notas[2],CultureInfo.InvariantCulture);
            float nota4 = float.Parse(notas[3],CultureInfo.InvariantCulture);            

            media = (nota1 * 2f + nota2 * 3f + nota3 * 4f + nota4 * 1f) / 10f;

            if(media < 5f)
            {
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aluno reprovado.");
                               
            }           
            else if(media >= 5f && media <= 6.9f)
            {
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aluno em exame.");
                Console.Write("Nota do exame:");
                notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mediaFinal = (media + notaExame) / 2f;

                if(mediaFinal >= 5f)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {mediaFinal.ToString("f1",CultureInfo.InvariantCulture)}");                    
                }
                else
                {
                    Console.WriteLine($"Media final: {mediaFinal.ToString("f1", CultureInfo.InvariantCulture)}");
                    Console.WriteLine("Aluno reprovado.");
                }
            }
            else
            {
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aluno aprovado."); 
            }
            Console.ReadKey();
        }
    }
}