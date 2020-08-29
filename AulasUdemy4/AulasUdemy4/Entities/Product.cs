using System;
using System.Collections.Generic;
using System.Text;

namespace AulasUdemy4.Entities {
    class Product {

        public string Name { get; set;}
        public double Price { get; set; }

        public Product() {
        }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }
    
        public virtual string PriceTag() {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name).Append(" $").Append(Price);

            return sb.ToString();
        } 
    
    
    }
}
