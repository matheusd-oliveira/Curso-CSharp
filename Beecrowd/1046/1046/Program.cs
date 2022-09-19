using System;

namespace _1046
{
    class Program
    {
        static void Main(string[] args)
        {   
            // O jogo pode ter 24 horas de duração.

            int HoraInicio, HoraFim, tempoDeJogo, restoDoDia;

            string[] s = Console.ReadLine().Split(' ');
            HoraInicio = int.Parse(s[0]);
            HoraFim = int.Parse(s[1]);
            tempoDeJogo = 0;

            // Para saber quanto tempo falta para o dia acabar, de acordo com a HoraInicio
            restoDoDia = Math.Abs(HoraInicio - 24);

            // Para saber o tempo total do jogo de acordo com o Fim e o restante do dia.
            tempoDeJogo = restoDoDia + HoraFim;

            // Se o tempo for > 24, é só subtrair 24, pq o dia só vai até 24 horas.
            if (tempoDeJogo > 24) {
                tempoDeJogo -= 24;
            }
                
            Console.WriteLine("O JOGO DUROU " + tempoDeJogo +" HORA(S)");
                

        }
    }
}
