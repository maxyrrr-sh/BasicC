using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hw
{
    class Program
    {
        static void Main(string[] args)
        { 
            string input;
            string dir;
            Console.WriteLine(@"Please input file operation create / delete / copy");
            input = Console.ReadLine(); dir = Console.ReadLine();
            FileInfo fileInfo = new FileInfo(dir);
            if (input == "create")
            {
                string filename = @"\test.txt";
                File.Create(dir + filename);
                

            } else if (input == "delete")
            {
                fileInfo.Delete();
            } else if (input == "copy")
            {
                Console.WriteLine("Please input directory:");
                string dir1 = Console.ReadLine();
                if(fileInfo.Exists)
                {
                    fileInfo.CopyTo(dir1, true);
                   
                }
            }
            Console.WriteLine("Success!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
