﻿using System;

namespace Bee1080
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maior = int.Parse(Console.ReadLine());
            int posicao = 1;
            
            for (int i=2; i<=10; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > maior)
                {
                    maior = x;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}