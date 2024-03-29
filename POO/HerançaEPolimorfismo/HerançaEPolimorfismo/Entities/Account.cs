﻿namespace HerançaEPolimorfismo.Entities
{
    class Account
    {   
        /// <summary>
        /// Propriedades: 
        /// Numero da conta, Titular da conta e Saldo da conta.
        /// </summary>
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }


        public Account() { }


        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        /// <summary>
        /// Método para realização do saque.
        /// </summary>
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        /// <summary>
        /// Método para realização do depósito.
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
