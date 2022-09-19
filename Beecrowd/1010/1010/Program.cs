using System;
using System.Globalization;
namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int c1, n1, c2, n2;
            double v1, v2;

            string[] s = Console.ReadLine().Split(' ');
            c1 = int.Parse(s[0]);
            n1 = int.Parse(s[1]);
            v1 = double.Parse(s[2], CultureInfo.InvariantCulture);

            s = Console.ReadLine().Split(' ');
            c2 = int.Parse(s[0]);
            n2 = int.Parse(s[1]);
            v2 = double.Parse(s[2], CultureInfo.InvariantCulture);

            double total;
            total = n1 * v1 + n2 * v2;


            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
