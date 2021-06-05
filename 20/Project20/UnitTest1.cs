using System;
using System.Numerics;
using Xunit;

namespace Project20
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            
            var p = new Project20();
            var result = p.Solve(10);
            Assert.Equal(result, 27);
            
        }

        [Fact]
        public void Test2()
        {
            var p = new Project20();
            var result = p.Solve(100);
            Assert.Equal(result, 648);
        }
    }
    /*
n! means n × (n − 1) × ... × 3 × 2 × 1
For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
Find the sum of the digits in the number 100!
    */
    public class Project20
    {
        public BigInteger Solve(long factorial)
        {
            long sum = 0;
            BigInteger calc = 1;
            
            for(long i = 1; i < factorial; i++)
            {
                if (i == 1) 
                {
                    calc = factorial * (factorial - i);
                }
                else 
                {
                    calc = calc * (factorial - i);
                }           
            }

            var digitsArray = calc.ToString().ToCharArray();
            foreach (var digit in digitsArray)
            {
                sum += int.Parse(digit.ToString());
            }

            return sum;
        }
    }
}
