using System;

namespace Bee1159
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int somaPares = 0;
            while (x != 0)
            {
                if (x % 2!= 0)
                {
                    x = x + 1;
                }

                somaPares = x + x + 2 + x + 4 + x + 6 + x + 8;

                Console.WriteLine(somaPares);
                x = int.Parse(Console.ReadLine());                
            }
        }
    }
}
