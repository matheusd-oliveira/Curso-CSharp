using System;

namespace _1115
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            X = 1;
            Y = 1;

            while (true) {
                string[] ponto = Console.ReadLine().Split(' ');
                X = int.Parse(ponto[0]);
                Y = int.Parse(ponto[1]);

                if (X == 0 || Y == 0)
                    break;

                if (X > 0 && Y > 0)
                    Console.WriteLine("primeiro");

                else if (X < 0 && Y > 0)
                    Console.WriteLine("segundo");

                else if (X < 0 && Y < 0)
                    Console.WriteLine("terceiro");

                else if (X > 0 && Y < 0)
                    Console.WriteLine("quarto");
            }
        }
    }
}
