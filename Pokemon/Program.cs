﻿using System;
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

            IPokemon Charizard = new PlayerPokemon("Silas", 100, 50, 60, PokemonType.Fire);
            IPokemon Blastoise = new Pokemon("Blastoise", 100, 70, 80, PokemonType.Water);

            Battle battle = new Battle(Charizard, Blastoise);

            battle.CompleteBattle();

        }
    }
}