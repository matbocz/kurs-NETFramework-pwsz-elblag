using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldersAndFilesApp
{
    class FoldersAndFiles
    {
        public static void FoldersAndFilesList(string dir)
        {
            if (File.Exists(dir))
            {
                ShowFile(dir);
            }
            else if (Directory.Exists(dir))
            {
                OpenDirectory(dir);
            }
            else
            {
                Console.WriteLine("{0}", dir);
                Console.WriteLine("Podana ścieżka nie istnieje!");
            }

        }

        static void OpenDirectory(string dir)
        {
            string[] fileEntries = Directory.GetFiles(dir);
            foreach (string file in fileEntries)
                ShowFile(file);

            string[] subdirEntries = Directory.GetDirectories(dir);
            foreach (string subdir in subdirEntries)
                OpenDirectory(subdir);
        }

        static void ShowFile(string path)
        {
            Console.WriteLine("{0}", path);
        }

        public static void FileProperties(string dir)
        {
            if (File.Exists(dir))
            {
                FileInfo oFileInfo = new FileInfo(dir);
                Console.WriteLine("\nName: \"" + oFileInfo.Name + "\"");
                DateTime dtCreationTime = oFileInfo.CreationTime;
                Console.WriteLine("Date: " + dtCreationTime.ToString());
                Console.WriteLine("Extension: " + oFileInfo.Extension);
                Console.WriteLine("Size: " + oFileInfo.Length.ToString());
                Console.WriteLine("Path: " + oFileInfo.DirectoryName);
            }
            else
            {
                Console.WriteLine("{0}", dir);
                Console.WriteLine("Podany plik nie istnieje!");
            }
        }

        public static void FileCopy(string fromFile, string toFile)
        {
            StreamReader srFrom;
            StreamWriter swTo;

            try
            {
                srFrom = new StreamReader(fromFile);
                swTo = new StreamWriter(toFile);

                Console.WriteLine();
                while (srFrom.Peek() != -1)
                {
                    string sBuffer = srFrom.ReadLine();
                    Console.WriteLine(sBuffer);
                    swTo.WriteLine(sBuffer.ToUpper());
                }
                Console.WriteLine("\nTreść pliku została skopiowana.");

                srFrom.Close();
                swTo.Close();
            }
            catch { Console.WriteLine("\nPodane pliki nie istnieją!"); }
        }
    }
}
