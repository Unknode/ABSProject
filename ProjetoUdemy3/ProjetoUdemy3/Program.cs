using ProjetoUdemy3.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProjetoUdemy3 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("How many users will be registered?");
            int n = int.Parse(Console.ReadLine());

            List<Employee> Employees = new List<Employee>();

            for (int i = 0; i < n; i++) {

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value Per Hour: ");
                double value = double.Parse(Console.ReadLine());
                Console.WriteLine("Addictional charge: ");
                double ac = double.Parse(Console.ReadLine());
                Console.WriteLine("Outsorced?");
                string dec = Console.ReadLine();
                if (dec == "s") {
                    Employees.Add(new OutSourcedEmployee(name, hours, value, ac));
                }

                else {
                    Employees.Add(new Employee(name, hours, value));
                }
            }
            Console.WriteLine("Payments");
            Console.WriteLine(" ");
            foreach (Employee emp in Employees) {
                Console.WriteLine(emp.Name, " - ", "$", +emp.Payment());
            }

        }
    }
}
