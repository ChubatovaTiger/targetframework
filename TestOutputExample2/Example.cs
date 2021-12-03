using System;
using Xunit;
using System.Threading;
using System.Collections.Generic;

            
namespace MyFirstUnitTests_proj1
{
            


    
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
            
            
    
 
     public class MatrixTheoryData<T1, T2> : TheoryData<T1, T2>
    {
        public MatrixTheoryData(IEnumerable<T1> data1, IEnumerable<T2> data2)
        {
            Contract.Assert(data1 != null && data1.Any());
            Contract.Assert(data2 != null && data2.Any());

            foreach (T1 t1 in data1)
                foreach (T2 t2 in data2)
                    Add(t1, t2);
        }
    }

    public class xUnitMemberDataSampleUsage
    {
        public static int[] Numbers = { 42, 5, 6 };
        public static string[] Strings = { "Hello", "world!" };
        public static MatrixTheoryData<string, int> MatrixData = new MatrixTheoryData<string, int>(Strings, Numbers);

        [Theory]
        [MemberData(nameof(MatrixData))]
        public void xUnitMemberDataTestMethod(string x, int y)
        {
            Assert.Equal(y, x.Length);
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
