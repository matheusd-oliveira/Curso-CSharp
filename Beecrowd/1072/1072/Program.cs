using System;

namespace _1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int contIn = 0, contOut= 0;
            int N = int.Parse(Console.ReadLine());
            int X;

            for (int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20)
                    contIn += 1;

                else
                    contOut += 1;
            }
            Console.WriteLine(contIn + " in");
            Console.WriteLine(contOut + " out");
        }
    }
}
