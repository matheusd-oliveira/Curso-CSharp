using System;

namespace _1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i <= X; i++)
            {
                if ( i % 2 == 1)
                    Console.WriteLine(i);
            }
        }
    }
}
