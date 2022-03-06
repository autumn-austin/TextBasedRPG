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
            Console.WriteLine("====================");
            Console.WriteLine("=                  =");
            Console.WriteLine("=     WELCOME      =");
            Console.WriteLine("=                  =");
            Console.WriteLine("====================");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Enter Player Name: ");
            Program.currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You awake in a rainy, dark forest. You feel dazed and are having trouble remembering");
            Console.WriteLine("anything about how you got here...");
            if (Program.currentPlayer.name == "")
                Console.WriteLine("Oh...you can't even remember your own name...");
            else
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
        }

        public static void MayorEncounter()
        {
            Console.WriteLine("You hear a shout from a distance and see a shadow running toward you.");
            Console.WriteLine("You hold up your torch in defense when a soft voice approaches");
            Console.WriteLine("'Hello, there! I heard some ruckus in the distance and thought someone surely was in trouble.");
            Console.WriteLine("It seems to be a Mayor?... A very short and round fellow.");
            Console.WriteLine("'You must be " + Program.currentPlayer.name + "!'");
            Console.WriteLine("How does this rotund man know who you are...?");
            Console.WriteLine("'We've been waiting for you...");
            Console.ReadKey();
        }

        public static void TownGreeting()
        {
            Console.Write("You follow this Mayor that somewhat resembles a deflated basketball.");
            Console.Write("'This here is the town square, you see!'\n'We've set you up with an apartment to rest.'");
            Console.Write("You wonder why the hospitality of this place is so great, you don't know these people.");
            Console.Write("A woman with a tangled mess of hair approaches you... You notice there is a birds nest in her bun.");
            Console.Write("'You must be!" + Program.currentPlayer.name + "'");
        }
    }
}
