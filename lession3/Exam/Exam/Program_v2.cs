using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureThird
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
            
            if (math + Phuz + him >= 180 || math + Phuz >= 140 || math + him >= 140){
                Console.WriteLine("Студетн допущений");
            } else {
                Console.WriteLine("Студент недопущений");
            }
            
            
            Console.ReadKey();
            
        }
    }
}