using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    public class Story
    {
        public static void Start()
        {
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
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Enter Player Name: ");
            Program.currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You awake in a rainy, dark forest. You feel dazed and are having trouble remembering");
            Console.WriteLine("anything about how you got here...");

            if (Program.currentPlayer.name == "")
            {
                Console.WriteLine("Oh...you can't even remember your own name...");
                Program.currentPlayer.name = "Harrietta Styluspen";
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("You feel around in the darkness until you find a previously lit torch...");
                Console.WriteLine("You aren't sure how you are going to light this in a rainy forest to illuminate your way.");
                Console.ReadKey();
                Console.WriteLine("You then hear rustling coming from behind you.");
                Console.ReadKey();
                Console.WriteLine("Shakenly, you turn...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"You know your name is {Program.currentPlayer.name}.");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("You feel around in the darkness until you find a previously lit torch...");
                Console.WriteLine("You aren't sure how you are going to light this in a rainy forest to illuminate your way.");
                Console.ReadKey();
                Console.WriteLine("You then hear rustling coming from behind you.");
                Console.ReadKey();
                Console.WriteLine("Shakenly, you turn...");
                Console.ReadKey();
                Console.Clear();
            }
               
        }

        public static void MayorEncounter()
        {
            Console.WriteLine("You hear a shout from a distance and see a shadow running toward you.");
            Console.WriteLine("You hold up your torch in defense when a soft voice approaches");
            Console.ReadKey();
            Console.WriteLine("'Hello, there! I heard some ruckus in the distance and thought someone surely was in trouble.");
            Console.ReadKey();
            Console.WriteLine("It seems to be a Mayor?... A very short and round fellow.");
            Console.WriteLine($"'You must be {Program.currentPlayer.name}!'");
            Console.ReadKey();
            Console.WriteLine("How does this rotund man know who you are...?");
            Console.ReadKey();
            Console.WriteLine("'We've been waiting for you...'");
            Console.ReadKey();
            Console.Clear();
        }

        public static void TownGreeting()
        {
            Console.Write("You follow this Mayor that somewhat resembles a deflated basketball.");
            Console.Write("'This here is the town square, you see!'\n'We've set you up with an apartment to rest.'");
            Console.ReadKey();
            Console.Write("You wonder why the hospitality of this place is so great, you don't know these people.");
            Console.ReadKey();
            Console.Write("A woman with a tangled mess of hair approaches you... You notice there is a birds nest in her bun.");
            Console.Write($"'You must be {Program.currentPlayer.name}!'");
            Console.ReadKey();
            Console.WriteLine("This all seems very strange to you... Why does this strange woman have a birds nest in her bun?");
            Console.ReadKey();
            Console.WriteLine("'I bet you're wondering why we brought you here, huh?'");
            Console.ReadKey();
            Console.WriteLine("Yes.. of course you question the motive of this strange place and these strange but.. unatturally hospitable people.");
            JudeGreeting();

        }

        public static void JudeGreeting()
        {
            Console.Clear();
            Console.WriteLine($"'Well, well, well! Look what the cat bagged up and drug in! It's {Program.currentPlayer.name}!'");
        }
    }
}
