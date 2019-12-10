using System;
using System.IO; // filestream
using Newtonsoft.Json.Linq; // Parse JSON

namespace ConsoleApp1
{
    public class fileStream
    {
        // Paths
        public const string pathToLogDir = @".\TestDir\";
        public const string pathToTemporaryDir = @".\TestDir\NyDir\";


        // Funktion som läser data från fil
        public static string ReadDataFromFile(string filename)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(filename))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    return line;
                }

            }
            catch (IOException e)
            {
                string message = ("The file could not be read:");
                Console.WriteLine(e.Message);
                return message;
            }

        }


        // funktion som kollar om den kommit nya filer i mapp genom Filewatcher
        public static void CreateWatcher()
        {
            // Create a new FileSystemWatcher.
            FileSystemWatcher watcher = new FileSystemWatcher();

            // Set the filter, kollar endast efter .txt filer
            watcher.Filter = "*.txt";

            // Subscribe to the Created event.
            watcher.Created += new FileSystemEventHandler(watcher_FileCreated);

            // Set the path 
            watcher.Path = pathToLogDir;

            // Enable the FileSystemWatcher events.
            watcher.EnableRaisingEvents = true;

        }

        // kollar efter nya filer, anropar sedan funktion som kopierar filerna 
        public static void watcher_FileCreated(object sender, FileSystemEventArgs e)
        {
            // skapa dir om ej finns.
            // CreateDir(pathToTemporaryDir);

            // när nya filer upptäcks
            Console.WriteLine("New file created ->" + e.Name);
            string filename1 = e.Name.ToString();
            CopyFile(filename1);
        }

        // Skapar en ny temporär mapp (om den inte redan finns)
        public static void CreateDir()
        {
            // kolla om mappen finns
            if(Directory.Exists(pathToTemporaryDir))
            {
                 Console.WriteLine("Dir exists");
            }
            else
            {
                // skapa mapp
                Console.WriteLine("Dir created");
                Directory.CreateDirectory(pathToTemporaryDir);
            }
         
        }

        // ta bort mapp när datat har skickats, true gör att även alla filer i mappen tas bort.
        public static void DeleteDir()
        {
            Directory.Delete(pathToTemporaryDir, true);
        }

        // kopiera de nya filerna in i den temporäta dir som skapas/skapats
        public static void CopyFile(string filename)
        {
            // Kopiera nya filer in i dir
           string SourceFileName = pathToLogDir + filename;
           string DestinationFileName = pathToTemporaryDir + filename;
           File.Copy(SourceFileName, DestinationFileName);

        }

        // PARSE FILE FROM JSON
        public static string[] parseJson(string information)
        {

            // parse string
            dynamic stuff = JObject.Parse(information);

            // array 5 platser
            string[] INFO = new string[5];

            INFO[0] = stuff.string1;
            INFO[1] = stuff.string2;
            INFO[2] = stuff.string3;
            INFO[3] = stuff.string4;

            // returnerar arrayen med all info
            return INFO;
        }

        // check for new files
        public static void newFileCheck1()
        {
            //  Visar alla filer i mappen
            foreach (string file in Directory.GetFiles(pathToLogDir))
            {
                Console.WriteLine("Det finns: " + file);

            }
        }


    }
}
