using ABSProject.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABSProject.Entities {
    class Drink {

        public string Type { get; set; }
        public Enum Flavor { get; set; }
        public Enum CupType { get; set; }
        public int IceQuantity { get; set; }
        public string Size { get; set; }
        public string OrderType { get; set; }

        public Drink() { }

        public Drink(string type,Enum flavor,Enum cupType,int iceCount,string size,string orderType) {
            Type = type;
            Flavor = flavor;
            CupType = cupType;
            IceQuantity = iceCount;
            Size = size;
            OrderType = orderType;
        }




        public override string ToString() { //Retorna o objeto em formato de string para facilitar o print
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Seu pedido é: ").Append(Type + " ").Append("Sabor: " + Flavor).Append(", Copo: " + CupType).Append(", Cubos de gelo:" + IceQuantity);
            sb.Append(", Tamanho: " + Size).Append(", Tipo da Tampa: " + OrderType);

            return sb.ToString();

        }

    }
}
