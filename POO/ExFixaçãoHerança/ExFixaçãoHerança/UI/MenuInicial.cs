using ExFixaçãoHerança.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;


namespace ExFixaçãoHerança.UI
{
    class Menu
    {
        public Menu() { }

        public void TelaInicial()
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, fee));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    if (type == 'c')
                        list.Add(new Product(name, price));
                    else
                    {
                        Console.WriteLine("Você digitou algo errado! O programa será finalizado. Por favor, tente novamente!");
                        Environment.Exit(0);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product p in list)
            {
                Console.WriteLine(p.PriceTag());
            }


        }
    }
}
