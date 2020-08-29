using AulasUdemy4.Entities;
using System;
using System.Collections.Generic;

namespace AulasUdemy4 {
    class Program {
        static void Main(string[] args) {

            List<Product> products = new List<Product>();
            Console.WriteLine("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Product # {0} data", i + 1);
                Console.WriteLine("Common, used or imported? (c/u/i)");
                string dec = Console.ReadLine();
                if (dec == "i") {
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Customs Fee: ");
                    double custom = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, custom));
                }
                else if (dec == "c") {
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    products.Add(new Product(name, price));

                }
                else {
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Manufacture date (DD/MM/YYYY: ");
                    DateTime dt = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, dt));
                }
            }
            Console.WriteLine("Price tags:");

            foreach (Product pd in products) {
                Console.WriteLine(pd.PriceTag());
            }

        
        }
    }
}
