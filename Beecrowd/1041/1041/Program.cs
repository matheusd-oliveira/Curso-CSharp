using System;
using System.Globalization;
namespace _1041
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y;

            string[] pontos = Console.ReadLine().Split(' ');
            X = double.Parse(pontos[0], CultureInfo.InvariantCulture);
            Y = double.Parse(pontos[1], CultureInfo.InvariantCulture);

            if (X > 0.0 && Y > 0.0)
                Console.WriteLine("Q1");

            else if (X < 0.0 && Y > 0.0)
                Console.WriteLine("Q2");

            else if (X < 0.0 && Y < 0.0)
                Console.WriteLine("Q3");

            else if (X > 0.0 && Y < 0.0)
                Console.WriteLine("Q4");

            else if (X == 0.0 && Y == 0.0)
                Console.WriteLine("Origem");

            else if (X == 0.0)
                Console.WriteLine("Eixo Y");

            else if (Y == 0.0)
                Console.WriteLine("Eixo X");
        }
    }
}
