using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
             int a= int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            for(int i=0;i<a;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
