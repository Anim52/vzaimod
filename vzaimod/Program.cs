using System.Threading.Channels;
using vzaimod.Оружие;
using vzaimod.Персонажи;
using vzaimod.Характеристики;

namespace vzaimod
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Axe axe = new Axe() {Title = "Боевой топор",Damage = 50, StaminaToAttack = 15, DefenseChange = 10};
            Bow bow = new Bow() {Title = "Лук",Damage = 20,StaminaToAttack = 10, DefenseChange = 0};
            Sword sword = new Sword() {Title = "Меч",Damage = 17,StaminaToAttack = 15,DefenseChange = 5 };

            FireBoll fireBoll = new FireBoll() {Title = "Огненный шар",Damage = 25,DefenseChange = 5, EnergeCost = 10};
            Heal heal = new Heal() {Title = "Лечение",Damage = 5,DefenseChange = 1, EnergeCost = 5 };
            IceBoll iceBoll = new IceBoll() {Title = "Ледяной шар",Damage = 20,DefenseChange = 5, EnergeCost = 7 };

            Human human = new Human() {Name = "Человек", Ability = fireBoll, Weapons = axe, Energy = 100, Health =100, Stamina = 100, IsAlive = true };
            Troll troll = new Troll() {Name = "Троль", Ability = iceBoll, Weapons = bow, Energy = 100, Health = 150,Stamina = 100, IsAlive = true };
            Warevolf warevolf = new Warevolf() {Name = "Оборотень", Ability = fireBoll, Weapons = sword,Energy = 100, Health = 170,Stamina = 120, IsAlive = true };

          

            while (true)
            {
                Console.WriteLine("Добро пожаловать!");
                Console.WriteLine("Нажмите F чтобы начать игру");

                ConsoleKeyInfo key = Console.ReadKey(intercept: true);
                if(key.Key == ConsoleKey.F)
                {
                    Console.WriteLine("Доступные персонажи");
                    human.Info();
                    troll.Info();
                    warevolf.Info();
                    while (true)
                    {
                        
                        Console.WriteLine($"Нажмите H чтобы атаковать человеком");
                        ConsoleKeyInfo h = Console.ReadKey(intercept: true);
                        if (h.Key == ConsoleKey.H)
                        {
                            Console.WriteLine("Нажмите 1 чтобы атаковать оружием нажмите 2 чтобы атаковать способностью");
                            string one = Console.ReadLine();
                            if (one == "1")
                            {
                                human.WeaponsAttack(troll);
                                human.Info();
                                troll.Info();
                                if (troll.Health <= 0)
                                {
                                    break;
                                }
                            }
                            if(one == "2")
                            {
                                human.AbilityAttack(troll);
                                human.Info();
                                troll.Info();
                                if (troll.Health <= 0)
                                {
                                    break;
                                }
                            }
                           
                        }
                        Console.WriteLine($"Нажмите T чтобы атаковать тролем");
                        ConsoleKeyInfo t = Console.ReadKey(intercept: true);
                        if (t.Key == ConsoleKey.T)
                        {
                            Console.WriteLine("Нажмите 1 чтобы атаковать оружием нажмите 2 чтобы атаковать способностью");
                            string two = Console.ReadLine();
                            if (two == "1")
                            {
                                troll.WeaponsAttack(human);
                                human.Info();
                                troll.Info();
                                if (human.Health <= 0)
                                {
                                    break;
                                }
                            }
                            if (two == "2")
                            {
                                troll.AbilityAttack(human);
                                human.Info();
                                troll.Info();
                                if (human.Health <= 0)
                                {
                                    break;
                                }
                            }


                        }

                        Console.WriteLine($"Нажмите O чтобы отоковать оборотнем");
                        ConsoleKeyInfo o = Console.ReadKey(intercept: true);
                        if(o.Key == ConsoleKey.O)
                        {

                            warevolf.WeaponsAttack(human);
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Нажата неправильная буква попробуйте снова");
                }
                break; 
            }


            Console.WriteLine("gg");
        }
     
    }
}
