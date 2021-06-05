using Xunit;
using System.Collections.Generic;

namespace Problem2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var p2 =  new Problem2();
            var itemList = new List<int>();
            var result = p2.Sum(1, 2, 10, 0, itemList);
            Assert.Equal(result, 10);
        }

        [Fact]
        public void Test2()
        {
            var p2 =  new Problem2();
            var itemList = new List<int>();
            var result = p2.Sum(1, 2, 4000000, 0, itemList);
            Assert.Equal(result, 4613732);
        }
    }

    public class Problem2 
    {
        public int Sum(int n1, int n2, int maxNumber, int total, List<int> itemTotals)
        {
            var temp = n2;
            var sum = n1 + n2;
            
            if (temp <= maxNumber)
            {
                if (!itemTotals.Contains(n1)) 
                {
                    if (n1 % 2 == 0) 
                    {
                        total += n1;
                        itemTotals.Add(n1);     
                    }
                }

                if (!itemTotals.Contains(n2)) 
                {
                    if (n2 % 2 == 0)
                    {
                        total += n2;
                        itemTotals.Add(n2);
                    }
                }

                n1 = temp;
                n2 = sum;
                return Sum(n1, n2, maxNumber, total, itemTotals);
            }

            return total;        
        }
    }
}
