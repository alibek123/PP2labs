using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Алибек\Desktop\text123\SPath.txt", FileMode.Create, FileAccess.ReadWrite);//Creating new FileStream and accesing it to read and write
            StreamWriter sw = new StreamWriter(fs);//New StreamWriter
            sw.Write("Hello world"); //writing "Hello world" into txt file
            sw.Close(); //Closing StreamWriter          
            fs.Close(); //Closing FileStream
            string sPath = @"C:\Users\Алибек\Desktop\text123\SPath.txt";    //New string sPath, path that will be taken as a source  
            string tPath = @"C:\Users\Алибек\Desktop\text123\TPath.txt";    //New string tPath, path that will be taken as a target
            File.Copy(sPath, tPath, true); //Copying text from sPath to tPath
            File.Delete(sPath); //Deleting sPath
        }
    }
}