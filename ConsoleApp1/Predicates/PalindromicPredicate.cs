using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Predicates
{
    internal class PalindromicPredicate : IPredicate
    {
        public bool Check(int number)
        {
            int reversedNumber = 0;
            int tmp = number;
            while (tmp > 0)
            {
                reversedNumber = (reversedNumber * 10) + (tmp % 10);
                tmp /= 10;
            }

            return number == reversedNumber;
        }
    }
}
