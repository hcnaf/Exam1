using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Predicates
{
    internal class PrimePredicate : IPredicate
    {
        public bool Check(int number)
        {
            if (number == int.MinValue || number == 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
