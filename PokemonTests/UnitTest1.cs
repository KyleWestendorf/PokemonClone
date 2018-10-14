/*using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pokemon;
using Pokemon.Encounters;
using System.Collections.Generic;
using static Pokemon.Encounters.WildPokemonEncounter;

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
            string name = "Silas";
            PokemonType type = PokemonType.Fire;
            IPokemon pokemon = new Pokemon.Pokemon(name, hp, attack, defense, type);

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
            string name = "Silas";
            PokemonType type = PokemonType.Fire;
            IPokemon pokemon = new Pokemon.Pokemon(name, hp, attack, defense, type);

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
            string name = "Silas";
            PokemonType type = PokemonType.Fire;
            IPokemon pokemon = new Pokemon.Pokemon(name, hp, attack, defense, type);

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
            string name = "Silas";
            PokemonType type = PokemonType.Fire;
            IPokemon pokemon = new Pokemon.Pokemon(name, hp, attack, defense, type);

            //Act

            //Assert
            Console.WriteLine(pokemon.AttackStat);
            Assert.IsTrue(pokemon.Type == PokemonType.Fire);
        }

        //Commented out, these methods made private for encapsulation
        //[TestMethod]
        //public void CalculateCatchTest()
        //{
        //    //Arrange
        //    int attack = 50;
        //    int defense = 60;
        //    int hp = 100;
        //    string name = "Player Pokemon";
        //    PokemonType type = PokemonType.Fire;
        //    IPokemon playerPokemon = new Pokemon.Pokemon(name, hp, attack, defense, type);

        //    int attack2 = 50;
        //    int defense2 = 60;
        //    int hp2 = 100;
        //    string name2 = "Wild Pokemon";
        //    PokemonType type2 = PokemonType.Fire;
        //    IPokemon AIPokemon = new Pokemon.Pokemon(name2, hp2, attack2, defense2, type2);
        //    WildPokemonEncounter battle = new WildPokemonEncounter(playerPokemon, AIPokemon);

        //    //Act
        //    AIPokemon.CurrentHP = 50;
        //    CatchChance actual = battle.CalculateCatchChance();
        //    CatchChance expected = CatchChance.Better;
        //    Console.WriteLine(actual);
        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void BadChanceCatchPokemon()
        {

            //Arrange
            int attack = 50;
            int defense = 60;
            int hp = 100;
            string name = "Player Pokemon";
            PokemonType type = PokemonType.Fire;
            IPokemon playerPokemon = new Pokemon.Pokemon(name, hp, attack, defense, type);

            int attack2 = 50;
            int defense2 = 60;
            int hp2 = 100;
            string name2 = "Wild Pokemon";
            PokemonType type2 = PokemonType.Fire;
            IPokemon AIPokemon = new Pokemon.Pokemon(name2, hp2, attack2, defense2, type2);
            WildPokemonEncounter battle = new WildPokemonEncounter(playerPokemon, AIPokemon);

            //Act

            bool actual1 = battle.CatchPokemon();
            bool actual2 = battle.CatchPokemon();
            bool actual3 = battle.CatchPokemon();
            bool actual4 = battle.CatchPokemon();
            bool actual5 = battle.CatchPokemon();

            List<bool> results = new List<bool> { actual1, actual2, actual3, actual4, actual5 };

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            //Assert

            Assert.IsTrue(results.Contains(false));
        }

        [TestMethod]
        public void BetterChanceCatchPokmeon()
        {

            //Arrange
            int attack = 50;
            int defense = 60;
            int hp = 100;
            string name = "Player Pokemon";
            PokemonType type = PokemonType.Fire;
            IPokemon playerPokemon = new Pokemon.Pokemon(name, hp, attack, defense, type);

            int attack2 = 50;
            int defense2 = 60;
            int hp2 = 100;
            string name2 = "Wild Pokemon";
            PokemonType type2 = PokemonType.Fire;
            IPokemon AIPokemon = new Pokemon.Pokemon(name2, hp2, attack2, defense2, type2);
            AIPokemon.CurrentHP = 60;
            WildPokemonEncounter battle = new WildPokemonEncounter(playerPokemon, AIPokemon);

            //Act

            

            bool actual1 = battle.CatchPokemon();
            bool actual2 = battle.CatchPokemon();
            bool actual3 = battle.CatchPokemon();
            bool actual4 = battle.CatchPokemon();
            bool actual5 = battle.CatchPokemon();

            List<bool> results = new List<bool> { actual1, actual2, actual3, actual4, actual5 };

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            //Assert

            Assert.IsTrue(results.Contains(true && false));
        }

        [TestMethod]
        public void BestChanceCatchPokemon()
        {

            //Arrange
            int attack = 50;
            int defense = 60;
            int hp = 100;
            string name = "Player Pokemon";
            PokemonType type = PokemonType.Fire;
            IPokemon playerPokemon = new Pokemon.Pokemon(name, hp, attack, defense, type);

            int attack2 = 50;
            int defense2 = 60;
            int hp2 = 100;
            string name2 = "Wild Pokemon";
            PokemonType type2 = PokemonType.Fire;
            IPokemon AIPokemon = new Pokemon.Pokemon(name2, hp2, attack2, defense2, type2);
            AIPokemon.CurrentHP = 20;
            WildPokemonEncounter battle = new WildPokemonEncounter(playerPokemon, AIPokemon);

            //Act

            bool actual1 = battle.CatchPokemon();
            bool actual2 = battle.CatchPokemon();
            bool actual3 = battle.CatchPokemon();
            bool actual4 = battle.CatchPokemon();
            bool actual5 = battle.CatchPokemon();
            List<bool> results = new List<bool> { actual1, actual2, actual3, actual4, actual5 };
            foreach(var result in results)
            {
                Console.WriteLine(result);
            }

            //Assert

            Assert.IsTrue(results.Contains(true && false));
        }

        
    }
}
*/