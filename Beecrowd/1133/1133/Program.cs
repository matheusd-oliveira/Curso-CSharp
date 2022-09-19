using System;

namespace _1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            int maior = 0;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());


            if (X > Y)
            {
                maior = X;
                X = Y;
                Y = maior;
            }

            for (int i = X + 1; i < Y; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
