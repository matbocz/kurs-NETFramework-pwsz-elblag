using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldersAndFilesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory, folderName, fileName, fromFile, toFile, fromDir, toDir, hostFile;

            Console.WriteLine("======================= Lista plików i folderów =======================");
            Console.WriteLine("Podaj nazwę folderu: ");
            folderName = Console.ReadLine();

            directory = @".\" + folderName;
            FoldersAndFiles.FoldersAndFilesList(directory);


            Console.WriteLine("\n======================= Właściwości pliku =======================");
            Console.WriteLine("Podaj nazwe pliku: ");
            fileName = Console.ReadLine();

            directory += @"\" + fileName;
            FoldersAndFiles.FileProperties(directory);


            Console.WriteLine("\n======================= Kopiowanie zawartości pliku =======================");
            directory = @".\";

            fromDir = directory + "from.txt";
            toDir = directory + "to.txt";

            FoldersAndFiles.FileCopy(fromDir, toDir);


            Console.WriteLine("\n======================= Adresy IP =======================");
            hostFile = @"P:\kurs-NETFramework-pwsz-elblag\NETFramework_zad_3\FoldersAndFilesApp\bin\Debug\hosts.txt";
            HostIP.ReadFileToScreen(hostFile);
        }
    }
}
