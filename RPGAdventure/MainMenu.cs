using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    public class MainMenu
    {
        public static void Opening()
        {
            Console.Clear();
            Console.WriteLine("===============================WELCOME=====================================");
            Console.WriteLine("  *                  *          +    *      *       *       *          *");
            Console.WriteLine("  *             *               |      *       *        *       *    *  ");
            Console.WriteLine("     *   *              *     _|_|_              *         *      *     ");
            Console.WriteLine(" _____    *    ____  *  _____|     |______________   *  _________   *   * ");
            Console.WriteLine("|o o o|_______|    |___|               | | # # #  |____| o o o o |   (|)");
            Console.WriteLine("|o o o|  * * *|: ::|. .|               |o| # # #  |. . | o o o o |  ((|))");
            Console.WriteLine("|o o o|* * *  |::  |. .| []  []  []  []|o| # # #  |. . | o o o o | (((|)))");
            Console.WriteLine("|o o o|**  ** |:  :|. .| []  []  []    |o| # # #  |. . | o o o o |((((|))))");
            Console.WriteLine("|_[]__|__[]___|_||_|__<|____________;;_|_|___[]___|_.|_|____[]___|    |");
            Console.WriteLine("");
            Console.WriteLine("(L)oad Game?");
            Console.WriteLine("(N)ew Game?");
            Console.WriteLine("(E)xit Game?");
            string input = Console.ReadLine();

            if (input.ToLower() == "l" || input.ToLower() == "load")
            {
                try
                {
                    Program.LoadGame();
                    Console.ReadKey();
                    Story.Start();
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("No Save Game data for this player!");
                    Console.ReadKey();
                    Opening();
                }
            }
            else if (input.ToLower() == "n" || input.ToLower() == "new")
            {
                Story.Start();
            }
            else if (input.ToLower() == "e" || input.ToLower() == "exit")
            {
                System.Environment.Exit(0);
            }
            else
            {
                Opening();
            }
        }

    }
}
