﻿using ExercicioDeFixaçaoComposições.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioDeFixaçaoComposições.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }


        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }


        public void AddItem(OrderItem item)
        {
            OrderItem.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItem.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem order in OrderItem)
            {
                sum += order.SubTotal();
            }

            return sum;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + Status.ToString());
            sb.AppendLine("Client: " + Client.Name);
            sb.AppendLine("Order items: ");

            foreach (OrderItem item in OrderItem)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();


        }
    }
}
