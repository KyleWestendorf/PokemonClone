using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class PlayerBattle : IEncounter
    {
        public IPokemon PlayerPokemon { get; set; }
        public IPokemon AIPokemon { get; set; }
        public Turn Turn { get; set; } = new Turn();

        public PlayerBattle(IPokemon playerPokemon, IPokemon aiPokemon)
        {
            PlayerPokemon = playerPokemon;
            AIPokemon = aiPokemon;
          
        }


        public void TakeTurn()
        {
            Turn.CompleteTurn(PlayerPokemon, AIPokemon);
        }

        public void CompleteBattle()
        {
            while (PlayerPokemon.CurrentHP > 0 && AIPokemon.CurrentHP > 0)
            {
                TakeTurn();

            }

        }
    }
}
