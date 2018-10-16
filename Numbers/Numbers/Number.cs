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
            if ( (n > 1) || (n == 2) || (n % 2 != 0) )
                return true;

            int a = (int)Math.Sqrt(n);

            for (int i = 3; i <= a; i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
            
    }
}

