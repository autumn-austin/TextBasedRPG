using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    public class Forest : Place
    {
        public void Load(Player p)
        {
            Run(p);
        }
        static Random rand = new Random();
        public void Run(Player p)
        {
            switch (rand.Next(0, 3))
            {
                case 0:
                    var mon1 = new Jeff();
                    mon1.Menu();
                    break;
                case 1:
                    var mon2 = new Skelebone();
                    mon2.Menu();
                    break;
                case 2:
                    var mon3 = new Ratbus();
                    mon3.Menu();
                    break;
                case 3:
                    var mon4 = new Ghostopher();
                    mon4.Menu();
                    break;
            }

            new Town().Load(Program.currentPlayer);
        }
    }
}
