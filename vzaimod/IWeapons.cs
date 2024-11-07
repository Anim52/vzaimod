using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vzaimod
{
    internal interface IWeapons
    {
        public string Title { get; set; }
        public int Damage { get; set; }
        public int StaminaToAttack { get; set; }
        public float DefenseChange { get; set; }

        void Attack(ICharacter target, ICharacter attacer)
        {

        }

        void Info()
        {
            Console.WriteLine($"{Title}, {Damage},{StaminaToAttack},{DefenseChange}");
        }
    }
}
