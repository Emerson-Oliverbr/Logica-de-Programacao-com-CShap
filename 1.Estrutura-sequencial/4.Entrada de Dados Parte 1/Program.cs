using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
           

            string[] vetFrutas = Console.ReadLine().Split(' ');

            string fruta1 = vetFrutas[0];
            string fruta2 = vetFrutas[1];
            string fruta3 = vetFrutas[2];

            System.Console.WriteLine("Voce digitou: ");
            System.Console.WriteLine(frase);
            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            System.Console.WriteLine(z);
            System.Console.WriteLine();
            System.Console.WriteLine(fruta1);
            System.Console.WriteLine(fruta2);
            System.Console.WriteLine(fruta3);      

        }
    }
}