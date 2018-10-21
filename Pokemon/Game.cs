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
        public bool GameOver {get; set; } = false;

        public Game(Player player )
        {
            Player = player;
        }

        public async void Move()
        {
            MoveCounter++;
            //if (MoveCounter % 3 == 0)
            //{
            //    EnterPlayerBattle();
            //}
            if(MoveCounter % 5 == 0) {

                await WildPokemonBattle();
             }
}

        private async Task WildPokemonBattle()
        {
            PokemonDb db = new PokemonDb("https://pokeapi.co/api/v2");

            Pokemon randomPokemon = await db.RetrievePokemon();

            WildPokemonEncounter encounter = new WildPokemonEncounter(Player.ActivePokemon, randomPokemon);

            Console.WriteLine($"Player encountered a {randomPokemon.Name}!");
            while (Player.ActivePokemon.CurrentHP > 0 && randomPokemon.CurrentHP > 0)
            {
                if(encounter.EncounterOver == true) {
                    return;
                }
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
