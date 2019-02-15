using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void print(DirectoryInfo d, int cursor) // creating the function for changing background and foreground color 
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            FileSystemInfo[] fsis = d.GetFileSystemInfos(); // create an array with adding folders and files
            for (int i = 0; i < fsis.Length; i++) 
            {
                if (fsis[i].GetType() == typeof(DirectoryInfo)) // if folder --white
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (fsis[i].GetType() == typeof(FileInfo)) // if file -- blue
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                if (i == cursor) // where cursor --red
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black; // otherwise background -- black
                }
                Console.WriteLine(fsis[i].Name); // write names of folders and files 
            }
        }
        static void Main(string[] args)
        {
            string path = @"C:\Users\Алибек\Desktop\456"; //Path
            DirectoryInfo d = new DirectoryInfo(path); // directory info of the path
            int cursor = 0; //create a cursor
            print(d, cursor); // call function for directoryInfo and cursor
            int n = d.GetFileSystemInfos().Length; // to know the maximum number of files and folders
            while (true) // infinitive cycle to process programm over and over, not finish after one button has pushed
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();// read button
                FileSystemInfo[] fsis = d.GetFileSystemInfos(); // adding files and  folders into array
                if (keyInfo.Key == ConsoleKey.UpArrow) // if we reached to top of the corner we need to go bottom
                {
                    cursor--;
                    if (cursor == -1)
                    {
                        cursor = n - 1;
                    }

                }
                if (keyInfo.Key == ConsoleKey.DownArrow)// if we reached to bottom of the corner we need to go top
                {
                    cursor++;
                    if (cursor == n)
                    {
                        cursor = 0;
                    }
                }
                if (keyInfo.Key == ConsoleKey.Enter) // press enter
                {
                    if (fsis[cursor].GetType() == typeof(DirectoryInfo)) // if folder
                    {
                        d = new DirectoryInfo(fsis[cursor].FullName); // create new directory of folder
                        n = d.GetFileSystemInfos().Length;
                        cursor = 0; // обнулить курсор
                    }
                    if (fsis[cursor].GetType() == typeof(FileInfo)) // if file
                    {
                        StreamReader sr = new StreamReader(fsis[cursor].FullName); //read it
                        Console.Clear();
                        Console.WriteLine(sr.ReadToEnd()); // read and write all text
                        Console.ReadKey();
                    }
                }
                if (keyInfo.Key == ConsoleKey.Backspace) // press backspace
                {
                    if (d.Parent != null) // if it has parent
                    {
                        d = d.Parent; // d is new parent
                        n = d.GetFileSystemInfos().Length;  
                        cursor = 0; 
                    }
                    else // if it has no parent
                    {
                        break;
                    }
                }
                
                if (keyInfo.Key == ConsoleKey.Delete) // press delete
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine("Are you sure? ");
                    Console.WriteLine("Y or N");
                    string y = Console.ReadLine();
                    if (y == "Y")
                    {
                        try
                        {
                            Directory.Delete(fsis[cursor].FullName, true); // delete folder
                        }
                        catch
                        {
                            File.Delete(fsis[cursor].FullName); // delete file
                        }
                    }
                }
                if (keyInfo.Key == ConsoleKey.F2) // при нажатии "R"
                {

                    if (fsis[cursor].GetType() == typeof(DirectoryInfo)) // if folder
                    {
                        Console.Clear();
                        Console.WriteLine("Please type new name of folder");
                        string s = Console.ReadLine(); // name of folder
                        string fileName = fsis[cursor].Name;
                        string dirPath = fsis[cursor].FullName; // full name of folder
                        int len = fileName.Length;
                        string newpath = ""; //new path
                        for (int i = 0; i < dirPath.Length - len; i++) //cycle to the folder
                        {
                            newpath = newpath + dirPath[i];
                        }
                        newpath = newpath + s; 
                        Directory.Move(dirPath, newpath);
                    }
                    if (fsis[cursor].GetType() == typeof(FileInfo)) // if file
                    {
                        Console.Clear();
                        Console.WriteLine("Please type new name of file");
                        string s = Console.ReadLine(); // name of file
                        string fileName = fsis[cursor].Name;
                        string dirPath = fsis[cursor].FullName;
                        int len = fileName.Length;
                        string newpath = "";//new path
                        for (int i = 0; i < dirPath.Length - len; i++)
                        {
                            newpath = newpath + dirPath[i];
                        }
                        newpath = newpath + s; 
                        File.Move(dirPath, newpath);
                    }
                }

                print(d, cursor);

            }
        }

    }
}