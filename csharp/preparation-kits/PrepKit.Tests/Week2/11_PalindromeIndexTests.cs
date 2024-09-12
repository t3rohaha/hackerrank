namespace Week2.Tests;

public class PalindromeIndexTests
{
    [Theory]
    [InlineData("a")]
    [InlineData("aa")]
    [InlineData("aba")]
    public void Solution_ShouldReturnNegativeOne_IfAlreadyPalindrome(string s)
    {
        var result = PalindromeIndex.Solution(s);
        Assert.Equal(-1, result);
    }

    [Theory]
    [InlineData("xradar", 0)]
    [InlineData("rxadar", 1)]
    [InlineData("raxdar", 2)]
    [InlineData("radxar", 2)]
    [InlineData("radaxr", 4)]
    [InlineData("radarx", 5)]
    public void Solution_ShouldReturnIndex_WhenInputIsPalWithoutIndex(string s, int expected)
    {
        var result = PalindromeIndex.Solution(s);
        Assert.Equal(expected, result);
    }
}