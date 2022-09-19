using System;

namespace _1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0) {
                    
                    if (num > 0)
                        Console.WriteLine("EVEN POSITIVE");

                    else if (num < 0 && num != 0)
                        Console.WriteLine("EVEN NEGATIVE");
                }

                else
                {
                    if (num > 0)
                        Console.WriteLine("ODD POSITIVE");
                    else if(num < 0 && num != 0)
                        Console.WriteLine("ODD NEGATIVE");
                }

                if (num == 0)
                    Console.WriteLine("NULL");


            }
        }
    }
}
