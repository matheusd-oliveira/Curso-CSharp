using System;
using System.Globalization;

namespace _1048
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salário -        Percentual de Reajuste");
            Console.WriteLine("0       - 400.00         15 %");
            Console.WriteLine("400.01  - 800.00         12 %");
            Console.WriteLine("800.01  - 1200.00        10 %");
            Console.WriteLine("1200.01 - 2000.00        7  %");
            Console.WriteLine("Acima de 2000.00         4  %");

            Console.WriteLine();
            Console.WriteLine("Escreva seu salário: ");
            

            double salario, novoSalario, valorReajuste, percentualGanho;
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            novoSalario = 0;

            if (salario <= 400.00)
            {
                percentualGanho = 15;
                valorReajuste = (salario * percentualGanho / 100);
                novoSalario = salario + valorReajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + valorReajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentualGanho + " %");
            }

            else if (salario <= 800.00)
            {
                percentualGanho = 12;
                valorReajuste = (salario * percentualGanho / 100);
                novoSalario = salario + valorReajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + valorReajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentualGanho + " %");
            }
            else if (salario <= 1200.00)
            {
                percentualGanho = 10;
                valorReajuste = (salario * percentualGanho / 100);
                novoSalario = salario + valorReajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + valorReajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentualGanho + " %");
            }
            else if (salario <= 2000)
            {
                percentualGanho = 7;
                valorReajuste = (salario * percentualGanho / 100);
                novoSalario = salario + valorReajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + valorReajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentualGanho + " %");
            }
            else
            {
                percentualGanho = 4;
                valorReajuste = (salario * percentualGanho / 100);
                novoSalario = salario + valorReajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + valorReajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentualGanho + " %");
            }
        }
    }
}
