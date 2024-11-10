using System;

namespace Bee1050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string cidade = " ";

            switch(x)
            {
                case 61:
                    cidade = "Brasilia";
                    break;
                case 71:
                        cidade = "Salvador";
                    break;
                case 11:
                    cidade = "São Paulo";
                    break;
                case 21:
                    cidade = "Rio de Janeiro";
                    break;
                case 32:
                    cidade = "Juiz de Fora";
                    break;
                case 19:
                    cidade = "Campinas";
                    break;
                case 27:
                    cidade = "Vitoria";
                    break;
                case 31:
                    cidade = "Belo Horizonte";
                    break;
                default:
                    Console.WriteLine("DDD Invalido");
                    break;
            }
            Console.WriteLine(cidade);
            Console.ReadKey();
        }
    }
}