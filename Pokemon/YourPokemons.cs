using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class YourPokemons : PokemonAll
    {
        public string YourPokemonName { get; set; }
        public YourPokemons(string yourPokemonName ,string _name, string _type, int _attack) :base( _name,  _type,  _attack)
        {
            YourPokemonName = yourPokemonName;
            Name = _name;
            Type = _type;
            Attack = _attack;


        }
    }
}
