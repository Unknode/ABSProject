using ABSProject.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABSProject.Entities {
    class FunctionsABS {

         public string ChooseType() { // retorna a opção escolhida no menu
            Console.WriteLine("Escolha o tipo da bebida:");
            Console.WriteLine("1 - Refrigerante");
            Console.WriteLine("2 - Suco");
            string dec = Console.ReadLine();
            if(dec == "1") {
                return "Refrigerante";
            } else {
                return "Suco";
            }
        }

        public string ChooseDelivery() { // retorna a opção escolhida no menu

            Console.WriteLine("Viagem ou para beber no local?");
            string orderType = Console.ReadLine();
            if(orderType == "Viagem") {
                return "Tampa sem furo (Take Out)";
            } else {
                return "Tampa com furo (Eat in)";
            }
        }

        public  Enum ChooseFlavor(string choose) {// retorna a opção escolhida no menu

            if(choose == "Refrigerante") {
                Console.WriteLine("Qual o sabor? ");
                Console.WriteLine("Coca");
                Console.WriteLine("Guarana");
                Enum flavor = Enum.Parse<Flavor>(Console.ReadLine());
                return flavor;
            } else {
                Console.WriteLine("Qual o sabor? ");
                Console.WriteLine("Uva");
                Console.WriteLine("Laranja");
                Enum flavor = Enum.Parse<Flavor>(Console.ReadLine());
                return flavor;
            }
        }

        public string ChooseSize(string type) { // retorna a opção escolhida no menu
            if(type == "Refrigerante") {
                Console.WriteLine("Qual o tamanho?");
                Console.WriteLine("300ml");
                Console.WriteLine("500ml");
                Console.WriteLine("700ml");
                return Console.ReadLine();
            } else {
                Console.WriteLine("Qual o tamanho?");
                Console.WriteLine("300ml");
                Console.WriteLine("500ml");
                return Console.ReadLine();
            }

        }

        public int ChooseGelo(string type) {// retorna a opção escolhida no menu

            Console.WriteLine("Deseja Gelo?");
            string dec = Console.ReadLine();
            if(dec == "Sim" && type == "Refrigerante") {
                return 6;
            } else if(dec == "Sim" && type == "Suco") {
                return 12;
            } else
                return 0;
        }

        public Enum ChooseCupType(string type) {// retorna a opção escolhida no menu

            if(type == "Refrigerante") {
                Enum cupType = Enum.Parse<CupType>("Papel");
                return cupType;
            } else {
                Enum cupType = Enum.Parse<CupType>("Plastico");
                return cupType;
            }
        }
    }
}
