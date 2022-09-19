using System;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTAS DE 100, 50, 20, 10, 5, 2, 1
            int nota = 0;
            int cedula = int.Parse(Console.ReadLine());

            Console.WriteLine(cedula);
            for (int i = 1; i <=7; i++)
            {   
                switch (i)
                {
                    case 1:
                        nota = 100;
                        break;
                    case 2:
                        nota = 50;
                        break;
                    case 3:
                        nota = 20;
                        break;
                    case 4:
                        nota = 10;
                        break;
                    case 5:
                        nota = 5;
                        break;
                    case 6:
                        nota = 2;
                        break;
                    case 7:
                        nota = 1;
                        break;
                }

                Console.WriteLine($"{cedula / nota} notas(s) de R$ {nota},00");
                cedula = cedula % nota;
            }
        }
    }
}
