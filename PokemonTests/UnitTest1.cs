using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pokemon;

namespace PokemonTests
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void AttackDoesDamage()
        //{

        //    // Arrange
        //    IPokemon pokemon = new Pokemon.Pokemon(50, 60, 100, PokemonType.Fire);
        //    IPokemon pokemon2 = new Pokemon.Pokemon(60, 30, 100, PokemonType.Water);
        //    // Act
        //    int targetHealth = pokemon.Attack(pokemon2);
        //    //Assert
        //    Assert.IsTrue(targetHealth < 100);
        //}

        [TestMethod]
        public void PokemonHasAttackStat()
        {
            //Arrange
            int attack = 50;
            int defense = 60;
            int hp = 100;
            PokemonType type = PokemonType.Fire;
            IPokemon pokemon = new Pokemon.Pokemon(hp, attack, defense, type);

            //Act

            //Assert
            Console.WriteLine(pokemon.AttackStat);
            Assert.IsTrue(pokemon.AttackStat == 50);
        }

        [TestMethod]
        public void PokemonHasDefenseStat()
        {
            //Arrange
            int attack = 50;
            int defense = 60;
            int hp = 100;
            PokemonType type = PokemonType.Fire;
            IPokemon pokemon = new Pokemon.Pokemon(hp, attack, defense, type);

            //Act

            //Assert
            Console.WriteLine(pokemon.AttackStat);
            Assert.IsTrue(pokemon.DefenseStat == 60);
        }
        [TestMethod]
        public void PokemonHasHPStat()
        {
            //Arrange
            int attack = 50;
            int defense = 60;
            int hp = 100;
            PokemonType type = PokemonType.Fire;
            IPokemon pokemon = new Pokemon.Pokemon(hp, attack, defense, type);

            //Act

            //Assert
            Console.WriteLine(pokemon.AttackStat);
            Assert.IsTrue(pokemon.HP == 100);
        }

        [TestMethod]
        public void PokemonHasType()
        {
            //Arrange
            int attack = 50;
            int defense = 60;
            int hp = 100;
            PokemonType type = PokemonType.Fire;
            IPokemon pokemon = new Pokemon.Pokemon(hp, attack, defense, type);

            //Act

            //Assert
            Console.WriteLine(pokemon.AttackStat);
            Assert.IsTrue(pokemon.Type == PokemonType.Fire);
        }
    }
}
