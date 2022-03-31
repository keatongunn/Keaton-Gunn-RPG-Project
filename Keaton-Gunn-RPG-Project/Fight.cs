using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keaton_Gunn_RPG_Project
{
    internal class Fight
    {
        public Hero Hero;
        public Monster Monster;
        public Weapon Weapon;
        public Armor Armor;
        public List<Monster> Monsters;
        public Game Game;

        public Fight()
        {
            this.Hero = new Hero();
            this.Monster = new Monster();
            this.Monsters = new List<Monster>();
            this.Weapon = new Weapon();
            this.Armor = new Armor();
            
        }
        public void HeroTurn()
        {
            
            int heroAttack = Hero.BaseStrength + Hero.EquippedWeapon;
            int heroTurn = Monster.Defense + Monster.CurrentHealth - heroAttack;

            Console.WriteLine("{0}'s turn", Hero.Name);
            Console.WriteLine("The " + Monster.Name + " takes " + heroAttack + " damage.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("The " + Monster.Name + " has " + heroTurn + " health remaining");
            Console.WriteLine("End of turn");
            Console.ReadLine();
            MonsterTurn();


        }

        public void MonsterTurn()
        {
            int heroDefense = Hero.BaseDefense + Hero.EquippedArmor;
            int monTurn = Hero.CurrentHealth + heroDefense - Monster.Strength;

            Console.WriteLine("{0}'s turn", Monster.Name);
            Console.WriteLine(Hero.Name + " takes " + Monster.Strength + " damage.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(Hero.Name + " has " + monTurn + " health remaining.");
            Console.WriteLine("End of turn.");
            Console.ReadLine();
            HeroTurn();

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
    }
}
