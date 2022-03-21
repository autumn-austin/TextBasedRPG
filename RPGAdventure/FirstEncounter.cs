using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    public class FirstEncounter
    {
        static Random rand = new Random();
        public static void FirstBattle()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.ReadKey();
            CombatNoFlee(true, "", 0, 0);

        }
        public static void CombatNoFlee(bool random, string name, int power, int health)
            {
                Random rand = new Random();

                string n = "";
                int p = 0;
                int h = 0;
                if (random)
                {
                    n = Encounters.GetName();
                    p = Program.currentPlayer.GetPower();
                    h = Program.currentPlayer.GetHealth();
                }
                else
                {
                    n = name;
                    p = power;
                    h = health;
                }
                while (h > 0)
                {
                    Console.WriteLine(n);
                    Console.WriteLine(p + "/" + h);
                    Console.WriteLine("========================");
                    Console.WriteLine("~ (A)ttack    (S)peak  ~");
                    Console.WriteLine("~ (D)efend    (H)eal   ~");
                    Console.WriteLine("========================");
                    Console.WriteLine("Potions: " + Program.currentPlayer.potion + " Health: " + Program.currentPlayer.health);
                    string input = Console.ReadLine();
                    if (input.ToLower() == "a" || input.ToLower() == "attack")
                    {
                        //attack
                        Console.WriteLine("With haste, you surge forth, your torch making a loud WOOSH as it comes down!");
                        Console.WriteLine("As you pass, the " + n + " strikes you in return!");

                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
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

                        int damage = (p / 4) - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;

                        int attack = rand.Next(0, Program.currentPlayer.weaponValue) / 2;

                        Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage.");
                        Program.currentPlayer.health -= damage;
                        h -= attack;
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
                            Console.WriteLine(n + " strikes you in the rear.");
                            int damage = (p / 2) - Program.currentPlayer.armorValue;
                            if (damage < 0)
                                damage = 0;
                            Console.WriteLine("You lose " + damage + " health.");
                        }
                        Console.ReadKey();
                    }
                    if (Program.currentPlayer.health <= 0)
                    {
                        //Death Code
                        Console.WriteLine("The " + n + " has killed you... Don't give up now!");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                    }
                    Console.ReadKey();
                }

                int c = Program.currentPlayer.GetCoins();
                Console.WriteLine("You did it... You killed the " + n + " and it dropped " + c + " gold.");
                Console.WriteLine("Congratulations.");
                Program.currentPlayer.gold += c;
                Console.ReadKey();
            
        }
    }
}    
