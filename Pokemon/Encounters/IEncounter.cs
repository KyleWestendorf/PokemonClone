using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public interface IEncounter
    {

        IPokemon PlayerPokemon { get; set; }
        IPokemon AIPokemon { get; set; }
        Turn Turn { get; set; }

        void TakeTurn();
        void CompleteBattle();
       
    }
}
