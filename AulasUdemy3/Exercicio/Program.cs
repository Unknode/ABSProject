using AulasUdemy2.Entities;
using AulasUdemy2.Entities.Enums;
using System;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;

namespace AulasUdemy2 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter departament's name");
            string dptName = Console.ReadLine();
            Departament dpt = new Departament(dptName);
            Console.WriteLine("\n");
            Console.WriteLine("Now, enter with worker data");
            Console.WriteLine("Insert the name of worker");
            string name = Console.ReadLine();
            Console.WriteLine("Level:");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Insert the base salary");
            double salary = double.Parse(Console.ReadLine());
            Worker worker = new Worker(name, level, salary, dpt);
            Console.WriteLine("How many contracts to this worker:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Enter #{0} contract data", i + 1);
                Console.WriteLine("Contract ID:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Date:");
                string date = Console.ReadLine();
                DateTime dt1 = DateTime.Parse(date);
                Console.WriteLine("Value per hours");
                double value = double.Parse(Console.ReadLine());
                Console.WriteLine("Hours:");
                int hours = int.Parse(Console.ReadLine());
                Contract contract = new Contract(dt1, value, hours, id);
                Console.WriteLine(worker.AddContract(contract));
            }

            Console.WriteLine("Enter month and year to calculate income ");
            string imput = Console.ReadLine();
            int[] yearMonth = Array.ConvertAll(imput.Split("/"), int.Parse);
            Console.WriteLine("\n");
            Console.WriteLine("Name:{0}", worker.Name);
            Console.WriteLine("Departament:{0}", dpt.Name);
            Console.WriteLine("Income for {0}: {1}", imput, worker.InCome(yearMonth[0], yearMonth[1]));
            Console.WriteLine(" ");

            Console.WriteLine("Contracts:");
            Console.WriteLine(" ");

            foreach (Contract cont in worker.Contracts) {
                Console.WriteLine("Contract ID: {0}", cont.ID);
                Console.WriteLine("Value per hour: {0}", cont.ValuePerHour);
                Console.WriteLine("Hours worked:{0}", cont.Hours);
                Console.WriteLine("Date: {0}", cont.Date);
                Console.WriteLine("Total Value: {0}", cont.TotalValue());
                Console.WriteLine(" ");
            }

            Console.WriteLine("Enter ID that you wanna remove");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine(worker.RemoveContract(code));

            foreach (Contract cont in worker.Contracts) {
                Console.WriteLine("Contract ID: {0}", cont.ID);
                Console.WriteLine("Value per hour: {0}", cont.ValuePerHour);
                Console.WriteLine("Hours worked:{0}", cont.Hours);
                Console.WriteLine("Date: {0}", cont.Date);
                Console.WriteLine("Total Value: {0}", cont.TotalValue());
                Console.WriteLine(" ");
            }

        }
    }
}