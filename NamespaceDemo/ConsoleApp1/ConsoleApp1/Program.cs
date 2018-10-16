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
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            We webFetcher = new WebFetcher();
            Console.WriteLine(webFetcher.Fetch("https://avia.yandex.ru/?win=309&clid=2256434-306&utm_source=distribution&utm_medium=bookmark&utm_campaign=ru"));

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
