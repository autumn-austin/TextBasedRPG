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

        public static bool mainLoop = true;

        static void Main(string[] args)
        {
            
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
            Console.WriteLine("Press any key to save game data.");
            Console.ReadKey();
            static void Serialize(Object file, String path, Type type)
            {
                // Create a new serializer
                XmlSerializer serializer = new XmlSerializer(type);
                //Create new StreamWriter
                TextWriter writer = new StreamWriter(path);
                //Serialize to file
                serializer.Serialize(writer, file);
                //Close writer
                writer.Close();

            }

        }

        public static object LoadGame(String path, Type type)
        {
            //Create new serializer
            XmlSerializer serializer = new XmlSerializer(type);
            //create streamreader
            TextReader reader = new StreamReader(path);
            //Deserialize the file
            Object file;
            file = (Object)serializer.Deserialize(reader);
            //close reader
            reader.Close();
            //return the object
            return file;
        }
    }
}
