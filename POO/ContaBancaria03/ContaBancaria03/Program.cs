﻿using ContaBancaria03.Entities;
using ContaBancaria03.Entities.Exceptions;
using System;
using System.Globalization;

namespace ContaBancaria03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account acc = new Account(number, holder, balance, withdrawLimit);

                acc.Withdraw(amount);
                acc.UpdateBalance();
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
