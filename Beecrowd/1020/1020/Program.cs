using System;

namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {   
            // 1 ano 365 dias
            // 1 mes = 30 dias
            //

            int idadeEmDias, anos, meses, dias, resto;
            idadeEmDias = int.Parse(Console.ReadLine());

            anos = idadeEmDias / 365;
            resto = idadeEmDias % 365;

            meses = resto / 30;
            dias = resto % 30;

            
            Console.WriteLine(anos + " ano (s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia (s)");

        }
    }
}
