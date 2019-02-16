using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void method(string a, string b)
        {
            int n = int.Parse(a);
            string[] arr = b.Split(' ');    //creating a string array
            int[] array = new int[n];       //creating integer array
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(arr[i]);  //parsing string elements to an integer
                array[i] = x;               //adding integer elemnts to array "array"

            }
            List<int> list = new List<int>();   //creating new list
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    list.Add(array[i]);         //add "array" into list 2 times
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");   //write list
            }
        }
        static void Main(string[] args)
        {
            string n = Console.ReadLine();//number of elements 
            string s = Console.ReadLine();//elements of array
            method(n, s);//calling function method
        }
    }
}
