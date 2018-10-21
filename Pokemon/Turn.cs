using System;

namespace Pokemon
{
    public class Turn
    {
        
        public void CompleteTurn(IPokemon playerPokemon, IPokemon aiPokemon)
        {
            PlayerTurn(playerPokemon, aiPokemon);
            if(playerPokemon.CurrentHP <= 0 || aiPokemon.CurrentHP <= 0) return;                                                          
            AITurn(aiPokemon, playerPokemon);
                
        }
        
        public void AITurn(IPokemon attacker, IPokemon target)
        {
            target.CurrentHP = Attack.MakeAttack(attacker, target);
            Console.WriteLine("End of AI Turn");
             if (target.CurrentHP <= 0)
             {
                    Console.WriteLine($"{attacker.Name} knocked out {target.Name}");
             }
        }

        private void PlayerTurn(IPokemon attacker, IPokemon target)
        {
            target.CurrentHP = Attack.MakeAttack(attacker, target);
             if(target.CurrentHP <= 0) 
            {
                Console.WriteLine($"{attacker.Name} knocked out {target.Name}");
            }
            Console.WriteLine("End of Player Turn");
        }
    }
}