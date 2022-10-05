using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Declarando uma lista.
            List<string> list = new List<string>();

            // Adicionando elementos em uma lista.
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            // Adicionando elementos em um determinado indice
            list.Insert(2, "Marco");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            
            // Contando quantos elementos a lista possui
            Console.WriteLine("List count: " + list.Count);

            // Como encontrar um elemento na lista utilizando lambda
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);
            
            // Como encontrar o ultimo elemento na lista de acordo com a expresssão lambda
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            // Encontrar a primeira posição de um elemento que esteja de acordo com a expressão lambda
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            // Encontrar a ultima posição de um elemento que esteja de acordo com a expressão lambda
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            // Filtrar a lista de acordo com a expressão proposta.
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------");
            Console.WriteLine("Filtrando a Lista: ");
            Console.WriteLine();
            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            // Removendo elementos da lista
            list.Remove("Alex");
            Console.WriteLine("-----------------");
            Console.WriteLine("Removendo elementos da lista: ");
            Console.WriteLine();
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            // Removendo todos os elementos de acordo com a expressão proposta
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-----------------");
            Console.WriteLine("Removendo elementos da lista que começam com a letra M: ");
            Console.WriteLine();
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            // Removendo elementos em uma posição especifica da lista 2:
            list2.RemoveAt(1);
            Console.WriteLine("-----------------");
            Console.WriteLine("Removendo elemento da lista em determinado indice: ");
            Console.WriteLine();
            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
