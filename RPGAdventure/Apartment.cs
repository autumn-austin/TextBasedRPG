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

        }  
         
        public string RandomUserInput()
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "b" || input.ToLower() == "bed")
            {
                //Create Save File Location for player
                Program.Save();
                return "TODO: We should definitely save the game now.";
            }
            else if (input.ToLower() == "c" || input.ToLower() == "chair")
            {
                Random Rand = new Random();
                var saying = Rand.Next(1, 4);

                switch(saying)
                {
                    case 1:
                        return "Ah.. feels good to sit for a while, huh?";

                    case 2:
                        return "Someone cut the cheese... You blame the chair.";

                    case 3:
                        return "GET YOUR FEET OFF THE COFFEE TABLE! HEATHEN!";

                    case 4:
                        return "There are claw marks on the chair... You don't own a cat.";

                    default:
                        return "You found a raisin in the seat... how lucky!";
                }
            }
            else
            {
                return "TODO: We should probably save the game now!";
            }
        }
        public static void LoadLivingRoom(Player p)
            {
                RunLivingRoom(p);
            }
        public static void RunLivingRoom(Player p)
        {
            Console.WriteLine(" ____________________   ");
            Console.WriteLine("|  o  | ,----------, |  ");
            Console.WriteLine("|_____| |_===___O__| |  ");
            Console.WriteLine("|  o  | | ... ### .| |  ");
            Console.WriteLine("|_____|_|_O__ooo___|_|  ");
            Console.WriteLine(" (_)              (_)   ");
            Console.WriteLine(" === (M)usic Player ===   >>> (B)edroom? >>>");
        }
    }
}
