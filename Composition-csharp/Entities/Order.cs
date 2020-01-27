using Composition_csharp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composition_csharp.Entities
{
    class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; private set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(){ }
        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
            Moment = DateTime.Now;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");
            foreach(OrderItem orderItem in Items)
            {
                sb.AppendLine(orderItem.ToString());
            }
            sb.AppendLine($"Total price: ${this.Total().ToString("F2")}");

            return sb.ToString();

        }
    }
}
