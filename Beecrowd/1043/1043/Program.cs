using System;
using System.Globalization;

namespace _1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, area, perimetro;
            string[] s = Console.ReadLine().Split(' ');

            A = double.Parse(s[0], CultureInfo.InvariantCulture);
            B = double.Parse(s[1], CultureInfo.InvariantCulture);
            C = double.Parse(s[2], CultureInfo.InvariantCulture);

            // Em caso de ser um triângulo.
            // Cada lado deve obedecer essa regra. Ser maior que o módulo da diferença dos outros dois lados . E também menor que a soma dos outros Dois.
            if ((A > Math.Abs(B - C) && A < B + C) && (B > Math.Abs(A - C) && B < A + C) && (C > Math.Abs(B - A) && C < B + A)) {
                perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((A + B) * C ) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
