using System;
using System.Collections.Generic;
using Xunit;

namespace _1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var problem1 = new Problem1();
            var sum = problem1.Sum(10);
            Assert.Equal(sum, 23);    
        }

        [Fact]
        public void Test2()
        {
            var problem1 = new Problem1();
            var sum = problem1.Sum(1000);
            Assert.Equal(sum, 233168);    
        }
    }

    public class Problem1
    {
        public int Sum(int number) 
        {
            var sum = 0;

            for (int i = 0; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;        
            }
            return sum;    
        }        
    }
}
