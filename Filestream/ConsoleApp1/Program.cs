using System;
using System.IO; // Filestream

namespace ConsoleApp1
{

    class Program
    {
        // paths
        private static string DirectoryPath = "EnPath";

        static void Main(string[] args)
        {

            // FILESTREAM
            // kolla om en mapp finns
            if (Directory.Exists(DirectoryPath))
            {
                Console.WriteLine("Exists: " + DirectoryPath);
            }

            // kolla om en fil finns
            if (File.Exists(@".\TestDir\TestFile_1.txt"))
            {
                Console.WriteLine("Exists: TestFile_1.txt");
            }

            // Lyssnar i mappen om det skapas nya filer, skriver ut dessa i konsolen
            fileStream.CreateWatcher();
            Console.Read();
            fileStream.DeleteDir();

            // Skapa en mapp
            fileStream.CreateDir();

            // Läs in från Json fil, returnerar en string
            string INFO = fileStream.ReadDataFromFile("Test.txt");

            // PARSE FROM JSON
            string[] InfoParsed = fileStream.parseJson(INFO);

            for (int i = 0; i < InfoParsed.Length - 1; i++)
            {
                Console.WriteLine(InfoParsed[i]);

            }

        }
    }
}
