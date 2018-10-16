using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //WebClient client = new WebClient();
            string a = Console.ReadLine();
            for(int i = 0; i <=a.Length; i++)
            {
                a[i] += '23';

            }
        }
    }
}
