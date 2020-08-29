using System;
using System.Collections.Generic;
using System.Text;

namespace AulasUdemy4.Entities {
    class UsedProduct : Product {

        public DateTime ManufactureDate { get; set; }

        public UsedProduct() {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price) {
            ManufactureDate = manufactureDate;
        }



        public override string PriceTag() {

            StringBuilder sb = new StringBuilder();
            sb.Append(Name).Append(" (used)").Append(" $").Append(Price).Append("(Manufacture date: ").Append(ManufactureDate).Append(")");

            return sb.ToString();
           
        }
    }
}
