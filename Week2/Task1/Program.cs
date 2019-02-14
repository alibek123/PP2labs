using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool isPalindrome(string str)//Creating the function to check whether string str that is being initialized is palindrome or not
        {
            int l = 0;  
            int s = str.Length - 1; //last element of string

            while (s > 1)
            {
                if (str[l++] != str[s--])
                {
                    return false;   //if any element from begin and end are not same function returns false
                }
            }
            return true;    //if the elements are all same function returns true
        }

        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\text\123.txt", FileMode.Open, FileAccess.Read);//Creating new FileStream and accesing it to read 
            StreamReader sr = new StreamReader(fs);//New StreamWriter

            string str = ""; //blank string str
            while (!sr.EndOfStream)
            {
                str = sr.ReadLine();    //while cycle do not get to the end of stream it will continue to add chars into string str
            }

            if (isPalindrome(str))      //calling function isPalindrome
            {
                Console.WriteLine("Yes");   //if function returns true console will write "Yes"
            }
            else Console.WriteLine("No");   //if function returns false console will write "No"




            sr.Close();
            fs.Close();
        }
    }
}
