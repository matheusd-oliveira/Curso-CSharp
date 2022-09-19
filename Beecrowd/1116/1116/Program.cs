using System;
using System.Globalization;

namespace _1116
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, divisao;
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                X = double.Parse(vet[0]);
                Y = double.Parse(vet[1]);

                if (X == 0)
                {
                    divisao = X / Y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }

                else if (Y == 0)
                    Console.WriteLine("divisao impossivel");
                else {
                    divisao = X / Y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
                    
            }
        }
    }
}
