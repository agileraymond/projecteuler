using System;
using Xunit;

namespace Project9
{
    public class UnitTest1
    {
/*
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which
a2 + b2 = c2
For example, 3>2 + 4>2 = 9 + 16 = 25 = 5>2.
There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
*/
        [Fact]
        public void Test1()
        {
            var t = new Triplet();
            Assert.Equal(31875000, t.FindProduct(1000));
        }
    }
    public class Triplet
    {
        public double FindProduct(int sum)
        {
            // find 3 numbers that will add to sum

            var total = 0d;
            double a, b, c = 0;
            var result = 0d;

            for (int i = 2; i < sum; i++)
            {
                a = i;
                Console.WriteLine($"a is {a}");
                
                for (int x = 1; x < sum; x++)
                {
                    b = x;
                    Console.WriteLine($"b is {b}");
                    
                    if (b > a)
                    {
                        result = Math.Pow(a, 2) + Math.Pow(b, 2);
                        c = Math.Sqrt(result);
                        Console.WriteLine($"c is {c}");
                
                        if (c > b && a + b + c == sum)
                        {
                            total = a * b * c;
                            Console.WriteLine($"found asnwer a {a} b {b} c {c}");
                            return total;
                        }
                    }
                }
            }

            return total;
        }
    }
}
