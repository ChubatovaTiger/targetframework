using System;
using Xunit;
using System.Threading;

namespace MyFirstUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest01()
        {
            System.Threading.Thread.Sleep(25000);
            Assert.Equal(4, Add(2, 2));
            
        }

        [Fact]
        public void FailingTest01()
        {
            System.Threading.Thread.Sleep(40000);
            Assert.Equal(5, Add(2, 2));
            
        }

        int Add(int x, int y)
        {
            System.Threading.Thread.Sleep(24000);
            return x + y;
        }
        
         [Fact]
        
        public void FailingTest201()
        {
            System.Threading.Thread.Sleep(40000);
            Assert.Equal(5, Add(2, 2));
            
        }

         [Fact]
         public void FailingTest302()
        {
            System.Threading.Thread.Sleep(50000);
            Assert.Equal(5, Add(2, 2));
            
        }

        [Fact]
        public void FailingTest403()
        {
            System.Threading.Thread.Sleep(10000);
            Assert.Equal(5, Add(2, 2));
            
        }


    }

}
