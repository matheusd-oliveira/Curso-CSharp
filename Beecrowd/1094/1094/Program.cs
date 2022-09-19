using System;
using System.Globalization;

namespace _1094
{
    class Program
    {
        static void Main(string[] args)
        {
            // Quantas cobaias foram utilizadas.
            // Percentual de cada tipo de cobaia utilizada.
            // utiliza sapos, ratos e coelhos.
            int N, total = 0, quantidade = 0, coelhos = 0, ratos = 0, sapos = 0;
            double percCoelhos, percRatos, percSapos;
            string cobaia;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                quantidade = int.Parse(s[0]);
                cobaia = s[1];

                if (cobaia == "C")
                    coelhos += quantidade;

                else if (cobaia == "R")
                    ratos += quantidade;
                else if (cobaia == "S")
                    sapos += quantidade;
            }
            // Total de cobaias.
            total = coelhos + ratos + sapos;

            // Percentual de cada cobaia.
            percCoelhos = (double) coelhos * 100 / total;
            percRatos = (double) ratos * 100 / total;
            percSapos = (double) sapos * 100 / total;

            // Mostrando na tela.
            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + percCoelhos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + percRatos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + percSapos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}
