using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vzaimod.Персонажи
{
    internal class Troll : ICharacter
    {
        public string Name { get; set; }
        private int health;
        public int Health
        {
            get => health;
            set
            {
                health = value <= 0 ? 0 : value;
                IsAlive = health > 0;

                if (health == 0)
                {
                    Console.WriteLine($"{Name} убит");
                }
            }
        }

        public int Stamina { get; set; }
        public int Energy { get; set; }
        public IWeapons Weapons { get; set; }
        public IAbility Ability { get; set; }
        public bool IsAlive { get ; set ; }

        public void WeaponsAttack(ICharacter target)
        {
            if (Stamina >= Weapons.StaminaToAttack)
            {
                Console.WriteLine($"{Name} атакует {target.Name} с помощью {Weapons.Title}");
                Weapons.Attack(target, this);
                Stamina -= Weapons.StaminaToAttack;
            }
            else
            {
                Console.WriteLine($"{Name} недостаточно стамины для атаки");
            }
        }
        public void AbilityAttack(ICharacter target)
        {
            if (Energy >= Ability.EnergeCost)
            {
                Console.WriteLine($"{Name} использует способность {Ability.Title} против {target.Name}");
                Ability.UseAbility(target, this); // Исправлено название метода
                Energy -= Ability.EnergeCost; // Снижение энергии после использования способности
            }
            else
            {
                Console.WriteLine($"У {Name} недостаточно энергии для атаки");
            }
        }

        public void Defense(ICharacter target)
        {
            Random random = new Random();
            if (random.NextDouble() < Weapons.DefenseChange)
            {
                Console.WriteLine($"{Name} блокировал атаку от {target.Name}!");
                target.Health -= Weapons.Damage * 2;
                Console.WriteLine($"{target.Name} получает контратаку на {Weapons.Damage * 2} урона");
            }
            else
            {
                Console.WriteLine($"{Name} не смог блокировать аттаку");
            }
        }
        public void Info()
        {
            string st;
            if (IsAlive = true)
            {
                st = "Живой";
            }
            else
            {
                st = "Мертв";
            }
            Console.WriteLine($"{Name} - Здорорвье:{Health},Cтамина:{Stamina},Энегрия:{Energy}, Статус:{st}");
        }
    }
}
