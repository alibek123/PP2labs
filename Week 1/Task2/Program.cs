using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        string name;
        string id;
        public Student(string n, string i)
        {
            name = n;                           //Creating the class "Student" with 2 parameters
            id = i;
        }
        public void PrintInfo()
        {
            int n = 1;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(name + " " + id + " " + n++);         //Function will write student name and id 4 times repeatedly
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("Alibek", "18BD110");       //Student info, entering the class
            a.PrintInfo();                  //Calling function
        }
    }
}
