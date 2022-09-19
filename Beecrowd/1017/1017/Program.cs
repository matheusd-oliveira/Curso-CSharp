using System;
using System.Globalization;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            // Automóvel faz 12 km/l
            int tempoUtilizado, velocidadeMedia;
            double distanciaPercorrida, gasolinaUtilizada;

            tempoUtilizado = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            velocidadeMedia = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            distanciaPercorrida =  velocidadeMedia * tempoUtilizado;
            gasolinaUtilizada =  distanciaPercorrida / 12.0;

            Console.WriteLine(gasolinaUtilizada.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
