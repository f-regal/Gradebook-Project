using Xunit;

namespace GradeBook.tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //arrange
        var x = 5;
        var y = 2;
        var expected = 8;

        //act
        var actual = x + y;

        //assert
        Assert.Equal(actual, expected);
        

    }
}