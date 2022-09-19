using System;
using System.Globalization;
namespace _1064
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            double media = 0, soma = 0, numero;
            
            for (int i = 0; i < 6; i++)
            {
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (numero > 0)
                {
                    contador += 1;
                    soma += numero;
                }
            }

            media = soma / contador;
            Console.WriteLine(contador + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
