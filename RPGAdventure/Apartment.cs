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

        public void Load(Player p)
        {
            Run(p);
        }
        public void Run(Player p)
        {
            Console.WriteLine("  ()___                                .-===-.  ");
            Console.WriteLine("()//__/)_________________()            | . . |  ");
            Console.WriteLine("||(___)//#/_/#/_/#/_/#()/||            | .'. |  ");
            Console.WriteLine("||----|#| |#|_|#|_|#|_|| ||           ()_____() ");
            Console.WriteLine("||____|_|#|_|#|_|#|_|#||/||           ||_____|| ");
            Console.WriteLine("||    |#|_|#|_|#|_|#|_||               W     W  ");
            Console.WriteLine("========= (B)ed ========          ==== (C)hair ====    >>> (L)iving room? >>>");
            RandomUserInput();
        }  
         
        public string RandomUserInput()
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "b" || input.ToLower() == "bed")
            {
                Program.SaveGame();
                Console.ReadKey();
                Console.Clear();
                new Apartment().Load(Program.currentPlayer);

                return "Time to Save!";
            }
            else if (input.ToLower() == "c" || input.ToLower() == "chair")
            {
                while (input.ToLower() == "c" || input.ToLower() == "chair")
                {
                    Random Rand = new Random();
                    var saying = Rand.Next(0, 2);

                    switch (saying)
                    {
                        case 0:
                            Console.WriteLine("Feels nice to relax.");
                            break;

                        case 1:
                            Console.WriteLine("Feels nice to relax.");
                            break;
                        case 2:
                            Console.WriteLine("Feels nice to relax.");
                            break;
                    }
                }
                
            }
            else if (input.ToLower() == "l" || input.ToLower() == "living room")
            {
                new LivingRoom().Load(Program.currentPlayer);
            }

            return "You should probably save your game here.";

        }
       
    }
}
