using System;

namespace _1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            string[] s = Console.ReadLine().Split(' ');
            A = int.Parse(s[0]);
            B = int.Parse(s[1]);         

            if (A % B == 0 || B % A == 0)
                Console.WriteLine("Sao Multiplos");
            else
                Console.WriteLine("Nao sao Multiplos");
        }
    }
}
