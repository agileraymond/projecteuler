using System;
using System.Collections.Generic;
using Xunit;

namespace Project4
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            
            var project = new Project4();
            var result = project.FindPalindromeNumber(10, 99);
            Assert.Equal(result, 9009);
        }

        [Fact]
        public void Test2()
        {
            var project = new Project4();
            var result = project.FindPalindromeNumber(100, 999);
            Assert.Equal(result, 906609);
        }

        /*
A palindromic number reads the same both ways. The largest palindrome made from 
the product of two 2-digit numbers is 9009 = 91 × 99.
Find the largest palindrome made from the product of two 3-digit numbers.
        */
    }

    public class Project4 
    {
        public int FindPalindromeNumber(int low, int max)
        {
            var product = 0;
            var largest = 0;

            for (int x = low; x <= max; x++)
            {
                for (int i = max; i > low; i--)
                {
                    product = i * x;
                    Console.WriteLine($" {x} * {i} = {product}");
                    
                    if (IsPalindrome(product))
                    {  
                        if (product > largest) 
                            largest = product;
                    }    
                }
            }

            return largest;
        }    

        private bool IsPalindrome(int number)
        {
            int remainder, sum=0, temp;
            temp=number;    

            while (number > 0)
            {    
                remainder = number % 10;  //getting remainder  
                sum = (sum * 10) + remainder;    
                number = number / 10;    
            }

            if (temp == sum)    
                return true;

            return false;
        }    
    }
}
