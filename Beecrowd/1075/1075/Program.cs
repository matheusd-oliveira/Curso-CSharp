﻿using System;

namespace _1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 2; i < 10000; i++)
            {
                if ( i % N == 2)
                    Console.WriteLine(i);
            }
        }
    }
}
