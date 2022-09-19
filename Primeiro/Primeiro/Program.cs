using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string frase = Console.ReadLine();
              string x = Console.ReadLine();
              string y = Console.ReadLine();
              string z = Console.ReadLine();

              // otimizando o código.
              string[] vetor = Console.ReadLine().Split(' ');
              string a = vetor[0];
              string b = vetor[1];
              string c = vetor[2];

              Console.WriteLine("Você digitou: ");
              Console.WriteLine(frase);
              Console.WriteLine(x);
              Console.WriteLine(y);
              Console.WriteLine(z);


              Console.WriteLine(a + "|"+ b + "|" + c);*/


            /*int n1 = int.Parse(Console.ReadLine());
            char caracter = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vetor = Console.ReadLine().Split(' ');

            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);


            Console.WriteLine($"Você digitou: {n1}");
            Console.WriteLine($"Você digitou: {caracter}");
            Console.WriteLine($"Você digitou: {n2.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));*/

            /*            Console.WriteLine("Entre com seu nome completo: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Quantos quartos tem na sua casa? ");
                        int quartos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Entre com o preço de um produto: ");
                        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine("Entre com o seu último nome, idade e altura (mesma linha): ");

                        string[] vetor = Console.ReadLine().Split(' ');
                        string ultimoNome = vetor[0];
                        int idade = int.Parse(vetor[1]);
                        double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);

                        Console.WriteLine(nome);
                        Console.WriteLine(quartos);
                        Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
                        Console.WriteLine(ultimoNome);
                        Console.WriteLine(idade);
                        Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));*/

            // Exercicio Resolvido 01
            /*double largura, comprimento, precoMetroQuadrado, area, preco;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));*/

            // Exercicio Resolvido 02
            /*double b, a, area, perimetro, diagonal;

            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = b * a;
            perimetro = 2 * (b + a);
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));*/

            // Exercicio Resolvido 03
            /*string nome1, nome2;
            int idade1, idade2;
            double media;

            string[] vet =  Console.ReadLine().Split(' ');
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            idade2 = int.Parse(vet[1]);

            media = (double) (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de: " 
                + media.ToString("F1", CultureInfo.InvariantCulture));*/


            // Exercicio Resolvido 04
            /*int N, horas, resto, minutos, segundos;
            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);*/

  

        }
    }
}
