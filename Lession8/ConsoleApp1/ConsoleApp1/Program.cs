using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Weapon
    {
        public byte damage { get; set; }
        public byte weight { get;  set; }

        public Weapon(byte damage, byte weight)
        {
            this.weight = weight;
            this.damage = damage; 
        }
        Weapon katana = new Weapon(80, 20);
        Weapon nunchaks = new Weapon(60, 10);
        Weapon stick = new Weapon(50, 40);
        Weapon hammer = new Weapon(90, 80);
    }
    internal class Ninja : Weapon
    {
        bool isInvifible = false;
        object weapon;
        public Ninja()
        {
            
        }

        void attack()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           

            Console.ReadKey();          
        }
    }

    
}
