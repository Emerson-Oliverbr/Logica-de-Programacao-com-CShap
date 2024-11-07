using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string diaDaSemana;

            switch (x)
            {
                case 1:
                    diaDaSemana = "Domingo";
                    break;
                case 2:
                    diaDaSemana = "Segunda-Feira";
                    break;
                case 3:
                    diaDaSemana = "Terça-Feira";
                    break;
                case 4:
                    diaDaSemana = "Quarta-Feira";
                    break;
                case 5:
                    diaDaSemana = "Quinta-Feira";
                    break;
                case 6:
                    diaDaSemana = "Sexta-Feira";
                    break;
                case 7:
                    diaDaSemana = "Sabado";
                    break;
                default:
                    diaDaSemana = "Valor digitado invalido";
                    break;
            }

            Console.WriteLine($"Dia da semana {diaDaSemana}");

            Console.ReadKey();
        }
    }
}