using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Encounters
{
    public class WildPokemonEncounter: IEncounter
    {

        
        public IPokemon PlayerPokemon { get; set; }
        public IPokemon AIPokemon { get; set; }
        public Turn Turn { get; set; } = new Turn();

        public WildPokemonEncounter(IPokemon playerPokemon, IPokemon aiPokemon) 
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
            while (PlayerPokemon.HP > 0 && AIPokemon.HP > 0)
            {
                TakeTurn();

            }
        }


        public bool CatchPokemon()
        {
            try
            {
                CatchChance catchChance = CalculateCatchChance();
                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 11);

                if (catchChance == CatchChance.Best)
                {
                    return randomNumber > 2 ? true : false;
                }

                else if (catchChance == CatchChance.Better)
                {
                    return randomNumber > 6 ? true : false;
                }

                else if (catchChance == CatchChance.Bad)
                {
                    return randomNumber > 8 ? true : false;
                }

                else
                {
                    throw new AggregateException();
                    
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }


        }


        public enum CatchChance
        {
            Bad,
            Better,
            Best
        }

        public CatchChance CalculateCatchChance() 
        {
            if (AIPokemon.CurrentHP > ((float)AIPokemon.HP * .66f)) {
                return CatchChance.Bad;
            }

            else if (AIPokemon.CurrentHP > ((float)AIPokemon.HP * .33f))
            {
                return CatchChance.Better;   
            } else

            {
                return CatchChance.Best;
            }

        }
    }
}
