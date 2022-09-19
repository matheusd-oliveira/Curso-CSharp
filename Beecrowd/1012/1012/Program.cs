using System;
using System.Globalization;

namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            string[] s = Console.ReadLine().Split(' ');
            A = double.Parse(s[0], CultureInfo.InvariantCulture);
            B = double.Parse(s[1], CultureInfo.InvariantCulture);
            C = double.Parse(s[2], CultureInfo.InvariantCulture);

            double aTri = A * C / 2;
            double aCir = 3.14159 * Math.Pow(C, 2);
            double aTrap = (A + B) * C / 2;
            double aQuad = B * B;
            double aRet = A * B;

            Console.WriteLine("TRIANGULO: " + aTri.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + aCir.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + aTrap.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + aQuad.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + aRet.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
