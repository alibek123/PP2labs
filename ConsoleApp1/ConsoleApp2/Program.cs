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
        int year;
        public Student(string n, string i, int y)
        {
            name = n;
            id = i;
            year = y;
        }
        public void PrintInfo()
        {
            Console.WriteLine(name + " " + id + " " + year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("Alibek", "18BD110", 1);
            a.PrintInfo();
        }
    }
}
