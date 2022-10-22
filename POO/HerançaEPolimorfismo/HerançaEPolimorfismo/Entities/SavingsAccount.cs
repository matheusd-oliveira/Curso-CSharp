namespace HerançaEPolimorfismo.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }


        public SavingsAccount() { }


        public SavingsAccount(int number, string holder, double balance, double interestRate)
        : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        /// <summary>
        /// Método para atualizar o Saldo.
        /// </summary>
        public void UpdateBalance() {

            Balance += Balance * InterestRate;
        }
    }
}
