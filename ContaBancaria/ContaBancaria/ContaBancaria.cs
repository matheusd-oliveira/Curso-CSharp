using System.Globalization;

namespace ContaBancaria
{
    class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string Titular { get; set; }
        public double SaldoBancario { get; private set; }


        public ContaBancaria(int numeroDaConta, string titular)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
        }

        public ContaBancaria(int numeroDaConta, string titular, double depositoInicial) : this(numeroDaConta, titular)
        {
            Depositar(depositoInicial);
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
            return "Conta " 
                + NumeroDaConta
                + ", Titular: " 
                + Titular
                + ", Saldo: $ " 
                + SaldoBancario.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
