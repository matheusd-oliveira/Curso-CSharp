using System;
using System.Globalization;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            double nota1, nota2, soma;
                        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        soma = nota1 + nota2;

                        Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture));
                        if (soma < 60.0)
                            Console.WriteLine("REPROVADO!");*/

            //Fórmula de bhaskara

            /*double a, b, c, delta, r1, r2;
            String[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0 || delta < 0.0) {
                Console.WriteLine("Impossivel calcular");
            }
            else {
                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }*/


            /*int n1, n2, n3;
            string[] vet = Console.ReadLine().Split(' ');

            n1 = int.Parse(vet[0]);
            n2 = int.Parse(vet[1]);
            n3 = int.Parse(vet[2]);

            if (n1 < n2 && n1 < n3)
                Console.WriteLine("MENOR = " + n1);
            else if (n2 < n3)
                Console.WriteLine("MENOR = " + n2);
            else
                Console.WriteLine("MENOR = " + n3);*/


            /*int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;

            if (minutos > 100) {
                conta += (minutos - 100) * 2.0;

            }

            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));*/


            





        }
    }
}
