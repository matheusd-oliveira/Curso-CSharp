using System;

namespace _1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, vetorOrdenado;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            int[] s = new int[3];
            s[0] = A;
            s[1] = B;
            s[2] = C;

            for (int i = 0; i < s.Length; i++)
            {
                Array.Sort(s);
                Console.WriteLine(s[i]);
            }

            Console.WriteLine();

            foreach (var item in vet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
