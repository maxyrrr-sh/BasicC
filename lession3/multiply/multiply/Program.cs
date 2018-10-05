using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I wanna calculate something for you, input the first digit");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank’s and another digit please!:");
            int b = Convert.ToInt32(Console.ReadLine());

                if (((a <= 10) || (a >= 0)) && ((b <= 10) || (b >= 0)))
                    Console.WriteLine($"Here you are {a * b} :)");
                else
                    Console.WriteLine("Sorry, i support only digits from 0 to 10 :(");

            Console.ReadKey();
        }   
    }
}
//Console.WriteLine("Sorry, I do not now how to multiply chars :(");