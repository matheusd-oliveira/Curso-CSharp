using System;

namespace _1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (int i = 0; i < 6; i++)
            {
                double valor = double.Parse(Console.ReadLine());

                if (valor > 0.0) {
                    count++;
                }
                    
            }

            Console.WriteLine(count +" valores positivos");
        }
    }
}
