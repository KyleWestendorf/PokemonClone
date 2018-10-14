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
        private bool EncounterOver {get; set; } = false;

        public WildPokemonEncounter(IPokemon playerPokemon, IPokemon aiPokemon) 
        {
            PlayerPokemon = playerPokemon;
            AIPokemon = aiPokemon;
        }

        public void TakeTurn()
        {
            if(EncounterOver == true) return;

            Turn.CompleteTurn(PlayerPokemon, AIPokemon);
            if(AIPokemon.CurrentHP <= 0 || PlayerPokemon.CurrentHP <=0) {
                EncounterOver = true;
            }
        }

        public void CompleteBattle()
        {
            if(EncounterOver == true) return;

            while (PlayerPokemon.HP > 0 && AIPokemon.HP > 0)
            {
                TakeTurn();

            }
        }

        public void AttemptToCatchPokemon() {
            if(EncounterOver == true) return;

            if(PokemonCatchable() == true) {
                Console.WriteLine($"Player caught {AIPokemon.Name}!");
                EncounterOver = true;
            } else {
                Console.WriteLine($"Player failed to catch {AIPokemon.Name}");
            }
        }

        private bool PokemonCatchable()
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


        private enum CatchChance
        {
            Bad,
            Better,
            Best
        }

        private CatchChance CalculateCatchChance() 
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
