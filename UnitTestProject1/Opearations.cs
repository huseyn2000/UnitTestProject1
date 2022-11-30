using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    internal class Opearations
    {

        public int factorial(int num)
        {

            int res = 1;

            for (int i = 1; i <= num; i++)
            {

                res *= i;

            }

            return res;

        }

        public int power(int bas, int pow)
        {
            int res = 1;

            for (int i = 1; i <= pow; i++)
            {
                res *= bas;

            }
            return res;


        }

        public string tesrAd(string name1)
        {
            string res = "";

            for (int i = name1.Length - 1; i >= 0; i--)
            {
                res += name1[i];
            }

            return res;
        }


    }
}
