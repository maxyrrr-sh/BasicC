using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recourse
{
    class Program
    {
        static ulong fibon(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return fibon(n - 1) + fibon(n - 2);
        }

        static void Main(string[] args)
        {
            Console.Write("For: ");
            int a = int.Parse(Console.ReadLine());
            for(int i = 0; a <= a; i++)
            {
                Console.Write(fibon(i) + " ");
                if (i == a)
                {
                    Console.WriteLine("\nSuccess!");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
