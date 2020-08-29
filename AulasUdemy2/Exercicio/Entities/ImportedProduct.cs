using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AulasUdemy4.Entities {
    class ImportedProduct : Product {

        public double CustomsFee { get; set; }

        public ImportedProduct() {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price) {
            CustomsFee = customsFee;
        }


        public override string PriceTag() {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name).Append(" $").Append(Price).Append(" (Customs Fee:").Append(CustomsFee).AppendLine(")");

            return sb.ToString();
        }
        public double TotalPrice() {
            return CustomsFee + Price;
        }
    }
}
