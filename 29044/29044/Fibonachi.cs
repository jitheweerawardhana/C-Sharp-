using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29044
{
    public class Fibonachi
    {
        public long RecursiveFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        public long IterativeFibonacci(int n)
        {
            if (n <= 1) return n;

            int currentFib = 1;
            int previousFib = 1;

            for (int i = 2; i < n; i++)
            {
                int temp = currentFib;
                currentFib += previousFib;
                previousFib = temp;
            }
            return currentFib;
        }
    }
}

