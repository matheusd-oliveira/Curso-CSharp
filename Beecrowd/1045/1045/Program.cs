using System.Globalization;

namespace _1045
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            // TIPOS DE TRIANGULOS
            // TODO: Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente,
            // de modo que o lado A representa o maior dos 3 lados
            // COMPLETE ***
            float A, B, C, maior = 0;

            string[] vet = Console.ReadLine().Split(' ');

            A = float.Parse(vet[0], CultureInfo.InvariantCulture);
            B = float.Parse(vet[1], CultureInfo.InvariantCulture);
            C = float.Parse(vet[2], CultureInfo.InvariantCulture);


            if (A > maior)
                maior = A;
            if (B > maior)
                maior = B;
            if (C > maior)
                maior = C;


            if (maior == B)
                B = A;

            else if (maior == C)
                C = A;

            A = maior;

            // TODO: Fazer validações para cada tipo de triângulo
            // COMPLETE ***

            if (A >= B + C)
                Console.WriteLine("NAO FORMA TRIANGULO");

            else if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                Console.WriteLine("TRIANGULO RETANGULO");

            else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
                Console.WriteLine("TRIANGULO OBTUSANGULO");

            else if (Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2))
                Console.WriteLine("TRIANGULO ACUTANGULO");

            if (A == B && B == C)
                Console.WriteLine("TRIANGULO EQUILATERO");

            else if ( (A == B && A != C) || (B == C && B != A) || (C == A && C != B))
                Console.WriteLine("TRIANGULO ISOSCELES");





        }
    }
}