using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    public class Town
    {
        public static void LoadTown(Player p)
        {
            RunTown(p);
        }

        public static void RunTown(Player p)
        {

            Console.Clear();
            Console.WriteLine("  *                  *          +    *      *       *       *          *");
            Console.WriteLine("  *             *               |      *       *        *       *    *  ");
            Console.WriteLine("     *   *              *     _|_|_              *         *      *     ");
            Console.WriteLine(" _____    *    ____  *  _____|     |______________   *  _________   *   * ");
            Console.WriteLine("|o o o|_______|    |___|               | | # # #  |____| o o o o |   (|)");
            Console.WriteLine("|o o o|  * * *|: ::|. .|               |o| # # #  |. . | o o o o |  ((|))");
            Console.WriteLine("|o o o|* * *  |::  |. .| []  []  []  []|o| # # #  |. . | o o o o | (((|)))");
            Console.WriteLine("|o o o|**  ** |:  :|. .| []  []  []    |o| # # #  |. . | o o o o |((((|))))");
            Console.WriteLine("|_[]__|__[]___|_||_|__<|____________;;_|_|___[]___|_.|_|____[]___|    |");
            Console.WriteLine("(S)hop                    (T)own Hall                    (H)ome    (F)orest");
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
            Console.WriteLine("        (E)xit");

            string input = Console.ReadLine().ToLower();
            if (input == "s" || input == "shop")
            {
                Shop.LoadShop(Program.currentPlayer);
            }
            else if (input == "t" || input == "town hall")
            {

            }
            else if (input == "h" || input == "home")
            {

            }
            else if (input == "f" || input == "forest")
            {

            }
            else if (input == "e" || input == "exit")
            {
                Encounters.RandomEncounter();
            }
        }
    }
}