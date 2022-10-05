using System;

namespace ModificadorRefEOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizando o ref
            // o Modificador ref necessita que a variável seja iniciada.
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            // Utilizando o OUT
            // o Modificador OUT não necessita que a variável seja iniciada.

            // AMBOS SÃO CONSIDERADOS "CODE SMELLS" (design ruim) e devem ser evitados.
            int b = 10;
            int dobro;
            Calculator.Double(b, out dobro);
            Console.WriteLine(dobro);
        }

        
    }
}
