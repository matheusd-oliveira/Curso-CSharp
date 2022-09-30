namespace ContaBancaria
{
    class ContaBancaria
    {
        private string _nome;
        public int NumeroDaConta { get; private set; }
        public double SaldoBancario { get; private set; }


        public ContaBancaria() { }

        public ContaBancaria(string nome, int numeroDaConta)
        {
            _nome = nome;
            NumeroDaConta = numeroDaConta;
        }

        public ContaBancaria(string nome, int numeroDaConta, double saldoBancario)
        {
            _nome = nome;
            NumeroDaConta = numeroDaConta;
            SaldoBancario = saldoBancario;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
            }
        }

        public void Depositar(double deposito)
        {
            SaldoBancario += deposito;

        }

        public void Sacar(double saque)
        {
            SaldoBancario -= saque;
            SaldoBancario -= 5.00;
        }


        public override string ToString()
        {
            return "Conta " + NumeroDaConta
                + ", Titular: " + Nome
                + ", Saldo: $ " + SaldoBancario.ToString("F2");


        }
    }
}
