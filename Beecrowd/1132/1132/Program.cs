using System;

namespace _1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int soma = 0;

            if (Y > X)
            {
                for (int i = X; i <= Y; i++)
                {
                    if (i % 13 != 0)
                        soma += i;
                }
                Console.WriteLine(soma);
            }
            else
            {
                for (int j = Y; j <= X; j++)
                {
                    if (j % 13 != 0)
                        soma += j;
                    
                }
                Console.WriteLine(soma);
            }

           /* int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = X; i <= Y; i++)
            {
                if (i % 13 != 0)
                    soma += i;
            }
            Console.WriteLine(soma);*/


        }
    }
}
