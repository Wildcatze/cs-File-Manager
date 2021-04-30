using System;
using System.IO;

namespace FileManager
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            String Source = @"E:\School\Code Practice\C#\File Manager\Items_to_read\";
            String FileManagerDirectory = @"E:\School\Code Practice\C#\File Manager";
            String Destination = @"E:\School\Code Practice\C#\File Manager\Items_seen\";
            bool DestinationExists = Directory.Exists(@"E:\School\Code Practice\C#\File Manager\Items_seen\");
            if (DestinationExists)
            {
                Console.WriteLine("Destination directory found, moving to the next command.");
            }
            else
            {
                Console.WriteLine("The Destination directory is not found. Creating directory.");
                Directory.CreateDirectory(Destination);
            }

            /*  This will copy one file from Source to Destination */
                File.Copy(Source + "Stone Lion.JPG",Destination + "Stone Lion.JPG", true); 
                Console.WriteLine("Your file has been copied."); 

            /*  his is how to move files
                File.Move(Source + "Daily.csv", Destination + "Daily.csv");
                Console.WriteLine("Your file has been moved."); */


            /*  This is how to display all the directories from a directory 
                String[] ThisShowsDirectories = Directory.GetDirectories(FileManagerDirectory, "*", SearchOption.AllDirectories);
                Console.WriteLine("Your directories present inside " + FileManagerDirectory + " are:");
                foreach (String dir in ThisShowsDirectories)
                {
                    Console.WriteLine(dir);
                }  */

            /*  This is how to see all the files inside a directory
                var SeeFiles = Directory.GetFiles(FileManagerDirectory, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("The files present inside " + Source + " are:");
                foreach (string file in SeeFiles)
                {
                    // Console.WriteLine(file);
                    // Console.WriteLine(Path.GetFullPath(file));
                    // Console.WriteLine(Path.GetFileName(file));
                    // Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                    // this is how to see the file size in bytes
                    // var info = new FileInfo(file);
                    // Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes");

                }   */
        }
    }
}