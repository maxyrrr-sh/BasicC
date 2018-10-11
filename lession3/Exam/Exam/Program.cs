using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Математика: ");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Фізика: ");
            int Phuz = Convert.ToInt32(Console.ReadLine());
            Console.Write("Хімія: ");
            int him = Convert.ToInt32(Console.ReadLine());

            bool result = (math + Phuz + him >= 180 || math + Phuz >= 140 || math + him >= 140);

            Console.WriteLine(result ? "Студетн допущений":"Студент недопущений");

            Console.ReadKey();
        }
    }
}
