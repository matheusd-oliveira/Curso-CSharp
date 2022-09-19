using System;
using System.Globalization;

namespace Matrizes01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] A;
            int cont = 0;

            N = int.Parse(Console.ReadLine());

            
            A = new int[N, N];

            
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s[j]);

                    if (A[i, j] < 0)
                        cont++;
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i,i] + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Quantidade de Números negativos = " + cont);







        }
    }
}
