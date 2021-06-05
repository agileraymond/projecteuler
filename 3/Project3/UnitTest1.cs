using System.Collections.Generic;
using Xunit;
using System;
using System.Linq;

namespace Project3
{
    public class UnitTest1
    { 
        [Fact]
        public void Test1()
        {
            var project3 = new Project3();
            var result = project3.Solve(13195);
            Assert.Equal(29, result);
        }

        [Fact]
        public void Test2()
        {
            var project3 = new Project3();
            var result = project3.Solve(25);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Test3()
        {
            var project3 = new Project3();
            var result = project3.Solve(600851475143);
            Assert.Equal(6857, result);
        }
    }
/*
The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143 ?
*/
    public class Project3 
    {
        public List<long> Find(long number)
        {
            var primeFactors = new List<long>();
            var maxNumber = (int)Math.Sqrt(number) + 1;
            Console.WriteLine(maxNumber);
            
            for (int i = 1; i < maxNumber; i++)
            {
                if (number % i == 0)
                {
                    primeFactors.Add(i);
                    primeFactors.Add(number / i);
                }    
            }

            return primeFactors;
        }

        private bool IsPrime(long number)
        {
            return Find(number).Count == 2;
        }

        public long Solve(long number)
        {
            var items = Find(number);
            Console.WriteLine($" items count {items.Count}");
            long largestPrimeFactor = 0;

            foreach (var item in items)
            {
                if (IsPrime(item) && item > largestPrimeFactor)
                    largestPrimeFactor = item;
            }

            return largestPrimeFactor;
        }
    }     
}
