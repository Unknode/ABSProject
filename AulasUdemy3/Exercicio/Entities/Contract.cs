using System;
using System.Collections.Generic;
using System.Text;

namespace AulasUdemy2.Entities {
    class Contract {

        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int ID { get; set; }
        public int Hours { get; set; }

        public Contract () { }

        public Contract(DateTime date, double valuePerHour, int hours, int id) {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
            ID = id;
        }
  
        public double TotalValue () {

            return ValuePerHour * Hours;
        }
    
    
    }
}
