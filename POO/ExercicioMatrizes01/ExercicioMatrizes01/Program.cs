using System;

namespace ExercicioMatrizes01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o Número: ");
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N,N];
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(values[j]);

                    if (mat[i, j] < 0)
                        count++;
                }
            }

            Console.Write("Main Diagonal: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();
            Console.Write("Negative numbers: " + count);

        }
    }
}
