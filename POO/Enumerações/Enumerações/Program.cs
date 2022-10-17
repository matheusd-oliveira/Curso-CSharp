using Enumerações.Entities;
using System;
using Enumerações.Entities.Enums;

namespace Enumerações
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // Enum para string
            string txt = OrderStatus.PendingPayment.ToString();
            

            // String para enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
