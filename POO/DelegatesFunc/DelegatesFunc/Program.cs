﻿using DelegatesFunc.Entities;
using System.Linq;

List<Product> list = new();

list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.00));
list.Add(new Product("HD Case", 80.90));

//Func<Product, string> func = NameUpper;
//Func<Product, string> func = p => p.Name.ToUpper();

List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

foreach (string s in result)
{
    Console.WriteLine(s);
}

// Func auxiliar
//static string NameUpper(Product p)
//{
//    return p.Name.ToUpper();
//}


