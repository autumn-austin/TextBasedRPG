using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace RPGAdventure
{
    public class Program
    {
        public static Player currentPlayer = new Player();

        static void Main(string[] args)
        {
            MainMenu.Opening();
            var mon = new Ratbus();
            mon.Menu();
            Story.MayorEncounter();
            Story.TownGreeting();
            Story.JudeGreeting();
            new Apartment().Load(currentPlayer);
            
        }

        public static void SaveGame()
        {
            Console.WriteLine("Press any key to save game data.");
            Console.ReadKey();
            Serialize(Program.currentPlayer, "./Player.xml", typeof(Player));
            Console.WriteLine("Game data saved!");
        }
        public static void LoadGame()
        {
           var Load =  Deserialize("./Player.xml", typeof(Player));
            currentPlayer = (Player)Load;
        }
        static object Deserialize(String path, Type type)
        {
            //Create new serializer
            XmlSerializer serializer = new XmlSerializer(type);
            //create streamreader
            TextReader reader = new StreamReader(path);
            //Deserialize the file
            Object obj;
            obj = (Object)serializer.Deserialize(reader);
            //close reader
            reader.Close();
            //return the object
            return obj;
        }
        static void Serialize(Object obj, String path, Type type)
        {
            // Create a new serializer
            XmlSerializer serializer = new XmlSerializer(type);
            //Create new StreamWriter
            TextWriter writer = new StreamWriter(path);
            //Serialize to file
            serializer.Serialize(writer, obj);
            //Close writer
            writer.Close();

        }
    }
}
