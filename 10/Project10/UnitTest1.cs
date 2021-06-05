using System.Collections.Generic;
using Xunit;
using System;
using System.Numerics;

namespace Project10
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var p = new Project10();

            Assert.Equal(p.Solve(10), 17);
        }

        [Fact]
        public void Test2()
        {
            var p = new Project10();

            Assert.Equal(p.Solve(100), 25);
        }

        [Fact]
        public void Test3()
        {
            var p = new Project10();

            Assert.Equal(p.Solve(2000000), 25);
        }

        [Fact]
        public void Test4()
        {
            var p = new Project10();

            Assert.Equal(p.First100Primes(), null);
        }
    }

// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
// Find the sum of all the primes below two million.

    public class Project10 
    {
        public BigInteger Solve(BigInteger maxNumber)
        {
            var sum = 0;

            for (int i = 2; i < maxNumber; i++)
            {
                if (IsPrime(i))
                    sum += i;
            }

            return sum;
        }

        public bool IsPrime(BigInteger number)
        {
            //var isPrime = false;

            if (number == 2 || number == 3 || number == 5 || number == 7)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }

            var sq = (int)Math.Sqrt(Convert.ToDouble(number)) + 1;
            for (int i = 11; i < sq; i++)
            {
                if (sq % 2 == 0 || sq % 3 == 0 || sq % 5 == 0 || sq % 7 == 0) 
                {
                    break;
                }
            }

            return true;
        }

        public List<int> First100Primes()
        {
            var results = new List<int>();

            for (int i = 2; i < 100; i++) 
            {
                if (i == 2 || i == 3 || i == 5 || i == 7)
                {
                    results.Add(i);
                    continue;    
                }

                if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0) 
                {
                    continue;
                }

                var sq = (int)(Math.Sqrt(i) + 1);
                var foundPrime = true;
                for (int x = 10; x < sq; x++)
                {
                    if (sq % x == 0) 
                    {
                        foundPrime = false;
                        continue;
                    }
                }
                if (foundPrime)
                {
                    results.Add(i);
                }
            }

            return results;
        }
    }
}
/*
2	3	5	7	11	13	17	19	23
29	31	37	41	43	47	53	59	61	67
71	73	79	83	89	97
*/