using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double Deposito = 0.0, Saque = 0.0;

            ContaBancaria conta = new ContaBancaria();

            Console.Write("Entre com o número da conta: ");
            int Numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string Titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");

            string IsDeposit = Console.ReadLine();
            if (IsDeposit == "s")
            {
                Console.Write("Entre com o valor de depósito incial: ");
                Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(Titular, Numero, Deposito);

                Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);
                Console.WriteLine();
            }
            else
            {
                conta = new ContaBancaria(Titular, Numero);

                Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);
                Console.WriteLine();
            }
            
            Console.Write("Entre com um valor para depósito: ");
            Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(Deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(Saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            

            


        }
    }
}
