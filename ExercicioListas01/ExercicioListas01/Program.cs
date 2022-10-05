using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioListas01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Emplyoee #{i}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Employee emp = new Employee(id, name, salary);
                employees.Add(emp);
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == searchId)
                {
                    Console.Write("Enter the percentage: ");
                    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees[i].IncreaseSalary(percentage);
                    break;
                    
                }
                else
                {
                    Console.WriteLine("This id does not exist!");
                    break;
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:\n ");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
   
        }
    }
}
