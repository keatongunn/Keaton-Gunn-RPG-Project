using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keaton_Gunn_RPG_Project
{
    internal class Monster
    {
        public string Name;
        public int Strength;
        public int Defense;
        public int OriginalHealth;
        public int CurrentHealth;

        public Monster() { }
        public Monster(string name, int strength, int def, int og, int current)
        {
            Name = name;
            Strength = strength;
            Defense = def;
            OriginalHealth = og;
            CurrentHealth = current;
        }
        
        

    }
}
