using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    public class LivingRoom : Place
    {
        public void Load(Player p)
        {
            Run(p);
        }
        public void Run(Player p)
        {
            Console.Clear();
            Console.WriteLine(" ____________________   ");
            Console.WriteLine("|  o  | ,----------, |  ");
            Console.WriteLine("|_____| |_===___O__| |  ");
            Console.WriteLine("|  o  | | ... ### .| |  ");
            Console.WriteLine("|_____|_|_O__ooo___|_|  ");
            Console.WriteLine(" (_)              (_)   ");
            Console.WriteLine(" === (M)usic Player ===   >>> (B)edroom? >>>");
            Console.WriteLine("");

            string input = Console.ReadLine();
            if (input.ToLower() == "m" || input.ToLower() == "music player")
            {
                //create music player to play music for user
            }
            else if (input.ToLower() == "b" || input.ToLower() == "bedroom")
            {
                Console.Clear();
                new Apartment().Load(Program.currentPlayer);
            }
        }
    }
}
