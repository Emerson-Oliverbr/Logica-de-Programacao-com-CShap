using System;

namespace Bee1067
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for(int i=0; i<=1000; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}