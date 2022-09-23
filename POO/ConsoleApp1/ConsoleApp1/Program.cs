using System;
using System.Globalization;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classe é um tipo estruturado que pode conter membros:
            // - Atributos e Métodos

            // A classe pode prover outros recursos:
            // - Construtores, Sobrecarga, Encapsulamento, Herança e Polimorfismo

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulos: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulos: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if(areaX > areaY)
                    Console.WriteLine("Maior área: X");
            else
                Console.WriteLine("Maior área: Y");
        }
    }
}
