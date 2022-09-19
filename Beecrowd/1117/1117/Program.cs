using System;
using System.Globalization;
namespace _1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, media;

            N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (N1 < 0.0 || N1 > 10.0)
            {
                Console.WriteLine("nota invalida");
                N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (N2 < 0.0 || N2 > 10.0) {
                Console.WriteLine("nota invalida");
                N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = (N1 + N2) / 2.0;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

