using System;
using System.Collections.Generic;
using System.Text;

namespace GameTest.Entities {
    class Poderes {

        public string Name { get; set; }
        public int Cost { get; set; }
        public int Damage { get; set; }
        public int Heal { get; set; }


        public Poderes(string name,int damage,int cost) {
            Name = name;
            Damage = damage;
            Cost = cost;
        }

        public Poderes() { }
    
    }
}
