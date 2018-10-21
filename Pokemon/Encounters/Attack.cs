using System;

namespace Pokemon
{
    public static class Attack
    {

        public static int MakeAttack(IPokemon attacker, IPokemon target)
        {
            try
            {
                float damage = CalculateDamage(attacker, target);
                int targetHealth = target.CurrentHP - (int)damage;
               
                Console.WriteLine($"{attacker.Name} hit {target.Name} for {damage}. {target.Name} has {target.CurrentHP - damage} health remaining.");
                return targetHealth;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Your Issue is in MakeAttack: " + ex.Message);
                throw;
            }
            
        }

        private static float CalculateDamage(IPokemon attacker, IPokemon target)
        {
            try
            {
                return (float)attacker.AttackStat * ((150f - (float)target.DefenseStat) / 150f);
            } catch(Exception ex){

                Console.WriteLine("Your issue is in Calculate Damage " + ex.Message);
                throw;
            }
        }

    }
}