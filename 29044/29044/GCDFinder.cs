using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29044
{
    public class GCDFinder
    {
        public long RecursiveGCD(int num1, int num2)
        {
            if (num2 == 0)
            {
                return num1;
            }
            else
            {
                return RecursiveGCD(num2, num1 % num2);
            }
        }

        public long IterativeGCD(int num1, int num2)
        {
            while (num2 != 0)
            {
                int temp = num1 % num2;
                num1 = num2;
                num2 = temp;
            }
            return num1;
        }
    }
}

