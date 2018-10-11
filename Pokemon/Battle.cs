using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Battle
    {
        public IPokemon PlayerPokemon { get; set; }
        public IPokemon AIPokemon { get; set; }
        public Turn Turn { get; set; }


        public Battle(IPokemon playerPokemon, IPokemon aiPokemon)
        {
            PlayerPokemon = playerPokemon;
            AIPokemon = aiPokemon;
            Turn = new Turn();
        }

        public void TakeTurn()
        {
            Turn.CompleteTurn(PlayerPokemon, AIPokemon);
        }

        public void CompleteBattle()
        {
            while (PlayerPokemon.HP > 0 && AIPokemon.HP > 0)
            {
                TakeTurn();

            }

        }
    }
}
