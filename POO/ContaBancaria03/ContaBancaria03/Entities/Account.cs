using ContaBancaria03.Entities.Exceptions;
using System;
using System.Globalization;

namespace ContaBancaria03.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }


        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }



        public void Withdraw(double amount)
        {
            if (Balance <= 0)
            {
                throw new DomainException("Doesn't have Balance in your account. You can't do any Withdraw.");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Try to put an amount lower than the withdraw limit.");
            }
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void UpdateBalance()
        {
            Console.WriteLine("New Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
