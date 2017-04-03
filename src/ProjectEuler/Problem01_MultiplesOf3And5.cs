using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// Problem 1: Multiples of 3 and 5
    /// https://projecteuler.net/problem=1
    /// 
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class MultiplesOf3And5
    {
        public int Sum(int exclusiveUpper)
        {
            return Enumerable.Range(0, exclusiveUpper)
                             .Where(x => x%3 == 0 || x%5 == 0)
                             .Sum();
        }
    }
}