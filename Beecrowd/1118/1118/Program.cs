using System;
using System.Globalization;

namespace _1118
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            int X = 0;

            while (X != 2)
            {

                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota1 < 0 || nota1 > 10)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                media = (nota1 + nota2) / 2.0;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                X = int.Parse(Console.ReadLine());

                while (X < 1 || X > 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    X = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
