using System;
using HerançaEPolimorfismo.Entities;

namespace HerançaEPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
            SavingsAccount acc3 = new SavingsAccount(1003, "Xupeta", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            acc3.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine(acc3.Balance);
        }
    }
}
