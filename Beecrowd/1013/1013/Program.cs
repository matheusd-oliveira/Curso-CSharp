using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, maiorAB;
            string[] s = Console.ReadLine().Split(' ');

            A = int.Parse(s[0]);
            B = int.Parse(s[1]);
            C = int.Parse(s[2]);

            maiorAB = (A + B + Math.Abs(A - B)) / 2;

            if (maiorAB < C)
                maiorAB = C;


            Console.WriteLine(maiorAB + " eh o maior");
        }
    }
}
