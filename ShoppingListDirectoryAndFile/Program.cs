using System;
using System.IO;

namespace ShoppingListDirectoryAndFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\...\samples";


            bool loopActive = true;
            while (loopActive)
            {
                Console.WriteLine("Do you want to create a shopping list folder? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {

                    string newDirectory = @"shoppingList";
                    Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");

                    Console.WriteLine("Enter File name (.txt):");
                    string fileName = Console.ReadLine();

                    File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
                    break;
                }


                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                    break;
                }

             }
        }

        
    }
}
