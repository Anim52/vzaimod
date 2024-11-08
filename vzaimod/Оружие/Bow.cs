
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vzaimod.Оружие
{
    internal class Bow : IWeapons
    {
        public string Title { get; set; }
        public int Damage { get; set; }
        public int StaminaToAttack { get; set; }
        public float DefenseChange { get; set; }
        private  static Random Random = new Random();

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
        public void info()
        {
            Console.WriteLine($"Название:{Title},Урон:{Damage},Использует стамины{StaminaToAttack},Шанс заблокировать удар:{DefenseChange}");
        }
    }
}
