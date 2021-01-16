using System;
using GameTest.Enums;
using GameTest.Entities;
using System.Collections.Generic;

namespace GameTest {
    class Program {
        static void Main(string[] args) {


            Console.WriteLine("Seja bem vindo a partida");
            Console.WriteLine("Deseja criar seu personagem?");
            string dec = Console.ReadLine();
            if(dec == "sim") {


                Console.WriteLine("Insira o nome do seu personagem");
                string name = Console.ReadLine();
                Console.WriteLine("Escolha a raça do seu personagem:");
                Console.WriteLine("Human");
                Console.WriteLine("Elf");
                Console.WriteLine("Dwarf");
                Console.WriteLine("Demon");
                string chooseRace = Console.ReadLine();
                Races race = Enum.Parse<Races>(chooseRace);

                if(chooseRace == "Human") {
                    List<Poderes> powers = new List<Poderes>();
                    int lifePoints = 5;
                    int actionPoints = 3;

                    powers.Add(new Poderes {
                        Name = "Ataque forte",
                        Cost = 2,
                        Damage = 2
                    });

                    powers.Add(new Poderes {
                        Name = "Ataque fraco",
                        Cost = 1,
                        Damage = 1
                    });

                    powers.Add(new Poderes {
                        Name = "Cura",
                        Cost = 2,
                        Heal = 2
                    });

                    Character player1 = new Character(name,race,powers,lifePoints,actionPoints);
                } else if(dec == "Elf") {

                    List<Poderes> powers = new List<Poderes>();
                    int lifePoints = 4;
                    int actionPoints = 4;

                    powers.Add(new Poderes {
                        Name = "Ataque forte",
                        Cost = 2,
                        Damage = 2
                    });

                    powers.Add(new Poderes {
                        Name = "Ataque fraco",
                        Cost = 1,
                        Damage = 1
                    });

                    powers.Add(new Poderes {
                        Name = "Cura",
                        Cost = 2,
                        Heal = 2
                    });

                    Character player1 = new Character(name,race,powers,lifePoints,actionPoints);
                } else if(dec == "Dwarf") {

                    List<Poderes> powers = new List<Poderes>();
                    int lifePoints = 5;
                    int actionPoints = 4;

                    powers.Add(new Poderes {
                        Name = "Ataque forte",
                        Cost = 2,
                        Damage = 2
                    });

                    powers.Add(new Poderes {
                        Name = "Ataque fraco",
                        Cost = 1,
                        Damage = 1
                    });

                    powers.Add(new Poderes {
                        Name = "Entrar em guarda",
                        Cost = 2,
                        Heal = 2
                    });

                    Character player1 = new Character(name,race,powers,lifePoints,actionPoints);
                }
            }



        }
    }
}
