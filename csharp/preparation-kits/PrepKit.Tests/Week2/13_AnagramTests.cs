namespace Week2.Tests;

public class AnagramTests
{
    [Fact]
    public void Solution_ShouldReturnMinusOne_WhenInputLengthIsOdd()
    {
        var result = Anagram.Solution("a");
        Assert.Equal(-1, result);
    }

    [Fact]
    public void Solution_ShouldReturnZero_WhenInputAlreadyAnagram()
    {
        var result = Anagram.Solution("xyyx");
        Assert.Equal(0, result);
    }

    [Fact]
    public void Solution_ShouldReturnOne_WhenInputEqualTwoDifferentElements()
    {
        var result = Anagram.Solution("ab");
        Assert.Equal(1, result);
    }

    [Theory]
    [InlineData("mnop", 2)]
    [InlineData("xaxbbbxx", 1)]
    [InlineData("fdhlvosfpafhalll", 5)]
    public void Solution_ShouldReturnHalfOfRemainingItemsCount(string s, int expected)
    {
        var result = Anagram.Solution(s);
        Assert.Equal(expected, result);
    }
}