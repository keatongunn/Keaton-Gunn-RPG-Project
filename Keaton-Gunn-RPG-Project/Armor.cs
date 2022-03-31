using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keaton_Gunn_RPG_Project
{
    internal class Armor
    {
        public string Name;
        public int Power;

        public Armor() { }
        public Armor(string name, int power)
        {
            this.Name = name;
            this.Power = power; 
        }

        
    }
}
