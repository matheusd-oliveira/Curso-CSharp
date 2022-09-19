using System;
using System.Globalization;
namespace _1038
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CODIGO  ESPECIFICAÇÃO  PREÇO");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1 -  Cachorro Quente - R$ 4.00");
            Console.WriteLine("2 -  X-Salada        - R$ 4.50");
            Console.WriteLine("3 -  X-Bacon         - R$ 5.00");
            Console.WriteLine("4 -  Torrada Simples - R$ 2.00");
            Console.WriteLine("5 -  Refrigerante    - R$ 1.50");
            Console.WriteLine("------------------------------");

            int Codigo, quantidade;
            double preco;

            string[] s = Console.ReadLine().Split(' ');
            Codigo = int.Parse(s[0]);
            quantidade = int.Parse(s[1]);

            preco = 0.0;

            if (Codigo == 1)
                preco = quantidade * 4.0;

            else if (Codigo == 2)
                preco = quantidade * 4.5;

            else if (Codigo == 3)
                preco = quantidade * 5.0;

            else if (Codigo == 4)
                preco = quantidade * 2.0;
            else if (Codigo == 5)
                preco = quantidade * 1.50;
            else
                Console.WriteLine("Esse Código não existe!");



            Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
