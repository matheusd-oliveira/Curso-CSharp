using System;

namespace _1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, contadorAlcool = 0, contadorGasolina = 0, contadorDiesel = 0;

            numero = int.Parse(Console.ReadLine());

            while (numero < 1 || numero > 4)
                numero = int.Parse(Console.ReadLine());
                if (numero == 1)
                    contadorAlcool += 1;
                else if (numero == 2)
                    contadorGasolina += 1;
                else if (numero == 3)
                    contadorDiesel += 1;

            while (numero != 4)
            {
                numero = int.Parse(Console.ReadLine());

                if (numero == 1)
                    contadorAlcool += 1;
                else if (numero == 2)
                    contadorGasolina += 1;
                else if (numero == 3)
                    contadorDiesel += 1;
            }


            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + contadorAlcool);
            Console.WriteLine("Gasolina: " + contadorGasolina);
            Console.WriteLine("Diesel: " + contadorDiesel);
        }
    }
}
