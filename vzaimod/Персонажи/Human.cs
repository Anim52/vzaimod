﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace vzaimod.Персонажи
{
    internal class Human : ICharacter
    {
        public string Name { get ; set ; }
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



        public int Stamina { get ; set ; }
        public int Energy { get ; set ; }
        public IWeapons Weapons { get ; set ; }
        public IAbility Ability { get ; set ; }
        public bool IsAlive { get; set; }
        
       


        public void WeaponsAttack(ICharacter target)
        {
            if(Stamina >= Weapons.StaminaToAttack)
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
                Ability.UseAbility(target, this); 
                Energy -= Ability.EnergeCost; 
            }
            else
            {
                Console.WriteLine($"У {Name} недостаточно энергии для атаки");
            }
        }

        public void Defense(ICharacter target)
        {
            Random random = new Random();
            
            double chance = random.Next(1, 41);

            
            if (chance <= Weapons.DefenseChange) 
            {
                Console.WriteLine($"{Name} блокировал атаку от {target.Name}!");
                int counterAttackDamage = Weapons.Damage * 2;
                target.Health -= counterAttackDamage;
                Console.WriteLine($"{target.Name} получает контратаку на {counterAttackDamage} урона от {Name}.");
            }
            else
            {
                Console.WriteLine($"{Name} не смог блокировать атаку от {target.Name}.");
            }
        }




        public void Info()
        {

            
            string st = "";
            if (health <= 0)
            {
                st = "Мертв";
            }
            else if (health > 0)
            {
                st = "Жив";
            }
            Console.WriteLine($"{Name} - Здорорвье:{Health},Cтамина:{Stamina},Энегрия:{Energy}, Статус:{st}");
        }
    }
}
