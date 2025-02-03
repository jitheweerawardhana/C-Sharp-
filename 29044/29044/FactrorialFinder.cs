using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29044
{
    public class FactorialFinder
    {
        public long Factorial(int number)
        {
            if (number <= 1) return 1;

            return number * Factorial(number - 1);
        }

        public long IterativeFactorial(int n)
        {
            long result = 1;
            for (long i = n; i >= 1; i--)
            {
                result *= i;
            }
            return result;

        }
    }
}
