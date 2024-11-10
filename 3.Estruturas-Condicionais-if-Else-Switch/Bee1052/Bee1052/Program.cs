using System;

namespace Bee1052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            string mesDoAno;

            switch (numero)
            {
                case 1:
                    mesDoAno = "Janeiro";
                    break;
                case 2:
                    mesDoAno = "Fevereiro";
                    break;
                case 3:
                    mesDoAno = "Março";
                    break;
                case 4:
                    mesDoAno = "Abril";
                    break;
                case 5:
                    mesDoAno = "Maio";
                    break;
                case 6:
                    mesDoAno = "Junho";
                    break;
                case 7:
                    mesDoAno = "Julho";
                    break;
                case 8:
                    mesDoAno = "Agosto";
                    break;
                case 9:
                    mesDoAno = "Setembro";
                    break;
                case 10:
                    mesDoAno = "Outubro";
                    break;
                case 11:
                    mesDoAno = "Novembro";
                    break;
                case 12:
                    mesDoAno = "Dezembro";
                    break;
                default:
                    mesDoAno = "Mês Invalido";
                    break;
            }

            Console.WriteLine(mesDoAno);
            Console.ReadKey();
        }
    }
}