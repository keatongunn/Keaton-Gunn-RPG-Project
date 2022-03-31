using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keaton_Gunn_RPG_Project
{
    internal class Hero
    {
        public string Name;
        public int GamesPlayed;
        public int Win;
        public int Loss;
        public int BaseStrength;
        public int BaseDefense;
        public int OriginalHealth;
        public int CurrentHealth;
        public int EquippedWeapon;
        public int EquippedArmor;
        public Weapon Weapon;
        public Armor Armor;
        public List<Weapon> WeaponsBag;
        public List<Armor> ArmorBag;

        public Hero()
        {
            
            this.BaseStrength = 40;
            this.BaseDefense = 20;
            this.OriginalHealth = 100;
            this.CurrentHealth = 100;
            this.GamesPlayed = 0;
            this.Loss = 0;
            this.Win = 0;
            this.ArmorBag = new List<Armor>();
            this.WeaponsBag = new List<Weapon>();
            this.Weapon = new Weapon();

        }
        public void WhatsYourName()
        {
            string name;
            Console.WriteLine("Hello traveler, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("I see. We'll call you {0} then.", name);
            this.Name = name;
        }
        public void ShowStats()
        {
            Console.WriteLine("Games Played: " + GamesPlayed);
            Console.WriteLine("Wins: {0} Loss: {1}", Win, Loss);

        }
        public void StockWeapons()
        {
            Random rand = new Random();
            int random = rand.Next(10, 50);
            Weapon weapon1 = new Weapon("Sword", 20);
            Weapon weapon2 = new Weapon("Axe", 30);
            Weapon weapon3 = new Weapon("Bow", 15);
            Weapon weapon4 = new Weapon("Staff", 10);
            Weapon weapon5 = new Weapon("Hammer", random);
            WeaponsBag.Add(weapon1);
            WeaponsBag.Add(weapon2);
            WeaponsBag.Add(weapon3);
            WeaponsBag.Add(weapon4);
            WeaponsBag.Add(weapon5);
        }
        public void StockArmor()
        {
            Random rand = new Random();
            int random = rand.Next(10, 30);
            Armor armor1 = new Armor("Chain", 5);
            Armor armor2 = new Armor("Leather", 15);
            Armor armor3 = new Armor("Iron", 20);
            Armor armor4 = new Armor("Gold", random);
            
            ArmorBag.Add(armor1);
            ArmorBag.Add(armor2);
            ArmorBag.Add(armor3);
            ArmorBag.Add(armor4);
            
        }

        public void EquipArmor()
        {
            
            Console.WriteLine("Choose your armor. Type the name of which you choose.");
            Console.WriteLine();
            foreach (var item in ArmorBag)
            {
                
                Console.WriteLine("Armor Name: {0}, Armor Strength: {1}", item.Name, item.Power);
            }
            string choice = Console.ReadLine();
            foreach(var item in ArmorBag)
            {

                if (item.Name.ToLower() == choice.ToLower())
                {
                    EquippedArmor = item.Power;
                    Armor = item;
                    Console.WriteLine("Great choice.");
                    
                }
            }
            
        }
        public void EquipWeapon()
        {

            Console.WriteLine("Choose your Weapon. Type the name of which you choose.");
            Console.WriteLine();
            foreach (var item in WeaponsBag)
            {
                Console.WriteLine("Weapon Name: {0}, Weapon Strength: {1}", item.Name, item.Power);
            }
            string choice = Console.ReadLine();
            foreach (var item in WeaponsBag)
            {

                if (item.Name.ToLower() == choice.ToLower())
                {
                    EquippedWeapon = item.Power;
                    Weapon = item;
                    Console.WriteLine("Great choice.");
                    
                }
                
            }

        }

        public void Inventory()
        {
            foreach(var item in WeaponsBag)
            {
                Console.WriteLine("Weapon Name: {0}, Weapon Strength: {1}", item.Name, item.Power);
            }
            foreach(var item in ArmorBag)
            {
                Console.WriteLine("Armor Name: {0}, Armor Strength: {1}", item.Name, item.Power);
            }
        }

      
    }
}
