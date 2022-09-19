using System;
using System.Globalization;

namespace _1154
{
    class Program
    {
        static void Main(string[] args)
        {

            int idades, contador = 0;
            double soma = 0, media = 0;


            idades = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma += idades;

            while (true) {
                idades = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contador += 1;
                soma += idades;

                if (idades < 0) {
                    soma -= idades;
                    break;
                }
                    
                
            }
            media = soma / contador;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
