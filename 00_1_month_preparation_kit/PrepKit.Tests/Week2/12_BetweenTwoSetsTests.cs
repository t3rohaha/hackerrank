namespace Week2.Tests;

public class BetweenTwoSetsTests
{
    [Theory]
    [MemberData(nameof(IsFactorOfList_ShouldReturnTrue_Params))]
    public void IsFactorOfList_ShouldReturnTrue(int n, List<int> list)
    {
        var result = BetweenTwoSets.IsFactorOfList(n, list);
        Assert.True(result);
    }

    [Theory]
    [MemberData(nameof(IsFactorOfList_ShouldReturnFalse_Params))]
    public void IsFactorOfList_ShouldReturnFalse(int n, List<int> list)
    {
        var result = BetweenTwoSets.IsFactorOfList(n, list);
        Assert.False(result);
    }

    public static IEnumerable<object[]> IsFactorOfList_ShouldReturnTrue_Params()
    {
        yield return new object[] { 1, new List<int>([1, 2, 3]) };
    }

    public static IEnumerable<object[]> IsFactorOfList_ShouldReturnFalse_Params()
    {
        yield return new object[] { 2, new List<int>([1, 2, 3]) };
    }
}