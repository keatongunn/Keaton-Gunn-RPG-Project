using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keaton_Gunn_RPG_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timer = 0;
            Game game = new Game();
            while(timer == 0)
            {

            game.Start();
            }
            
            
            Console.ReadLine();
        }
    }
}
