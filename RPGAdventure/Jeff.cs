using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    class Jeff
    {
        static Random rand = new Random();
        public static void EnemyJeff()
        {
            JeffBattle("Jeff", 2, 5);

        }

        public static void JeffBattle(string name, int power, int health)
        {
            string n = "Jeff";
            int p = 2;
            int h = 5;

            n = name;
            p = power;
            h = health;

            while (h > 0)
            {
                Console.WriteLine(n);
                Console.WriteLine("Power: " + p);
                Console.WriteLine("Health: " + h);
                Console.WriteLine("             ,,,,,,,,");
                Console.WriteLine("           ,|||````||||");
                Console.WriteLine("     ,,,,|||||       ||,");
                Console.WriteLine("  ,||||```````       `||");
                Console.WriteLine(",|||`                 |||,");
                Console.WriteLine("||`     ....,          `|||");
                Console.WriteLine("||     ::::::::          |||,");
                Console.WriteLine("||     :::::::'     ||    ``|||,");
                Console.WriteLine("||,     :::::'               `|||");
                Console.WriteLine("`||,                           |||");
                Console.WriteLine(" `|||,       ||          ||    ,||");
                Console.WriteLine("   `||                        |||`");
                Console.WriteLine("    ||                   ,,,||||");
                Console.WriteLine("    `|||,,               ,|||");
                Console.WriteLine("        ``|||||||||||||||`");
                Console.WriteLine("      'Existance... hurts...");
                Console.WriteLine("===============================");
                Console.WriteLine("");
                Console.WriteLine("========================");
                Console.WriteLine("~ (A)ttack    (S)peak  ~");
                Console.WriteLine("~ (D)efend    (F)lee   ~");
                Console.WriteLine("~        (H)eal        ~");
                Console.WriteLine("========================");
                Console.WriteLine("Potions: " + Program.currentPlayer.potion + " Health: " + Program.currentPlayer.health);
                string input = Console.ReadLine();

                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //attack
                    Console.WriteLine("You smack " + n + " with your torch." + n + " doesn't feel anything.");
                    Console.WriteLine("You forgot " + n + " is a ghost...");

                    int damage = p - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;

                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);

                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage.");

                    Program.currentPlayer.health -= damage;
                    h -= attack;

                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input.ToLower() == "s" || input.ToLower() == "speak")
                {
                    //speak
                    Console.WriteLine("You attempt to gain information from " + n + " but " + n + " doesn't want to chat.");
                    Console.ReadKey();
                    Console.WriteLine("'Tra La La'");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    int damage = (p / 4) - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;

                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) / 2;

                    Console.WriteLine("You lose sight of " + n + " but " + n + " feel a cold spot on your head.");
                    Console.ReadKey();
                    Console.WriteLine("'I'm your hat now.'");
                    Console.ReadKey();
                    Console.WriteLine("You lose " + damage + " health from shivering and deal " + attack + " damage to " + n + "'s sheet. It's egyptian cotton.");

                    Program.currentPlayer.health -= damage;
                    h -= attack;
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //heal
                    if (Program.currentPlayer.potion == 0)
                    {
                        Console.WriteLine("You frantically search your pockets...");
                        Console.WriteLine("...pocket lint...");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;

                        Console.WriteLine("You take " + damage + "and " + n + "wriggles around excitedly.");

                        Console.ReadKey();
                        Console.Clear();
                    }
                    
                    else
                    {
                        Console.WriteLine("You frantically search your pockets...");
                        Console.WriteLine("A giant red vial you pull from your pocket.");
                        Console.WriteLine("How did that fit in there?\nYou drink the vial.");
                        int potionValue = 5;
                        Console.WriteLine("You gain " + potionValue + " health and get the jitters.");
                        Program.currentPlayer.health += potionValue;
                        Program.currentPlayer.potion -= 1;
                        Console.WriteLine("You had your back turned searching your pockets...");
                        Console.WriteLine(n + " strikes you in the rear. You blush...");
                        int damage = (p / 2) - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health.");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input.ToLower() == "f" || input.ToLower() == "flee")
                {
                    //flee
                    if (rand.Next(0, 2) == 0)
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
                        new Town().Load(Program.currentPlayer);
                        // CALL GO TO TOWN, FROM TOWN CAN ENTER STORE, CREATE CLASS FOR TOWN
                    }
                }
                if (Program.currentPlayer.health <= 0)
                {
                    //Death Code
                    Console.WriteLine("The " + n + " has killed you... Don't give up now" + Program.currentPlayer.name + "!");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                Console.ReadKey();
            }

            int c = Program.currentPlayer.GetCoins();
            Console.WriteLine("You killed " + n + " and received " + c + " gold.");
            Console.ReadKey();
            Console.WriteLine("Don't spend it all in one place.");
            Program.currentPlayer.gold += c;
            Console.ReadKey();
            Console.Clear();
        }
    }
}
