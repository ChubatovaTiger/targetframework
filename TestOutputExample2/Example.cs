using System;
using Xunit;
using System.Threading;
using System.Collections.Generic;

            
namespace MyFirstUnitTests_proj1
{
            

public class CalculatorTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { 1, 2, 3 };
        yield return new object[] { -4, -6, -10 };
        yield return new object[] { -2, 2, 0 };
        yield return new object[] { int.MinValue, -1, int.MaxValue };
    }

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
              
              
 [Theory]
[ClassData(typeof(CalculatorTestData))]
public void CanAddTheoryClassData(int value1, int value2, int expected)
{
    var calculator = new Calculator();

    var result = calculator.Add(value1, value2);

    Assert.Equal(expected, result);
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
