using System;

namespace _1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            string[] s = Console.ReadLine().Split(' ');
            A = int.Parse(s[0]);
            B = int.Parse(s[1]);
            C = int.Parse(s[2]);
            D = int.Parse(s[3]);

            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
                Console.WriteLine("Valores Aceitos");



            else
                Console.WriteLine("Valores não aceitos");



        }
    }
}
