using System;
using System.Collections.Generic;
using System.Text;

namespace GameTest.Entities {
    class Partida {

        public int Round { get; set; }

        public Character Player1 { get; set; }
        public Character Player2 { get; set; }

        public Partida() { }

        public Partida(int round, Character player1, Character player2) {
            Round = round;
            Player1 = player1;
            Player2 = player2;
        }

    }
}
