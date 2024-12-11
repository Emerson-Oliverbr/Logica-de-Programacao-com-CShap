using System;
using System.Runtime.CompilerServices;

namespace Bee1096
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int index = 1; index <= 9; index += 2)
            {
                for (int index2 = 7; index2 >= 5; index2--)
                {
                    Console.Write("I=" + index + " J=" + index2 + "\n");
                }
            }
        }
    }
}