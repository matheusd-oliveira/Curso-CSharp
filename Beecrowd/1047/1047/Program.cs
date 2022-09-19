using System;

namespace _1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, minutoInicial, minutoFinal, resHoras = 0, resMinutos = 0;

            string[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            minutoInicial = int.Parse(vet[1]);
            horaFinal = int.Parse(vet[2]);
            minutoFinal = int.Parse(vet[3]);

            resHoras = Math.Abs(horaFinal - horaInicial);
            resMinutos = Math.Abs(minutoFinal - minutoInicial);

            if (resHoras == 0)
                resHoras = 24;

            else if (resHoras == 1)
                resHoras = 0;


            Console.WriteLine("O JOGO DUROU " + resHoras + " HORA(S) E " + resMinutos + " MINUTO(S)");

        }
    }
}
