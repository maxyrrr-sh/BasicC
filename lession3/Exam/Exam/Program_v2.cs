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
            Console.Write("����������: ");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Գ����: ");
            int Phuz = Convert.ToInt32(Console.ReadLine());
            Console.Write("ճ��: ");
            int him = Convert.ToInt32(Console.ReadLine());
            
            if (math + Phuz + him >= 180 || math + Phuz >= 140 || math + him >= 140){
                Console.WriteLine("������� ���������");
            } else {
                Console.WriteLine("������� �����������");
            }
            
            
            Console.ReadKey();
            
        }
    }
}