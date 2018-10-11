using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public enum PokemonType
    {
        Fire,
        Water,
        Grass
    }

    public interface IPokemon
    {
        string Name { get; set; }
        int HP { get; set; }
        int AttackStat { get; set; }
        int DefenseStat { get; set; }
        PokemonType Type { get; set; }

    }
}
