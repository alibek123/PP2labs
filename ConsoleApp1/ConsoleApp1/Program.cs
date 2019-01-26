using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(a);
            int[] arr = new int[b];
            for (int i = 0; i < b; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int d=0;
            for(int i =0;i<b;i++)
            {
                if (arr[i] == 0 || arr[i] == 1)
                    continue;
                else
                {
                    if(arr[i]==2)
                    {
                        d++;
                    }
                    else
                    {
                        if(arr[i]%i!=0)
                        {
                            d++;
                        }
                    }
                }
            }
            Console.WriteLine(d);
            
        }
    }
}
