using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFetcher;

namespace ConsoleApp1
{
    class Program
    {
        static int method (int a)
        {
            a += 2;
            return method(a);
        }
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.

            try
            {
                // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
                Console.Write(method(10));
            } catch(StackOverflowException e)
            {
                Console.Write(e);
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
