using System;

namespace ExercicioVetores02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pensao[] quartos = new Pensao[10];

            Console.Write("Quantos quartos serão alugados? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Aluguel #{i}:" );
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string mail = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());

                quartos[room] = new Pensao(name, mail);
                Console.WriteLine();

            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(i + ": " + quartos[i]);
                }

            }
        }
    }
}
