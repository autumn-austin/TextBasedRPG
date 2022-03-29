using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    public class Shop : Place
    {
        public void Load(Player p)
        {
            Run(p);
        }

        public void Run(Player p)
        {
            int potionPrice;
            int armorPrice;
            int weaponPrice;
            int difmodPrice;

            while(true)
            {
                potionPrice = 5 + 10 * Program.currentPlayer.mods;
                armorPrice = 25 * (Program.currentPlayer.armorValue + 1);
                weaponPrice = 20 * Program.currentPlayer.weaponValue;
                difmodPrice = 300 + 100 * Program.currentPlayer.mods;

                Console.Clear();
                Console.WriteLine("          SHOP          ");
                Console.WriteLine("========================");
                Console.WriteLine("=(P)otion : $" + potionPrice);
                Console.WriteLine("=(A)rmor  : $" + armorPrice);
                Console.WriteLine("=(W)eapon : $" + weaponPrice);
                Console.WriteLine("=(D)ifficulty : $" + difmodPrice);
                Console.WriteLine("========================");
                Console.WriteLine("          (E)xit        ");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("      Player Stats      ");
                Console.WriteLine("========================");
                Console.WriteLine("Gold: " + Program.currentPlayer.potion);
                Console.WriteLine("Potion Inventory: " + Program.currentPlayer.potion);
                Console.WriteLine("Weapon Level: " + Program.currentPlayer.weaponValue);
                Console.WriteLine("Armor Level: " + Program.currentPlayer.armorValue);
                Console.WriteLine("Gold Amount: " + Program.currentPlayer.gold);
                Console.WriteLine("Health Level: " + Program.currentPlayer.health);
                Console.WriteLine("========================");


                string input = Console.ReadLine().ToLower();
                if (input == "p" || input == "potion")
                {
                    TryBuy("potion", potionPrice, Program.currentPlayer);
                }
                else if (input == "a" || input == "armor")
                {
                    TryBuy("armor", armorPrice, Program.currentPlayer);

                }
                else if (input == "w" || input == "weapon")
                {
                    TryBuy("weapon", weaponPrice, Program.currentPlayer);

                }
                else if (input == "d" || input == "difficulty")
                {
                    TryBuy("difficulty", difmodPrice, Program.currentPlayer);

                }
                else if (input == "e" || input == "exit")
                {
                    new Town().Load(Program.currentPlayer);
                }
                break;
            }
        }
        static void TryBuy(string item, int cost, Player p)
        {
            if(Program.currentPlayer.gold >= cost)
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
