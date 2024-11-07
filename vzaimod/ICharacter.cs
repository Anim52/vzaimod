using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vzaimod.Персонажи;

namespace vzaimod
{
    internal interface ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Energy { get; set; }
        public IWeapons Weapons { get; set; }
        public IAbility Ability { get; set; }
        public bool IsAlive { get; set; }

        
        void Info()
        {
            Console.WriteLine($"{Name},{Health},{Stamina},{Energy},{Weapons},{Ability}");
        }

    }
}
