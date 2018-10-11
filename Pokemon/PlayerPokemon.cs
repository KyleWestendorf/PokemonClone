using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class PlayerPokemon : Pokemon
    {

        public PlayerPokemon(string name, int hp, int attackStat, int defenseStat, PokemonType type) : base(name, hp, attackStat, defenseStat, type)
        {
            
        }
    }
}
