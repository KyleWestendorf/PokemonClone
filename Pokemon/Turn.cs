using System;

namespace Pokemon
{
    public class Turn
    {

        public void CompleteTurn(IPokemon playerPokemon, IPokemon aiPokemon)
        {
            PlayerTurn(playerPokemon, aiPokemon);
            AITurn(aiPokemon, playerPokemon);
        }
        
        private void AITurn(IPokemon attacker, IPokemon target)
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