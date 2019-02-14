using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static bool isPrime(int n)   //Creating the function to check whether number n that is being initialized is prime or not

        {
            if (n < 2) return false;    //If number is less than 2 it is not prime number
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;   //If number is divided by any number that larger than 2 except itself it is not prime number
            }
            return true;
        }

        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:/Users/Алибек/Desktop/text123/1234.txt", FileMode.Create, FileAccess.ReadWrite);//Creating new FileStream and accesing it to read and write
            StreamWriter sw = new StreamWriter(fs);//New StreamWriter

            string text = File.ReadAllText("C:/Users/Алибек/Desktop/text123/primes.txt");   //reading the numbers that in source file
            string[] lines = text.Split();  //adding numbers in array"lines"

            int[] a = new int[lines.Count()];   //creating integer array "a"
            for (int i = 0; i < lines.Length; i++)
            {
                a[i] = int.Parse(lines[i]); //adding array "lines" into array "a" by parsing it into integer 
            }
            for (int i = 0; i < lines.Length; i++)
            {
                if (isPrime(a[i]))      //Calling function isPrime to check whether numbers are prime or not
                {
                    sw.Write(a[i] + " ");   //Writing prime numbers into new text file
                }
            }
            
            sw.Close();//Closing StreamWriter  
            fs.Close();//Closing FileStream

        }
    }
}
