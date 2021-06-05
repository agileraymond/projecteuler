using System;
using Xunit;

namespace Project5
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var five = new Five();
            var result = five.Solve(1, 10);
            Assert.Equal(result, 2520);
        }

        [Fact]
        public void Test2()
        {
            var five = new Five();
            var result = five.Solve(1, 20);
            Assert.Equal(result, 232792560);
        }
        /*
        2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        */
    }

    public class Five
    {
        public int Solve(int min, int max)
        {
            var isDivisible = false;
            var number = 0;
            var counter = max;

            while (number == 0) 
            {
                isDivisible = true;

                for (int x = min; x < max + 1; x++)
                {
                    if (counter % x != 0)
                    {
                        isDivisible = false; 
                        break;
                    }   
                }

                if (isDivisible) {
                    number = counter;
                }

                counter++;
            }

            return number;
        }    
    }
}
