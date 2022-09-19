using System;

namespace _1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;

            senha = int.Parse(Console.ReadLine());
            
            if(senha == 2002)
                Console.WriteLine("Acesso Permitido");
            else
                Console.WriteLine("Senha Invalida");
            while (true)
            {
                senha = int.Parse(Console.ReadLine());
                if (senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                Console.WriteLine("Senha Invalida");
                
            }
        }
    }
}
