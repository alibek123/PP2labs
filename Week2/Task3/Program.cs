using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void ShowSpace(int level) // The function that show Spaces
        {
            for (int k = 0; k < level; k++) // Cycle for showing Spaces
            {
                Console.Write("  ");// Show Spaces 
            }
        }
        public static void UsingDirc(DirectoryInfo dir, int level)
        {

            foreach (FileInfo file in dir.GetFiles()) // Cycle for Files
            {
                ShowSpace(level + 1); // Call the function "ShowSpace" with level + 1 To separate by space our files
                Console.WriteLine(file.Name); // Show the Name of each file from the given directory
            }
            foreach (DirectoryInfo direct in dir.GetDirectories()) // Cycle for Directories
            {
                ShowSpace(level + 1); // Call the function "ShowSpaces" with level + 1 To Separate by space out folders
                Console.WriteLine(direct.Name); // Show the name of the Folders
                UsingDirc(direct, level + 2); // Recursia (call function untill it ends with file)
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Алибек\Desktop\Comp Network"); // the path to the directory
            Console.WriteLine(dir.Name); // name Of folder
            UsingDirc(dir, 0);//Call the function
            Console.ReadKey();
        }
    }
}
