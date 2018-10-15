using System;

namespace Pokemon
{
    public class Turn
    {
        
        public void CompleteTurn(IPokemon playerPokemon, IPokemon aiPokemon)
        {
            PlayerTurn(playerPokemon, aiPokemon);
            if(aiPokemon.CurrentHP <= 0) 
            {
                Console.WriteLine($"{playerPokemon.Name} knocked out {aiPokemon.Name}");
            }
            else 
            {
                AITurn(aiPokemon, playerPokemon);
                    if(playerPokemon.CurrentHP <= 0) 
                    {
                    Console.WriteLine($"{aiPokemon.Name} knocked out {playerPokemon.Name}");
                    }
            }      
        }
        
        public void AITurn(IPokemon attacker, IPokemon target)
        {
            target.CurrentHP = Attack.MakeAttack(attacker, target);
            Console.WriteLine("End of AI Turn");
        }

        private void PlayerTurn(IPokemon attacker, IPokemon target)
        {
            target.CurrentHP = Attack.MakeAttack(attacker, target);
            Console.WriteLine("End of Player Turn");
        }
    }
}