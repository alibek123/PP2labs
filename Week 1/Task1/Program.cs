using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static bool isPrime(int n)   //Creating the function whether number n that isbeing initialized is prime or not
        {
            if (n < 2) return false;    //If number is less than 2 it is not prime number
            for(int i =2;i<n;i++)
            {
                if(n%i==0) return false;    //If number is divided by any number that larger than 2 except itself it is not prime number
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  //inputing the length of array
            int[] a = new int[n];                   //Creating new integer array with n elements

            string[] nums = Console.ReadLine().Split(new char[] {' ',','});//Input elements in string array "nums"

            int cnt = 0;
            for(int i =0;i<nums.Length;i++)
            {
                a[i] = int.Parse(nums[i]);      //Converting string elements in "nums" to int elements "a" array
                if (isPrime(a[i])) cnt++;       //If elements in an array "a" is prime then "cnt" will count them
            }
            Console.WriteLine(cnt);     //Displaying the quantity of prime numbers
            for(int i=0;i<a.Length;i++)
            {
                if (isPrime(a[i]))
                    Console.Write(a[i] + " ");  //Displaying the prime numbers
            }
        }
    }
}
