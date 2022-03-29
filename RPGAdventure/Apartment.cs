using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime;

namespace RPGAdventure
{
    public class Apartment : Place
    {
        public enum Saying
        {
            Saying1,
            Saying2,
            Saying3
        }

        public void Load(Player p)
        {
            Run(p);
        }
        public void Run(Player p)
        {
            Console.Clear();
            Console.WriteLine("  ()___                                .-===-.  ");
            Console.WriteLine("()//__/)_________________()            | . . |  ");
            Console.WriteLine("||(___)//#/_/#/_/#/_/#()/||            | .'. |  ");
            Console.WriteLine("||----|#| |#|_|#|_|#|_|| ||           ()_____() ");
            Console.WriteLine("||____|_|#|_|#|_|#|_|#||/||           ||_____|| ");
            Console.WriteLine("||    |#|_|#|_|#|_|#|_||               W     W  ");
            Console.WriteLine("========= (B)ed ========          ==== (C)hair ====    >>> (L)iving room? >>>");
            Console.WriteLine("                       (E)xit Apartment");
            RandomUserInput();
        }

        public string RandomUserInput()
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "b" || input.ToLower() == "bed")
            {
                Program.SaveGame();
                Console.ReadKey();
                new Apartment().Load(Program.currentPlayer);

                return "Time to Save!";
            }
            else if (input.ToLower() == "c" || input.ToLower() == "chair")
            {
                Saying s = (Saying)(new Random()).Next(0, 3);
                switch (s)
                {
                    case Saying.Saying1:
                        Console.WriteLine("If it fits, you sits.");
                        break;
                    case Saying.Saying2:
                        Console.WriteLine("You find claw marks on the chair... You don't own a cat?");
                        break;
                    case Saying.Saying3:
                        Console.WriteLine("A loud rumble is heard as you sit, you blame the chair.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                new Apartment().Load(Program.currentPlayer);

            }
            else if (input.ToLower() == "l" || input.ToLower() == "living room")
            {
                new LivingRoom().Load(Program.currentPlayer);

            }
            else if (input.ToLower() == "e" || input.ToLower() == "exit")
            {
                new Town().Load(Program.currentPlayer);
            }
            else
            {
                new Apartment().Load(Program.currentPlayer);
            }
            return "Be on with you, fair adventurer!";

        }
    }
}
