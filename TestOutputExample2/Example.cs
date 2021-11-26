using System;
using Xunit;
using System.Threading;

namespace MyFirstUnitTests_proj1
{
    public class UnitTest_proj1
    {
        [Fact]
        public void PassingTest_proj1()
        {
            System.Threading.Thread.Sleep(10000);
            Assert.Equal(4, Add(2, 2));
            
        }

        [Fact]
        public void FailingTest_proj1()
        {
            System.Threading.Thread.Sleep(10000);
            Assert.Equal(5, Add(2, 2));
            
        }

        int Add(int x, int y)
        {
            System.Threading.Thread.Sleep(10000);
            return x + y;
        }
        
         [Fact]
        
        public void FailingTest2_proj1()
        {
            System.Threading.Thread.Sleep(10000);
            Assert.Equal(5, Add(2, 2));
            
        }

         [Fact]
         public void FailingTest3_proj1()
        {
            System.Threading.Thread.Sleep(10000);
            Assert.Equal(5, Add(2, 2));
            
        }

        [Fact]
        public void FailingTest4_proj1()
        {
            System.Threading.Thread.Sleep(10000);
            Assert.Equal(5, Add(2, 2));
            
        }


    }

}
