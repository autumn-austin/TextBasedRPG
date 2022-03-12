using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace RPGAdventure
{
    public class Program : Apartment
    {
        public static Player currentPlayer = new Player();
        public static bool mainLoop = true;

        static void Main(string[] args)
        {
            Story.Start();
            Story.MayorEncounter();
            Story.TownGreeting();
            Story.JudeGreeting();
            
        }
    }
}
