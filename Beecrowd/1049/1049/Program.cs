using System;

namespace _1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string P1, P2, P3, Animal;

            P1 = Console.ReadLine();
            P2 = Console.ReadLine();
            P3 = Console.ReadLine();

            if (P1 == "vertebrado")
            {
                if (P2 == "ave")
                {
                    if (P3 == "carnivoro")
                        Animal = "aguia";
                    else
                        Animal = "pomba";
                }
                else
                {
                    if (P3 == "onivoro")
                        Animal = "homem";
                    else
                        Animal = "vaca";
                }
            }
            else {
                if (P2 == "inseto")
                {
                    if (P3 == "hematofago")
                        Animal = "pulga";
                    else
                        Animal = "lagarta";
                }
                else {
                    if (P3 == "hematofago")
                        Animal = "sanguessuga";
                    else
                        Animal = "minhoca";
                }
            }

            Console.WriteLine(Animal);
        }
    }
}
