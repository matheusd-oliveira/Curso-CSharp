using System;
using System.Globalization;

namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, distancia;

            string[] s = Console.ReadLine().Split(' ');
            x1 = double.Parse(s[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(s[1], CultureInfo.InvariantCulture);

            s = Console.ReadLine().Split(' ');
            x2 = double.Parse(s[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(s[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
