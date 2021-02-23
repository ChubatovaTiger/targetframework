using System;
using Xunit;

public class MyTestClass
{
    [Fact]
    public void MyTestMethod() 
    {
        Assert.Equal(5, 4);
        Colsole.WriteLine("a from console");
    }
}


