using RPGAdventure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    public abstract class Enemy
    {
        public Random rand = new Random();
        public int Health { get; set; }
        public int Power { get; set; }
        public string Name { get; set; }
        public string InitialStatement { get; set; }

        public void Menu()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Power: " + this.Power);
            Console.WriteLine("Health: " + this.Health);
            Console.WriteLine(this.InitialStatement);
            ActOnAction();
        }

        public void ActOnAction()
        {
            Console.WriteLine("========================");
            Console.WriteLine("~ (A)ttack    (S)peak  ~");
            Console.WriteLine("~ (D)efend    (F)lee   ~");
            Console.WriteLine("~        (H)eal        ~");
            Console.WriteLine("========================");
            Console.WriteLine("Potions: " + Program.currentPlayer.potion + " Health: " + Program.currentPlayer.health);
            var response = Console.ReadLine();

            switch (response.ToLower())
            {
                case "a": 
                case "attack":
                    Attack();
                    break;

                case "d":
                case "defend":
                    Defend();
                    break;

                case "s":
                case "speak":
                    Speak();
                    break;

                case "f":
                case "flee":
                    Flee();
                    break;

                case "h":
                case "heal":
                    Heal();
                    break;
            }


            if (Program.currentPlayer.health <= 0)
            {
                Console.WriteLine($"The {this.Name} has killed you... Don't give up now {Program.currentPlayer.name}!");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            Console.ReadKey();

            int c = Program.currentPlayer.GetCoins();
            Console.WriteLine("You killed " + this.Name + " and received " + c + " gold.");
            Console.ReadKey();
            Console.WriteLine("Don't spend it all in one place.");
            Program.currentPlayer.gold += c;
            Console.ReadKey();
            Console.Clear();
        }
        public abstract void Attack();

        public abstract void Defend();

        public abstract void Speak();

        public abstract void Flee();

        public abstract void Heal();

    }
}
