using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCode
{
    class Fibonacci
    {
        public int CalculateFibonnacciNumber(int n)
        {
            int fibonacci0 = 0;
            int fibonacci1 = 1;
            int fibonacciN = 0;

            while(n > 0)
            {
                fibonacciN = fibonacci0 + fibonacci1;
                fibonacci0 = fibonacci1;
                fibonacci1 = fibonacciN;
                n--;
            }

            return fibonacciN;
        }
    }
}
