using System;
using System.Numerics;
using Xunit;

namespace Project7
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var prob7 = new Project7();
            var result = prob7.FindPrimeNumber(105000);
            Assert.Equal(result, 104743);
        }
        /*
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
What is the 10 001st prime number?
        */

        class Project7
        {
            public int FindPrimeNumber(long n)
            {
                bool[] prime = new bool[n+1]; 
          
                for (int i = 0; i < n; i++) 
                    prime[i] = true; 
                
                for(int p = 2; p*p <= n; p++) 
                { 
                    // If prime[p] is not changed, 
                    // then it is a prime 
                    if (prime[p] == true) 
                    { 
                        // Update all multiples of p 
                        // i = 2 x 2 = 4
                        // 4 <= 100 
                        // 4 += 2
                        for (int i = p*p; i <= n; i += p) 
                            prime[i] = false; 
                    } 
                } 
                
                // Print all prime numbers
                var count = 0; 
                for(int i = 2; i <= n; i++) 
                { 
                    if (prime[i] == true) 
                    {
                        count++;
                        if (count == 10001)
                        {
                            Console.Write(i + " ");
                            return i;
                            //break;
                        }
                    } 
                }

                return count; 
            }   
        }
    }
}
