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
            int n = int.Parse(Console.ReadLine());          //Inserting the size of an array
            int[] a = new int[n];                           //Creating an array

            string[] nums = Console.ReadLine().Split();     //Reading numbers of array

            for(int i=0;i<n;i++)
            {
                a[i] = int.Parse(nums[i]);                  //Converting numbers into integer
            }
            for(int i = 0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");                    //Writing one element of an array
                for (int j = i; j < i + 1; j++)             
                    Console.Write(a[j] + " ");              //Writing an element of an array again. j is equal to i, it writes elements till the next element(i+1),it means only one element
            }
        }
    }
}
