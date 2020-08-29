using ProjetoUdemy2.Entities;
using ProjetoUdemy2.Entities.Enums;
using System;
using System.ComponentModel;

namespace ProjetoUdemy2 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter Client Data:");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Email:");
            string email = Console.ReadLine();
            Console.Write("Birthdate:");
            DateTime dt = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, dt);
            Console.WriteLine("Enter order data:");
            Order order = new Order();
            order.Client = client;
            order.Status = Enum.Parse<OrderStatus>("Processing");

            Console.WriteLine("How many itens to this order?");
            int n = int.Parse(Console.ReadLine());

                
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Enter with {0}# data", i );
                Console.WriteLine("Product name:");
                string pName = Console.ReadLine();
                Console.WriteLine("Product price:");
                double pPrice = double.Parse(Console.ReadLine());
                Product pd = new Product(pName, pPrice);
                Console.WriteLine("Quantity:");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem od = new OrderItem(quantity, pPrice, pd);
                order.AddItem(od);
            }
            order.Date = DateTime.Now;

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}
