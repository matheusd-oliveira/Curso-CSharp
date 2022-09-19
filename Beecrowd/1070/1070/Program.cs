using System;

namespace _1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, impares;

            impares = 0;
            X = int.Parse(Console.ReadLine());

            while (impares != 6)
            {

                if (X % 2 == 0)
                {
                    X += 1;
                    continue;
                }
                else
                {
                    impares += 1;
                    Console.WriteLine(X);
                    X += 1;
                }
               
            }

        }
    }
}
