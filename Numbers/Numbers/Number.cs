using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public class Number
    {
        public static ulong fibon(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return fibon(n - 1) + fibon(n - 2);
        }

        public static bool IsSimple(int n)
        {
            bool isSimple = true;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    isSimple = false;
                    break;
                }
            }

            return isSimple;

            //int a = (int)Math.Sqrt(n);

            //for (int i = 3; i <= a; i += 2)
            //{
            //    if (n % i == 0) return false;
            //}


        }
            
    }
}

