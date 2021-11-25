using System;
using Xunit;
using System.Threading;

namespace MyFirstUnitTests_proj2
{
    public class UnitTest2_proj2
    {
        [Fact]
        public void PassingTest_proj2()
        {
            System.Threading.Thread.Sleep(2500);
            Assert.Equal(4, Add(2, 2));
            
        }

        [Fact]
        public void FailingTest_proj2()
        {
            System.Threading.Thread.Sleep(4000);
            Assert.Equal(5, Add(2, 2));
            
        }

        int Add(int x, int y)
        {
            System.Threading.Thread.Sleep(2400);
            return x + y;
        }
        
         [Fact]
        
        public void FailingTest2_proj2()
        {
            System.Threading.Thread.Sleep(4000);
            Assert.Equal(5, Add(2, 2));
            
        }

         [Fact]
         public void FailingTest3_proj2()
        {
            System.Threading.Thread.Sleep(5000);
            Assert.Equal(5, Add(2, 2));
            
        }

        [Fact]
        public void FailingTest4_proj2()
        {
            System.Threading.Thread.Sleep(1000);
            Assert.Equal(5, Add(2, 2));
            
        }


    }

}
