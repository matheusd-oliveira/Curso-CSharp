using System;
using System.Globalization;
namespace _1051
{
    class Program
    {
        static void Main(string[] args)
        {
            int imposto;
            double valorImposto = 0;
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.00)
                Console.WriteLine("Isento");

            else if (salario <= 3000.00)
            {
                imposto = 8;
                valorImposto = (salario - 2000.00) * imposto / 100;
                Console.WriteLine("R$ " + valorImposto.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (salario == 3002.00)
            {
                valorImposto = (1000.00 * 8 / 100) + (2.00 * 18 / 100);
                Console.WriteLine("R$ " + valorImposto.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (salario <= 4500.00)
            {
                imposto = 18;
                valorImposto = (salario - 3000.00) * imposto / 100;
                Console.WriteLine("R$ " + valorImposto.ToString("F2", CultureInfo.InvariantCulture));
            }

            else 
            {
                imposto = 28;
                valorImposto = (salario - 4500 ) * imposto / 100;
                Console.WriteLine("R$ " + valorImposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
