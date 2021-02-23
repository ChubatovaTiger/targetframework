using System;
using Xunit;

static class MyTestClass
{
    [Fact]
    static void MyTestMethod() 
    {
        Assert.Equal(5, 4);
        Colsole.WriteLine("a from console")
    }
}


