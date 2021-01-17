using System;
using System.Collections.Generic;
using ABSProject.Entities;
using ABSProject.Entities.Enums;
using ABSProject.Entities.Exceptions;

namespace ABSProject {
    class Program {
        static void Main(string[] args) {
            string dec;
            string orderType;
            string type;
            Enum flavor;
            Enum cupType;
            string size;
            int iceCount;
            List<Drink> drinks = new List<Drink>();
            FunctionsABS ABS = new FunctionsABS();


            do {
                try {
                    orderType = ABS.ChooseDelivery();
                } catch(DeliveryException e) {
                    Console.WriteLine(e.Message);
                    orderType = ABS.ChooseDelivery();
                }
                try {
                    type = ABS.ChooseType();
                } catch(TypeException e) {
                    Console.WriteLine(e.Message);
                    type = ABS.ChooseType();
                }
                try {
                    flavor = ABS.ChooseFlavor(type);
                } catch(FlavorException e) {
                    Console.WriteLine(e.Message);
                    flavor = ABS.ChooseFlavor(type);
                }
                cupType = ABS.ChooseCupType(type);
                try {
                    size = ABS.ChooseSize(type);
                } catch(SizeException e) {
                    Console.WriteLine(e.Message);
                    size = ABS.ChooseSize(type);
                }
                try {
                    iceCount = ABS.ChooseIceQuantity(type);
                } catch(IceException e) {
                    Console.WriteLine(e.Message);
                    iceCount = ABS.ChooseIceQuantity(type);
                }
                Drink drink = new Drink(type,flavor,cupType,iceCount,size,orderType);
                drinks.Add(drink);
                try {
                    Console.WriteLine(drink.ToString());
                    dec = ABS.AddOrder();
                } catch(OrderException e) {
                    Console.WriteLine(e.Message);
                    dec = ABS.AddOrder();
                }
            } while(dec == "1");

            try {
                ABS.ResumeOrders(drinks);
            } catch(ResumeException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("");
                ABS.ResumeOrders(drinks);
            }
        }

    }
}







