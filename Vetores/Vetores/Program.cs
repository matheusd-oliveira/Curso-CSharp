using System;
using System.Globalization;
namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vetores
            // Possuem tamanho fixo, quando alocados.
            // Os elementos são acessados por meio de índice (iguais a listas)
            // unidimensional
            // Todos os dados são do mesmo tipo .

            /*int N;
            double[] vet;

            N = int.Parse(Console.ReadLine());
            // Instanciando a quantidade de posições do vetor.

            vet = new double[N];

            // Colocando os elementos no vetor .
            for (int i = 0; i < N; i++) {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            // Percorrendo o vetor e imprimindo na tela.
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }*/

            /*int N;
            int[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < N; i++)
            {
                if (vet[i] < 0) { 
                    Console.WriteLine(vet[i]); 
                }
                    
            }*/

            /*int N;
            double[] vet;
            double soma, media;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];
            soma = 0.0;

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                soma += vet[i];
            }

            media = soma / N;
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));*/



        }
    }
}
