using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class PokemonAll
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }

        public PokemonAll(string _name, string _type, int _attack)
        {

            Name = _name;
            Type = _type;
            Attack = _attack;
            Health = 100;
        }

        public int PokeAttack()
        {
            Random random = new Random();
            int randomNmb = random.Next(2, 4);
            int pkAtk = Attack * 11 / randomNmb;
            return pkAtk;
        }

        }
    }

