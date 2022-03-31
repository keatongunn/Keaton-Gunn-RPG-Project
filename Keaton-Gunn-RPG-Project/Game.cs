using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keaton_Gunn_RPG_Project
{
    internal class Game
    {
        public Hero Hero;
        public Monster Monster;
        public Fight Fight;
        public List<Monster> Monsters;
        public int counter;
        public Game()
        {
            this.counter = 0;
            this.Fight = new Fight();
            this.Hero = new Hero();
            this.Monster = new Monster();
            this.Monsters = new List<Monster>();
        }

        public void HeroTurn()
        {

            int heroAttack = Hero.BaseStrength + Hero.EquippedWeapon;
            int heroTurn = Monster.Defense + Monster.CurrentHealth - heroAttack;

            Console.WriteLine("{0}'s turn", Hero.Name);
            Console.WriteLine("The " + Monster.Name + " takes " + heroAttack + " damage.");
            Monster.CurrentHealth -= (heroAttack - Monster.Defense);
            Console.ReadLine();
            Console.WriteLine("The " + Monster.Name + " has " + heroTurn + " health remaining");
            Console.WriteLine("End of turn");
            Console.ReadLine();            
        }

        public void MonsterTurn()
        {
            int heroDefense = Hero.BaseDefense + Hero.EquippedArmor;
            int monTurn = Hero.CurrentHealth + heroDefense - Monster.Strength;

            Console.WriteLine("{0}'s turn", Monster.Name);
            Console.WriteLine(Hero.Name + " takes " + Monster.Strength + " damage.");
            Hero.CurrentHealth -= (Monster.Strength - heroDefense);
            Console.ReadLine();
            Console.WriteLine(Hero.Name + " has " + monTurn + " health remaining.");
            Console.WriteLine("End of turn.");
            Console.ReadLine();                        
        }

        public void HeroWin()
        {
            Console.WriteLine("Congratulations, you've won!");
            Console.WriteLine("Good work taking out that " + Monster.Name);
            Hero.Win++;
            Hero.GamesPlayed++;
            Hero.CurrentHealth = Hero.OriginalHealth;
            Monster.CurrentHealth = Monster.OriginalHealth;
        }

        public void HeroLoss()
        {
            Console.WriteLine("You did your best. Onto the next one.");
            Hero.Loss++;
            Hero.GamesPlayed++;
            Hero.CurrentHealth = Hero.OriginalHealth;
            Monster.CurrentHealth = Monster.OriginalHealth;

        }
        public void MonsterMaker()
        {
            Monster monster1 = new Monster("Orc", 60, 15, 80, 80);
            Monster monster2 = new Monster("Elf", 80, 20, 60, 60);
            Monster monster3 = new Monster("Demon", 60, 10, 40, 40);
            Monster monster4 = new Monster("Ogre", 50, 30, 80, 80);
            Monster monster5 = new Monster("Zombie", 74, 40, 90, 90);
            Monster monster6 = new Monster("Ghost", 58, 35, 50, 50);
            Monster monster7 = new Monster("Alien", 65, 40, 75, 75);
            Monster monster8 = new Monster("Undead", 60, 10, 75, 75);
            Monster monster9 = new Monster("Troll", 60, 40, 100, 100);

            Monsters.Add(monster1);
            Monsters.Add(monster2);
            Monsters.Add(monster3);
            Monsters.Add(monster4);
            Monsters.Add(monster5);
            Monsters.Add(monster6);
            Monsters.Add(monster7);
            Monsters.Add(monster8);
            Monsters.Add(monster9);            
        }

        public void MainMenu()
        {
            if(Hero.Name == null)
            {
                Hero.WhatsYourName();
            }
            if(Monsters.Count == 0)
            {
                MonsterMaker();
            }
            Random random = new Random();
            int rand = random.Next(Monsters.Count);
            Monster = Monsters[rand];

            if (Hero.WeaponsBag.Count == 0 && Hero.ArmorBag.Count == 0)
            {
                Hero.StockWeapons();
                Hero.StockArmor();
            }
            Console.WriteLine();
            Console.WriteLine("Welcome to the game.");
            Console.WriteLine("Type 1 to see your Hero's statistics.");
            Console.WriteLine("Type 2 to view your inventory.");
            Console.WriteLine("Type 3 to choose your Weapon and Armor Loadout.");
            Console.WriteLine("Type 4 to start the fight !!WARNING!! Starting the game without choosing a loadout will result in Hard Difficulty.");
            Console.WriteLine();
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Hero.ShowStats();
                    Console.WriteLine("Press enter to return to the menu");
                    Console.ReadLine();
                    MainMenu();

                    break;
                case 2:
                    Hero.Inventory();
                    Console.WriteLine("Press enter to return to the menu");
                    Console.ReadLine();
                    MainMenu();
                    break;
                case 3:
                    Hero.EquipArmor();
                    Hero.EquipWeapon();
                    Console.WriteLine("Press enter to return to the menu");
                    Console.ReadLine();
                    MainMenu();
                    break;

                case 4:
                    Console.WriteLine("Let the fight begin!");
                    counter++;
                    Start();
                    num = int.Parse(Console.ReadLine());
                    break;
            }                        
        }

        public void Start()
        {
            if(counter == 0)
            {
                MainMenu();
            }
            while (Monster.CurrentHealth > 0 || Hero.CurrentHealth > 0)
            {
                MonsterTurn();
                HeroTurn();
                

                if (Monster.CurrentHealth <= 0)
                {
                    HeroWin();
                    MainMenu();
                    break;
                }
                if (Hero.CurrentHealth <= 0)
                {
                    HeroLoss();
                    MainMenu();
                    break;
                }
            }
        }
    }
}
