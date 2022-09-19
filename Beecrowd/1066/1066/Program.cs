using System;

namespace _1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, countPar = 0, countImpar = 0, countNegativo = 0, countPositivo = 0;

            for (int i = 0; i < 5; i++)
            {
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                    countPar += 1;
                else
                    countImpar += 1;

                if (numero < 0)
                    countNegativo += 1;
                else if (numero > 0)
                    countPositivo += 1;
            }

            Console.WriteLine(countPar + " valor(es) par(es)");
            Console.WriteLine(countImpar + " valor(es) impar(es)");
            Console.WriteLine(countPositivo + " valor(es) positivo(s)");
            Console.WriteLine(countNegativo + " valor(es) negativo(s)");
        }
    }
}
