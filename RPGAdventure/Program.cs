using System;

namespace RPGAdventure
{
    class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start();
            Encounters.FirstEncounter();
        }

        static void Start()
        {
            Console.WriteLine("====================");
            Console.WriteLine("=                  =");
            Console.WriteLine("=     WELCOME      =");
            Console.WriteLine("=                  =");
            Console.WriteLine("====================");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Enter Player Name: ");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You awake in a rainy, dark forest. You feel dazed and are having trouble remembering");
            Console.WriteLine("anything about how you got here...");
            if (currentPlayer.name == "")
                Console.WriteLine("Oh...you can't even remember your own name...");
            else
            Console.WriteLine($"You know your name is {currentPlayer.name}.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You feel around in the darkness until you find a previously lit torch...");
            Console.WriteLine("You aren't sure how you are going to light this in a rainy forest to illuminate your way.");
            Console.WriteLine("You then hear a whisper coming from behind you.");
            Console.WriteLine("Shakenly, you turn...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
