using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    public class Player
    {
        Random rand = new Random();
        public string name;
        public int saveID;
        public int gold = 500;
        public int health = 15;
        public int damage = 0;
        public int armorValue = 0;
        public int potion = 5;
        public int weaponValue = 1;


        public int mods = 0;

        public int GetHealth()
        {
            int upper = (2 * mods + 5);
            int lower = (mods + 2);
            return rand.Next(lower, upper);
        }

        public int GetPower()
        {
            int upper = (2 * mods + 2);
            int lower = (mods + 1);
            return rand.Next(lower, upper);
        }

        public int GetCoins()
        {
            int upper = (15 * mods + 50);
            int lower = (mods + 10);
            return rand.Next(lower, upper);
        }
    }
}
