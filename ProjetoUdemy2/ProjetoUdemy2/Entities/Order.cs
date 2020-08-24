using ProjetoUdemy2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoUdemy2.Entities {
    class Order {

        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }


        public Order() { }

        public Order(Client client, DateTime date, OrderStatus status) {
            Client = client;
            Date = date;
            Status = status;
        }

        public void AddItem(OrderItem item) {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Items.Remove(item);

        }
        public double Total() {

            double value = 0;

            foreach (OrderItem item in Items) {
                value += item.SubTotal();
            }
            return value;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.Append("Order Moment: ").Append(Date).AppendLine();
            sb.Append("Order Satus: ").Append(Status).AppendLine();
            sb.Append("Client: ").Append(Client.Name).Append(Client.BirthDate).Append(Client.BirthDate).AppendLine();
            sb.AppendLine("Order Items: ");
            foreach (OrderItem it in Items) {
                sb.Append(it.Product.Name).Append("Quantity: ").Append(it.Quantity).Append("SubTotal: ").Append(it.SubTotal()).AppendLine();
            }
            sb.Append("Total: ").Append(Total());

            return sb.ToString();
        }

    }
}
