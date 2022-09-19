using System;

namespace _1065
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero, countPar;
            countPar = 0;

            for (int i = 0; i < 5; i++)
            {
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                    countPar += 1;
            }

            Console.WriteLine(countPar + " valores pares");
        }
    }
}
