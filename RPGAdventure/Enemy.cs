using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    public abstract class Enemy
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public string Name { get; set; }
        public string InitialStatement { get; set; }

        public void Menu()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Power: " + Power);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine(this.InitialStatement);
            var response = Console.ReadLine();
            ActOnAction(response);
        }

        public static void ActOnAction(string response)
        {
            Console.WriteLine("========================");
            Console.WriteLine("~ (A)ttack    (S)peak  ~");
            Console.WriteLine("~ (D)efend    (F)lee   ~");
            Console.WriteLine("~        (H)eal        ~");
            Console.WriteLine("========================");
            Console.WriteLine("Potions: " + Program.currentPlayer.potion + " Health: " + Program.currentPlayer.health);
            string input = Console.ReadLine();
        }
    }
}
