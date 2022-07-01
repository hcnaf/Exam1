using ConsoleApp1.Predicates;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPredicate palindromicPredicate = new PalindromicPredicate();
            var testCases = new[] { 2212332, 0, 1405644, 12345, 1, -1236674, 123321, 1111111 }; //0, 1, 123321, 1111111

            var res = FilterByPredicate.FilterBy(testCases, palindromicPredicate);
            Console.WriteLine(string.Join(", ", res));



            IPredicate primePredicate = new PrimePredicate();
            var primeTestCases = new[] { 67, 33, 81, 71, 73, 66, 82, 79, 12, 55, 646, 83, 89, 97, 98, 34, 101, 103 }; //67, 71, 73, 79, 83, 89, 97, 101, 103

            var primeRes = FilterByPredicate.FilterBy(primeTestCases, primePredicate);
            Console.WriteLine(string.Join(", ", primeRes));
        }
    }
}
