using System;
using System.Globalization;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int numero1 = int.Parse(Console.ReadLine());
            char letra = char.Parse(Console.ReadLine());
            double numero2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            string[] dadosCadastrais = Console.ReadLine().Split(' ');
            string nome = dadosCadastrais[0];
            char sexo = char.Parse(dadosCadastrais[1]);
            int idade = int.Parse(dadosCadastrais[2]);
            double altura = double.Parse(dadosCadastrais[3],CultureInfo.InstalledUICulture);

            Console.WriteLine("Voce digitou: ");
            Console.WriteLine(numero1);
            Console.WriteLine(letra);
            Console.WriteLine(numero2.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);    
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));    
        }
    }
}