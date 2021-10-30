using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\...\samples"; //tahan luua uue faili kaustas samples

            //string newDirectory = @"wishList"; // loodava faili nimi on wishList - minu määratud

            Console.WriteLine("Enter directory name:"); //võimaldame kasutajal luua kausta tema poolt valitud nimega
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter File name (.txt):");//võimaldame kasutajal luua faili tema poolt valitud nimega
            string fileName = Console.ReadLine();

            //Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}"); // kausta loomine
            //File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");// faili loomine kaustas

            // kontrollin kas sellenimelist kausta ja faili asukohas esineb:
            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and File exist."); // kui eksisteerivad siis konsool teatab sellest
            }
            else
            {
            Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}"); // kui ei eksisteeri siis luuakse kaust ja fail - järgnevus oluline
            File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }


        }
    }
}
