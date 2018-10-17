using Pokemon.Encounters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {

            //MainAsync().Wait();
            

            IPokemon Charizard = new PlayerPokemon("Silas", 100, 50, 60, PokemonType.Fire);
            //IPokemon Blastoise = new Pokemon("Blastoise", 100, 70, 80, PokemonType.Water);
            Player Kyle = new Player("Kyle");
            Kyle.AddPokemon((PlayerPokemon)Charizard);
            Kyle.ActivePokemon = Kyle.Team[5];
            
            //WildPokemonEncounter battle = new WildPokemonEncounter(Charizard, Blastoise);
            Game Game = new Game(Kyle);

            Game.Move();
            Game.Move();
            Game.Move();
            Game.Move();

            //battle.TakeTurn();
            //battle.TakeTurn();
            //battle.TakeTurn();

            //battle.AttemptToCatchPokemon(Kyle);

            Console.ReadLine();
        }

        //static async Task MainAsync()
        //{
        //    PokemonDb db = new PokemonDb("https://pokeapi.co/api/v2");


        //    //IEnumerable<APIPokemonList> response = await db.ListAll("pokemon/");
        //    //List<APIPokemonList> PokemonList = response.ToList();

        //    Pokemon pokemon = await db.RetrievePokemon();

       
        //}

    }

    
}
