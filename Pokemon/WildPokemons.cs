using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class WildPokemons : PokemonAll
    {
        public string Difficulty { get; set; }  
        public WildPokemons(string _name, string _type, int _attack, string _difficulty) :  base(_name, _type, _attack)
        {
            Name = _name;
            Type = _type;
            Attack = _attack;
            Difficulty = _difficulty;
            
        }
    }
}
