using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Numbers;

namespace NumbersProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; a <= a; i++)
            {
                Console.Write(Number.fibon(i) + " ");
                if (i == a)
                {
                    Console.WriteLine("\nSuccess!");
                    break;
                }
            }

            Console.Write("Please input number to check is it a simple number: ");
            a = int.Parse(Console.ReadLine());
            if (Number.IsSimple(a))
                Console.Write("It`s simple :)");
            else
                Console.Write("It isn`t simple :(");
            Console.ReadKey();
        }
    }
}
