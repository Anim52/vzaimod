using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vzaimod.Характеристики
{
    internal class FireBoll : IAbility
    {
        public int Damage { get ; set ; }
        public string Title { get ; set ; }
        public float DefenseChange { get ; set ; }
        public int EnergeCost { get; set; }

        public void UseAbility(ICharacter target, ICharacter attacker)
        {
          
            if (!target.IsAlive)
            {
                Console.WriteLine($"{target.Name} уже мертв и не может быть атакован.");
                return;
            }

            
            target.Health -= Damage;
            Console.WriteLine($"{attacker.Name} использует {Title}, нанося {Damage} урона {target.Name}. У {target.Name} осталось {target.Health} здоровья.");

           
            if (target.Health <= 0)
            {
                target.IsAlive = false;
                Console.WriteLine($"{target.Name} убит");
            }
        }
        public void Info()
        {
            Console.WriteLine($"Название:{Title},Урон:{Damage},Энергия для использования:{EnergeCost},Шанс заблокировать атаку:{DefenseChange}");
        }

    }
}
