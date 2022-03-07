using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace RPGAdventure
{
    public class Program
    {
        public static Player currentPlayer = new Player();
        public static bool mainLoop = true;

        static void Main(string[] args)
        {
            Story.Start();
            Skelebone.EnemySkelebone();
            Story.MayorEncounter();
            Story.TownGreeting();
        }
    }
}
