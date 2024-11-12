using Microsoft.Win32.SafeHandles;
using System;

namespace Bee1114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida ");
                senha = int.Parse(Console.ReadLine());
            }

            if(senha == 2002)
            {
                Console.WriteLine("Acesso permitido");
            }
            Console.ReadKey();
        }
    }
}