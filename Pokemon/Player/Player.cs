using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Player
    {
        
        public string Name { get; set; }
        public PlayerPokemon[] Team { get; set; } = new PlayerPokemon[6];
        public PlayerPokemon ActivePokemon { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        //TODO: Allow option to drop a pokemon
        public void AddPokemon(PlayerPokemon pokemon)
        {
            for (int i = Team.Length - 1; i >= 0; i--)
            {
                if (Team[i] == null)
                {
                    Team[i] = pokemon;
                    Console.WriteLine($"{pokemon.Name} added to {Name}'s team!");
                    return;
                }
             
            }
            Console.WriteLine("No space for your Pokemon!");
            return;
        }
    }
}
