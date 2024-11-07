using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vzaimod.Оружие
{
    internal class Axe : IWeapons
    {
        public string Title { get; set; }
        public int Damage { get; set; }
        public int StaminaToAttack { get; set; }
        public float DefenseChange { get; set; }

        public void Attack(ICharacter target, ICharacter attacker)
        {
            if (!target.IsAlive)
            {
                Console.WriteLine($"{target.Name} уже мертв");
                return;
            }
            target.Health -= Damage;
            Console.WriteLine($"{attacker.Name} наносит {Damage} урона {target.Name}");
        }
    }
}
