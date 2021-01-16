using GameTest.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameTest.Entities {
    class Character {

        public string Name { get; set; }
        public Races Race { get; set; }
        public List<Poderes> Powers { get; set; }

        public int LifePoints { get; set; }

        public int ActionPoints { get; set; }

        public bool DefensePosition { get; set; }


        public Character() { }
        public Character(string name,Races race,List<Poderes> powers,int lifePoints,int actionPoints) {
            Name = name;
            Race = race;
            Powers = powers;
            LifePoints = lifePoints;
            ActionPoints = actionPoints;
        }
    
       public int Strike(Poderes pwr) {

            if (pwr.Cost < ActionPoints) {

                return pwr.Damage;
            }
        
            else {
                return 0;
            }
        }
    
        public void Defense (string dec) {

            if (dec == "Sim" || dec == "sim") {
                DefensePosition = true;
            }
            else {
                DefensePosition = false;
            }
        }
    }
}
