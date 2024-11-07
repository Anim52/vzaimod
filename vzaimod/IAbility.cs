using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vzaimod
{
    internal interface IAbility
    {
        public int Damage { get; set; }
        public string Title { get; set; }
        public float DefenseChange { get; set; }
        public int EnergeCost { get; set; }

        void UseAbility(ICharacter target, ICharacter attacker)
        {

        }
        void info()
        {
            Console.WriteLine($"{Damage},{Title},{DefenseChange},{EnergeCost}");
        }
    }
}
