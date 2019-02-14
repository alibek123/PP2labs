using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)                //Creating 2 dimensional array
            {
                for (int j = 1; j <= i; j++)            
                {
                    Console.Write("[*]");               //Filling with stars
                }
                Console.Write("\n");                    //New line
            }
        }
    }
}
