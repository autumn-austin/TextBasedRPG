using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    public class Shop
    {
        public static void LoadShop(Player p)
        {
            RunShop(p);
        }

        public static void RunShop(Player p)
        {
            int potionPrice;
            int armorPrice;
            int weaponPrice;
            int difmodPrice;

            while(true)
            {
                potionPrice = 5 + 10 * p.mods;
                armorPrice = 25 * p.armorValue;
                weaponPrice = 20 * (p.weaponValue + 1);
                difmodPrice = 300 + 100 * p.mods;

                Console.Clear();
                Console.WriteLine("          SHOP          ");
                Console.WriteLine("========================");
                Console.WriteLine("=(P)otion : $" + potionPrice);
                Console.WriteLine("=(A)rmor  : $" + armorPrice);
                Console.WriteLine("=(W)eapon : $" + weaponPrice);
                Console.WriteLine("=(D)ifficulty : $" + difmodPrice);
                Console.WriteLine("========================");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("      Player Stats      ");
                Console.WriteLine("========================");
                Console.WriteLine("Potion Inventory: " + p.potion);
                Console.WriteLine("Weapon Level: " + p.weaponValue);
                Console.WriteLine("Armor Level: " + p.armorValue);
                Console.WriteLine("Gold Amount: " + p.gold);
                Console.WriteLine("Health Level: " + p.health);
                Console.WriteLine("========================");


                string input = Console.ReadLine().ToLower();
                if(input == "p" || input == "potion")
                {
                    TryBuy("potion", potionPrice, p);
                }
                else if (input == "a" || input == "armor")
                {
                    TryBuy("armor", armorPrice, p);

                }
                else if (input == "w" || input == "weapon")
                {
                    TryBuy("weapon", weaponPrice, p);

                }
                else if (input == "d" || input == "difficulty")
                {
                    TryBuy("difficulty", difmodPrice, p);

                }
            }
        }
        static void TryBuy(string item, int cost, Player p)
        {
            if(p.gold >= cost)
            {
                if (item == "potion")
                    p.potion++;
                else if (item == "weapon")
                    p.weaponValue++;
                else if (item == "armor")
                    p.weaponValue++;
                else if (item == "difficulty")
                    p.mods++;

                p.gold -= cost;
            }
            else
            {
                Console.WriteLine("Hmmm... Have you got any more coin?\nThis simply will not do.");
                Console.ReadKey();
            }
        }
    }
}
