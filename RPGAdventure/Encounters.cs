using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    public class Encounters
    {
        static Random rand = new Random();
        //Encounter Generic

        //Encounters
        public static void FirstEncounter()
        {
            Console.WriteLine("There stands a woodland creature ");
            Console.WriteLine("that somewhat resembles a rat, but it is of unusual size.");

            Combat(false, "Ratbus", 1, 4);
        }

        public static void BasicFightEncounter()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.ReadKey();
            Combat(true, "", 0, 0);
        }

        public static void MayorEncounter()
        {
            Console.WriteLine("You hear a shout from a distance and see a shadow running toward you.");
            Console.WriteLine("You hold up your torch in defense when a soft voice approaches");
            Console.WriteLine("'Hello, there! I heard some ruckus in the distance and though someone surely was in trouble.");
            Console.WriteLine("It's the Mayor of this town... A very short and round fellow.");
            Console.WriteLine("'You must be " + Program.currentPlayer.name + "!'");
            Console.WriteLine("How does this rotund man know who you are...?");
            Console.WriteLine("'We've been waiting for you...");
            Console.ReadKey();
        }

        public static void RandomEncounter()
        {
            switch(rand.Next(0,1))
            {
                case 0:
                    BasicFightEncounter();
                    break;
            }
        }


        //Encounter Tools
        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if(random)
            {
                n = GetName();
                p = Program.currentPlayer.GetPower();
                h = Program.currentPlayer.GetHealth();
            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while(h > 0)
            {
                Console.Clear();
                Console.WriteLine("  ,,==.");
                Console.WriteLine(" //    `");
                Console.WriteLine("||      ,--~~~~-._ _(|--,_");
                Console.WriteLine(" \\._,-~   )      '    *  `o");
                Console.WriteLine("  `---~\\ _/,___( /_/`---~~");
                Console.WriteLine("        ``==-    `==-,");
                Console.WriteLine(n);
                Console.WriteLine(p + "/" + h);
                Console.WriteLine("========================");
                Console.WriteLine("~ (A)ttack    (S)peak  ~");
                Console.WriteLine("~ (D)efend    (F)lee   ~");
                Console.WriteLine("~        (H)eal        ~");
                Console.WriteLine("========================");
                Console.WriteLine("Potions: " + Program.currentPlayer.potion + " Health: " + Program.currentPlayer.health);
                string input = Console.ReadLine();
                if(input.ToLower() == "a"||input.ToLower() == "attack")
                {
                    //attack
                    Console.WriteLine("With haste, you surge forth, your torch making a loud WOOSH as it comes down!");
                    Console.WriteLine("As you pass, the " + n + " strikes you in return!");

                    int damage = p - Program.currentPlayer.armorValue;
                    if(damage < 0)
                        damage = 0;

                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);

                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage.");

                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "s" || input.ToLower() == "speak")
                {
                    //speak
                    Console.WriteLine("You attempt to gain information from " + n + " but " + n + " doesn't want to chat.");
                    Console.ReadKey();                   
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //defend
                    Console.WriteLine("As the " + n + " prepares to attack, you brace with your torch.");

                    int damage = (p/4) - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;

                    int attack = rand.Next(0, Program.currentPlayer.weaponValue)/2;

                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage.");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "f" || input.ToLower() == "flee")
                {
                    //flee
                    if(rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("You attempt to flee... but it looks like " + n + " has a strong gaze upon you.");
                        Console.WriteLine("I don't think you are going anywhere...");
                        int damage = p - Program.currentPlayer.armorValue;

                        if (damage < 0)
                            damage = 0;

                        Console.WriteLine("You lose " + damage + " health, and are unable to escape.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You use your charm and wit to distract the " + n + " as you slink away to safety.");
                        Console.ReadKey();
                        // CALL GO TO TOWN, FROM TOWN CAN ENTER STORE, CREATE CLASS FOR TOWN
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //heal
                    if(Program.currentPlayer.potion == 0)
                    {
                        Console.WriteLine("You frantically search your pockets...");
                        Console.WriteLine("...pocket lint...");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;

                        Console.WriteLine("You take " + damage + "and " + n + "wriggles around excitedly.");
                    }
                    else
                    {
                        Console.WriteLine("You frantically search your pockets...");
                        Console.WriteLine("A giant red vial you pull from your pocket.");
                        Console.WriteLine("How did that fit in there?\nYou drink the vial.");
                        int potionValue = 5;
                        Console.WriteLine("You gain " + potionValue + " health and get the jitters.");
                        Program.currentPlayer.health += potionValue;
                        Console.WriteLine("You had your back turned searching your pockets...");
                        Console.WriteLine(n + " strikes you in the rear.");
                        int damage = (p / 2) - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health.");
                    }
                    Console.ReadKey();
                }
                if(Program.currentPlayer.health <= 0)
                {
                    //Death Code
                    Console.WriteLine("The " + n + " has killed you... Don't give up now!");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                Console.ReadKey();
            }
            int c = rand.Next(10, 50);
            Console.WriteLine("You did it... You killed the " + n + " and it dropped " + c + " gold.");
            Console.WriteLine("Congratulations.");
            Program.currentPlayer.gold += c;
            Console.ReadKey();
        }

        public static string GetName()
        {
            switch(rand.Next(0, 4))
            {
                case 0:
                    return "Skelebone";
                case 1:
                    return "Ghostopher";
                case 2:
                    return "Jeff";
                case 3:
                    return "Rogue Tree";
                case 4:
                    return "The Mooshlings";
            }
            return "Ratbus";
        }

    }
}
