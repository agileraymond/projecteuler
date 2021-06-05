using System;
using Xunit;

namespace Project6
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var p = new Project6();
            var result = p.Solve(1, 10);
            Assert.Equal(result, 2640);
        }

        [Fact]
        public void Test2()
        {
            var p = new Project6();
            var result = p.Solve(1, 100);
            Assert.Equal(result, 25164150);
        }
    }

    class Project6
    {
        public int Solve(int min, int max)
        {
            var sum = 0;
            var squareSum = 0;

            for (int i = min; i < max + 1; i++)
            {
                sum += i * i;
                squareSum += i;
            }

            return squareSum * squareSum - sum;

            //return sum;
        }        
    }
}
