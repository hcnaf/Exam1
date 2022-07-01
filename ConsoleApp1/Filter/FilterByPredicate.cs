using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class FilterByPredicate
    {
        public static int[] FilterBy(this int[] source, IPredicate predicate)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Array is empty.");
            }

            List<int> res = new List<int>();
            for (int i = 0; i < source.Length; ++i)
            {
                if (predicate.Check(source[i]))
                {
                    res.Add(source[i]);
                }
            }

            return res.ToArray();
        }
    }
}
