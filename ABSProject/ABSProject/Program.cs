using System;
using ABSProject.Entities;
using ABSProject.Entities.Enums;

namespace ABSProject {
    class Program {
        static void Main(string[] args) {
            string dec;
            FunctionsABS ABS = new FunctionsABS();

            do {
                string orderType = ABS.ChooseDelivery();
                Console.WriteLine(" ");
                string type =ABS.ChooseType();
                Console.WriteLine(" ");
                Enum flavor = ABS.ChooseFlavor(type);
                Console.WriteLine(" ");
                Enum cupType = ABS.ChooseCupType(type);
                Console.WriteLine(" ");
                string size = ABS.ChooseSize(type);
                Console.WriteLine(" ");
                int iceCount = ABS.ChooseGelo(type);
                Console.WriteLine(" ");
                Drink drink = new Drink(type,flavor,cupType,iceCount,size,orderType);
                Console.WriteLine(drink.ToString());
                Console.WriteLine(" ");
                Console.WriteLine("Deseja adicionar um novo pedido?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                dec = Console.ReadLine();
            } while(dec == "1");
            }

        


    }
}
