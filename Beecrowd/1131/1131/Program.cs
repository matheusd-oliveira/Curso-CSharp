using System;

namespace _1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int inter, gremio, contGrenais = 0, contInterVitorias = 0, contGremioVitorias = 0, contEmpates = 0, novoGrenal = 0;



            while (novoGrenal != 2)
            {
                string[] gols = Console.ReadLine().Split(' ');
                inter = int.Parse(gols[0]);
                gremio = int.Parse(gols[1]);

                if (inter > gremio)
                    contInterVitorias += 1;
                else if (inter == gremio)
                    contEmpates += 1;
                else
                    contGremioVitorias += 1;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());

                contGrenais += 1;
            }

            Console.WriteLine(contGrenais + " grenais");
            Console.WriteLine("Inter:" + contInterVitorias);
            Console.WriteLine("Gremio:" + contGremioVitorias);
            Console.WriteLine("Empates:" + contEmpates);

            if(contInterVitorias > contGremioVitorias)
                Console.WriteLine("Inter venceu mais");
            else
                Console.WriteLine("Gremio venceu mais");
        }
    }
}
