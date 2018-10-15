using Pokemon.Encounters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Game
    {
        public Player Player { get; set; }
        public int MoveCounter { get; set; } = 1;

        public Game(Player player )
        {
            Player = player;
        }

        public void Move()
        {
            MoveCounter++;
            //if (MoveCounter % 3 == 0)
            //{
            //    EnterPlayerBattle();
            //}
            if(MoveCounter % 5 == 0) {

                WildPokemonBattle();
             }
}

        private void WildPokemonBattle()
        {
            IPokemon Blastoise = new Pokemon("Blastoise", 100, 70, 80, PokemonType.Water);

            WildPokemonEncounter encounter = new WildPokemonEncounter(Player.ActivePokemon, Blastoise);

            Console.WriteLine($"Player encountered a {Blastoise.Name}!");
            while (Player.ActivePokemon.CurrentHP > 0 && Blastoise.CurrentHP > 0)
            {
                Console.WriteLine("Press a to attack");
                Console.WriteLine("Press c to attempt capture");
                string response = Console.ReadLine();

                if(response == "a")
                {
                    encounter.TakeTurn();

                } else if (response == "c") { 
                    encounter.AttemptToCatchPokemon(Player);
                }
            }
        }
    }


    
}
