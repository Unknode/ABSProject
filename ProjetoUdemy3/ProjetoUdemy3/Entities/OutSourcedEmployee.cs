using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoUdemy3.Entities {
        class OutSourcedEmployee : Employee {

        public double AddctionalCharge { get; set; }

        public OutSourcedEmployee () {

        }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double addctionalCharge) : base (name, hours, valuePerHour){
            AddctionalCharge = addctionalCharge;
        }

        public override double Payment() {

            return base.Payment() + AddctionalCharge * 1.1;
        }

    }
}
