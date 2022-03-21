using System;
using System.IO;
using System.Collections.Generic;

namespace RPGAdventure
{
    public class Program
    {
        public static Player currentPlayer = new Player();
        public static bool mainLoop = true;

        static void Main(string[] args)
        {
            if (!Directory.Exists("saves"))
            {
                Directory.CreateDirectory("saves");
            }
            Story.Start();
            new Apartment().Load(Program.currentPlayer);
            Console.ReadKey();
            var mon = new Ratbus();
            mon.Menu();
            Story.MayorEncounter();
            Story.TownGreeting();
            Story.JudeGreeting();
            
        }

        public static void SaveGame()
        {
            Player p = new Player();
            p.name = Program.currentPlayer.name;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(p.GetType());
            x.Serialize(Console.Out, p);
            Console.WriteLine("");
            Console.WriteLine("Game saved!");

        }

        public static void LoadGame()
        {
            //create load file to load from screen if save file exists
            Console.WriteLine("");
        }
    }
}
