using Delegates.Entities;

List<Product> list = new();

list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.00));
list.Add(new Product("HD Case", 80.90));

// Utilizando o Action e passando a função como argumento.
// Action<Product> act = UpdatePrice;

Action<Product> act = p => { p.Price += p.Price * 0.1 };

foreach (Product p in list)
{
    Console.WriteLine(p);
}


// Função auxiliar
static void UpdatePrice(Product p)
{
    p.Price += p.Price * 0.1;
}
