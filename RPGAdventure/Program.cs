using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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

        public static Player LoadGame()
        {
            Console.Clear();
            Console.WriteLine("Choose Save: ");
            string[] paths = Directory.GetDirectories("saves");
            List<Player> players = new List<Player>();

            BinaryFormatter binform = new BinaryFormatter();
            foreach (string p in paths)
            {
                FileStream file = File.Open(p, FileMode.Open);
                Player player = (Player)binform.Deserialize(file);
                file.Close();
                players.Add(player);

            }

            while(true)
            {
                Console.Clear();
                Console.WriteLine("Please input player name or ID: ");

                foreach (Player p in players)
                {
                    Console.WriteLine($"{ p.saveID} : {p.name} : {p.gold}");
                }
                string[] data = Console.ReadLine().Split(':');

                try
                {
                    if(data[0] == "id")
                    {
                        if(int.TryParse(data[1],out int id))
                        {
                            foreach (Player player in players)
                            {
                                if(player.saveID == id)
                                {
                                    return player;
                                }
                            }
                            Console.WriteLine("Player ID not recognized. Press any key to continue.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Player ID not recognized. Press any key to continue.");
                            Console.ReadKey();
                        }
                    }
                }
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Player ID not recognized. Press any key to continue.");
                    Console.ReadKey();
                }
            }

        }
    }
}
