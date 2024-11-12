using System;
using System.Globalization;

namespace ExercicioTeste3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);          

            double somaIdades = 0.0, media = 0.0;
            int contadorIdades = 0;

            while(idade >= 0)
            {               
                somaIdades = somaIdades + idade;
                contadorIdades = contadorIdades + 1;               
                idade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);              
            }           

            if (contadorIdades == 0)
            {
                Console.WriteLine("Impossível calcular");
            }
            else
            {
                media = somaIdades / contadorIdades;
                Console.WriteLine($"{media.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            
            Console.ReadKey();
        }
    }
}