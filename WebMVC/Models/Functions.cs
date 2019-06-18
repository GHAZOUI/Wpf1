using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC.Models
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

            for (int i=0; i< b; i++)
            {
                res = res * a;
            }

            return res;
        }
    }
}