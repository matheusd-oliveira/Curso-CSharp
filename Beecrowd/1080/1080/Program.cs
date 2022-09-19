using System;

namespace _1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0, pos = 0;

            for (int i = 1; i <= 100; i++)
            {
                int N = int.Parse(Console.ReadLine());

                if (N > maior) {
                    maior = N;
                    pos = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(pos);
        }
    }
}
