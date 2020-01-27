using Composition_csharp.Entities;
using Composition_csharp.Entities.Enums;
using System;

namespace Composition_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = Convert.ToDateTime(Console.ReadLine(), new System.Globalization.CultureInfo("pt-BR"));

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(orderStatus, client);

            Console.Write("How many items to this order? ");
            int quantityOfItems = int.Parse(Console.ReadLine());

            for(int i=1; i<=quantityOfItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, product);

                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine(order.ToString());
        }
    }
}
