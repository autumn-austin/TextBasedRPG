using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    public interface Place
    {
        public void Load(Player p);


        public void Run(Player p);


    }
}
