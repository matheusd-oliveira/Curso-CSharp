using Cadastro.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;


namespace Cadastro.UI
{
    class Screen
    {
        public void ScreenInit()
        {
            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new IndividualEntity(name, income, expenditures));
                }
                else
                {
                    Console.Write("Numbers of employees: ");
                    int emp = int.Parse(Console.ReadLine());
                    list.Add(new LegalEntity(name, income, emp));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double sum = 0.0;
            foreach (Person p in list)
            {
                Console.WriteLine(p.Name + ": $ " + p.TaxCalculation().ToString("F2", CultureInfo.InvariantCulture));
                sum += p.TaxCalculation();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
