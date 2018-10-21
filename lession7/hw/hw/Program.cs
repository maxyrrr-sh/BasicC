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
            Console.Clear();
            string input;
            string dir;
        tp:
            
            Console.WriteLine(@"Please input file operation create / delete / copy");
            try
            {
                throw new Exception();
                input = Console.ReadLine(); dir = Console.ReadLine();
                FileInfo fileInfo = new FileInfo(dir);
                if (input == "create")
                {
                    string filename = @"\test.txt";
                    File.Create(dir + filename);


                }
                else if (input == "delete")
                {
                    fileInfo.Delete();
                }
                else if (input == "copy")
                {
                    Console.WriteLine("Please input directory:");
                    string dir1 = Console.ReadLine();
                    if (fileInfo.Exists)
                    {
                        fileInfo.CopyTo(dir1, true);

                    }
                    else
                    {
                        throw new IOException();
                    }
                }
            }
            
            catch(IOException e)
            {
                Console.WriteLine("");
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, something went wrong :9( \nDo you want to try again? y/n");
                string a = Console.ReadLine();
                if (a == "y")
                    goto tp;
            }
            Console.WriteLine("Success!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
