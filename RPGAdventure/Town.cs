using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    public class Town : Place
    {
        public void Load(Player p)
        {
            Run(p);
        }

        public void Run(Player p)
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
            Console.WriteLine("                            (E)xit");
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
                new Shop().Load(Program.currentPlayer);
            }
            else if (input == "t" || input == "town hall")
            {
                Console.WriteLine("The Town Hall seems to be locked!");
                Console.ReadKey();
                new Town().Load(Program.currentPlayer);
            }
            else if (input == "h" || input == "home")
            {
                new Apartment().Load(Program.currentPlayer);
            }
            else if (input == "f" || input == "forest")
            {
                new Forest().Load(Program.currentPlayer);
            }
            else if (input == "e" || input == "exit")
            {
                MainMenu.Opening();
            }
            else
            {
                new Town().Load(Program.currentPlayer);
            }
        }
    }
}