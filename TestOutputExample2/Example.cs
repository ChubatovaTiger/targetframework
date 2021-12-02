using System;
using Xunit;
using System.Threading;
using System.Collections.Generic;

            
namespace MyFirstUnitTests_proj1
{
            
            
  public class TestDataGenerator : IEnumerable<object[]>
{
    private readonly List<object[]> _data = new List<object[]>
    {
        new object[] {5, 1, 3, 9},
        new object[] {7, 1, 5, 3}
    };

    public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}



    
  public class ParameterizedTests
{
   public bool IsOddNumber(int number)
   {
       return number % 2 != 0;
   }

  [Theory]
  [InlineData(5, 1, 3, "a: 5, b: 8)")]
  [InlineData(7, 1, 5, "b")]
  public void AllNumbers_AreOdd_WithInlineData(int a, int b, int c, string d)
  {
      Assert.True(IsOddNumber(a));
      Assert.True(IsOddNumber(b));
      Assert.True(IsOddNumber(c));
      Assert.True(false, d);
  }
}
    
    
    public class ParameterizedTests_Classdata
{
    public bool IsOddNumber2(int number)
    {
        return number % 2 != 0;
    }

    [Theory]
    [ClassData(typeof(TestDataGenerator))]
    public void AllNumbers_AreOdd_WithClassData(int a, int b, int c, int d)
    {
        Assert.True(IsOddNumber2(a));
        Assert.True(IsOddNumber2(b));
        Assert.True(IsOddNumber2(c));
        Assert.True(IsOddNumber2(d));
    }
}
    
    
    
    
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
            System.Threading.Thread.Sleep(100);
            return x + y;
        }
        
         [Fact]
        
        public void FailingTest2_proj1()
        {
            System.Threading.Thread.Sleep(100);
            Assert.Equal(5, Add(2, 2));
            
        }

         [Fact]
         public void FailingTest3_proj1()
        {
            System.Threading.Thread.Sleep(100);
            Assert.Equal(5, Add(2, 2));
            
        }

        [Fact]
        public void FailingTest4_proj1()
        {
            System.Threading.Thread.Sleep(100);
            Assert.Equal(5, Add(2, 2));
            
        }


    }

}
