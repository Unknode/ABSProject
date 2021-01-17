using ABSProject.Entities.Enums;
using ABSProject.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABSProject.Entities {
    class FunctionsABS {

        public string ChooseType() { // função para escolha do pedido, retorna a opção selecionada. Caso for incorreta, gera uma exception

            Console.WriteLine("Escolha o tipo da bebida:");
            Console.WriteLine("1 - Refrigerante");
            Console.WriteLine("2 - Suco");
            string dec = Console.ReadLine();
            if(dec == "1") {
                return "Refrigerante";
            } else if(dec == "2") {
                return "Suco";
            } else {
                throw new TypeException("Opção do tipo incorreta, por favor verificar");
            }
        }

        public string ChooseDelivery() { // Função para escolha do tipo do pedido, se é viagem ou no local. Retorna uma exception caso a opção for inválida

            Console.WriteLine("Tipo do pedido?");
            Console.WriteLine("1 - Viagem");
            Console.WriteLine("2 - Comer no local");
            string orderType = Console.ReadLine();
            if(orderType == "1") {
                return "Tampa sem furo (Take Out)";
            } else if(orderType == "2") {
                return "Tampa com furo (Eat in)";
            } else {
                throw new DeliveryException("Opção de pedido incorreta, por favor verificar");
            }
        }

        public Enum ChooseFlavor(string choose) {// Função para verificar o sabor da bebida. Retorna um Enum com um dos sabores selecionado. Se a opção errada for selecionada, uma exception é gerada.

            if(choose == "Refrigerante") { //confere se o valor selecionado é Refrigerante, se não for, retorna como Suco.

                Console.WriteLine(" ");
                Console.WriteLine("Qual o sabor? ");
                Console.WriteLine("1 - Coca");
                Console.WriteLine("2 - Guarana");
                string dec = Console.ReadLine();

                if(dec == "1") { //verifica o sabor da bebida
                    Enum flavor = Enum.Parse<Flavor>("Coca");
                    return flavor;
                } else if(dec == "2") {
                    Enum flavor = Enum.Parse<Flavor>("Guarana");
                    return flavor;
                } else {
                    throw new FlavorException("Opção de sabor incorreta, por favor verificar");
                }
            } else { // Entra nesse else caso não for refrigerante
                Console.WriteLine(" ");
                Console.WriteLine("Qual o sabor? ");
                Console.WriteLine("1 - Uva");
                Console.WriteLine("2 - Laranja");
                string dec = Console.ReadLine();
                if(dec == "1") {
                    Enum flavor = Enum.Parse<Flavor>("Uva");
                    return flavor;
                } else if(dec == "2") {
                    Enum flavor = Enum.Parse<Flavor>("Laranja");
                    return flavor;
                } else {
                    throw new FlavorException("Opção de sabor incorreta, por favor verificar");
                }
            }
        }

        public string ChooseSize(string type) { // Função para selecionar o tamanho da bebida, caso for selecionada a opção errada uma exception é gerada.
            if(type == "Refrigerante") { //verifica se o tipo da bebida é Refrigerante ou suco
                Console.WriteLine(" ");
                Console.WriteLine("Qual o tamanho?");
                Console.WriteLine("1 - 300ml");
                Console.WriteLine("2 - 500ml");
                Console.WriteLine("3 - 700ml");
                string dec = Console.ReadLine();
                if(dec == "1") {
                    return "300ml";
                } else if(dec == "2") {
                    return "500ml";
                } else if(dec == "3") {
                    return "700ml";
                } else {
                    throw new SizeException("Opção de tamanho incorreta, por favor verificar");
                }


            } else { //else para retornar como suco
                Console.WriteLine(" ");
                Console.WriteLine("Qual o tamanho?");
                Console.WriteLine("1 - 300ml");
                Console.WriteLine("2 - 500ml");
                string dec = Console.ReadLine();

                if(dec == "1") {
                    return "300ml";
                } else if(dec == "2") {
                    return "500ml";
                } else {
                    throw new SizeException("Opção de tamanho incorreta, por favor verificar");
                }
            }
        }

        public int ChooseIceQuantity(string type) {//Função para verificar a opção de gelo
            Console.WriteLine(" ");
            Console.WriteLine("Deseja Gelo?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            string dec = Console.ReadLine();
            if(dec == "1" && type == "Refrigerante") {//caso for sim e o tipo for refrigerante, retorna o numero 6
                return 6;
            } else if(dec == "1" && type == "Suco") {//caso a opção for sim e o tipo for Suco, retorna o numero 12
                return 12;
            } else if(dec == "2") {
                return 0;
            } else {
                throw new IceException("Opção de gelo incorreta, por favor verificar"); //caso a opção digitada por errada, a exception é gerada
            }
        }

        public Enum ChooseCupType(string type) {//função para esoclha do tipo do copo. Não é gerada uma exception devido as funções anteriores impedirem de chegar a essa caso uma exception aparecer

            if(type == "Refrigerante") {
                Enum cupType = Enum.Parse<CupType>("Papel");
                return cupType;
            } else {
                Enum cupType = Enum.Parse<CupType>("Plastico");
                return cupType;
            }
        }


        public string AddOrder() { //opção para verificar se um novo pedido será adicionado
            Console.WriteLine(" ");
            Console.WriteLine("Deseja adicionar um novo pedido?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            string dec = Console.ReadLine();
            if(dec == "1") {
                return "1";
            } else if(dec == "2") {
                return "2";
            } else {
                throw new OrderException("Opção incorreta, por favor verificar"); //exception caso a opção for digitada errada
            }
        }
    
        public string ResumeOrders (List<Drink> drinks) {//função para listar todos os pedidos inseridos.
            Console.WriteLine("Deseja visualizar o pedido?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            string dec = Console.ReadLine();
            if(dec == "1") {
                foreach(Drink drink in drinks) {
                    Console.WriteLine(drink.ToString());
                }
                return "";
            }
            else if (dec =="2") {
                return "Pedido realizado";
            }
            else {
                throw new ResumeException("Opção incorreta, por favor verificar"); //exception caso haja uma opção errada
            }
            }
    }
}
