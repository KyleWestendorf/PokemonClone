using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{

    public class Pokemon : IPokemon
    {
       public string Name { get; set;  }
       public int HP { get; set; }
       public int AttackStat { get; set; }
       public int DefenseStat { get; set; }
       public PokemonType Type { get; set; }

       private int _currentHP;

       public int CurrentHP
        {
            get
            {
                return _currentHP;
            }

            set
            {
                if(!(value > this.HP)) {
                    _currentHP = value;

                } else
                {
                    throw new Exception("Value cannot be set higher than Max HP");
                }
               
            }
        }

        public Pokemon(string name, int hp, int attackStat, int defenseStat, PokemonType type)
        {
            Name = name;
            HP = hp;
            AttackStat = attackStat;
            DefenseStat = defenseStat;
            Type = type;
            _currentHP = HP;
        }
        
    }
}
