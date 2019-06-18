using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitTestProject2
{
    public class Functions
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Soustraction(int a, int b)
        {
            return a - b;
        }

        public long Puissance(int a, int b)
        {
            long res = a;

            for (int i=1; i< b; i++)
            {
                res = res * a;
            }

            return res;
        }

        public virtual int Factorielle(int a)
        {
            if (a <= 1)
                return 1;
            return a * Factorielle(a - 1);
        }

        public int ResultFactorielle(int a)
        {
            var resss = Factorielle(a);
            return resss;
        }

    }

    // The helper class to test the recursion
    public class FactorialTester : Functions
    {
        public int NumberOfCalls { get; set; }

        public override int Factorielle(int number)
        {
            NumberOfCalls++;
            return base.Factorielle(number);
        }
    }
}