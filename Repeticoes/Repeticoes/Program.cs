using System;
using System.Globalization;
using static System.Console;
namespace Repeticoes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x, y;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != y) { 
                if (x < y)
                    Console.WriteLine("Crescente");
                else
                    Console.WriteLine("Decrescente");

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }*/

            /*double idade, soma, media;
            int cont;


            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma = 0.0;
            cont = 0;

            while (idade >= 0) {
                soma += idade;
                cont += 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            if (cont == 0) {
                Console.WriteLine("Impossível calcular");
            }
                
            else {
                media = soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }*/

            /*            int N, x, soma;

                        N = int.Parse(Console.ReadLine());

                        soma = 0;
                        for (int i = 1; i <= N; i++)
                        {
                            x = int.Parse(Console.ReadLine());
                            soma += x;

                        }
                        Console.WriteLine(soma);*/

            // Tabuada de 10.
            /*            int N;
                        N = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= 10; i++) {
                            Console.WriteLine(i + " x " + N + " = " + i * N);

                        }*/

            /*int X, Y, maior, menor,soma;
            maior = 0;
            menor = 0;
            soma = 0;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X < Y)
            {
                maior = Y;
                menor = X;
            }
            else {
                maior = X;
                menor = Y; 
            }

            for (int i = menor + 1; i < maior; i++) {
                if (i % 2 != 0)
                    soma += i;
                
            }
            Console.WriteLine(soma);*/

            double C, F;
            char repetir = 'S';

            do
            {
                Write("Digite a temperatura em Celsius: ");
                C = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5 + 32.0;
                WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));

                Write("Deseja Repetir (s/n)? ");
                repetir = char.Parse(ReadLine().ToUpper());
            } while (repetir == 'S');
           





        }
    }
}
