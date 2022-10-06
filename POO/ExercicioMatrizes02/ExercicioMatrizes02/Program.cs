﻿using System;

namespace ExercicioMatrizes02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de linhas e colunas da matriz: ");
            string[] line = Console.ReadLine().Split(' ');
            
            int M = int.Parse(line[0]);
            int N = int.Parse(line[1]);

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }
            Console.Write("Digite um  número: ");
            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] == X)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");

                        if (i > 0)
                        {
                           
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }

                        if (j > 0)
                        {
                           
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }

                        if (i < M - 1)
                        {
                            
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }

                        if (j < N - 1)
                        {
                            
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                    }
                }
            }

        }
    }
}
