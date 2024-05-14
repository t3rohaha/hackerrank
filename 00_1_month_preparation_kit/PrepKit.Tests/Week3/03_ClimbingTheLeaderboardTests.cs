namespace Week3.Tests;

public class ClimbingTheLeaderboardTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void ShouldPass(List<int> table, List<int> scores, List<int> expected)
    {
        var result = ClimbingTheLeaderboard.Solution(table, scores);

        Assert.True(expected.SequenceEqual(result));
    }

    public static IEnumerable<object[]> TestData()
    {
        var t1 = new List<int>() { 40, 30, 20, 10 };
        var s1 = new List<int>() { 10, 20, 30, 40 };
        var expected1 = new List<int>() { 4, 3, 2, 1 };
        yield return new object[] { t1, s1, expected1 };

        var t2 = new List<int>() { 40, 30, 20, 10 };
        var s2 = new List<int>() { 5, 15, 25, 35, 45, 55 };
        var expected2 = new List<int>() { 5, 4, 3, 2, 1, 1 };
        yield return new object[] { t2, s2, expected2 };

        var t3 = new List<int>() { 100, 90, 90, 80 };
        var s3 = new List<int>() { 70, 80, 105 };
        var expected3 = new List<int>() { 4, 3, 1 };
        yield return new object[] { t3, s3, expected3 };

        var t4 = new List<int>() { 100, 100, 50, 40, 40, 20, 10 };
        var s4 = new List<int>() { 5, 25, 50, 120 };
        var expected4 = new List<int>() { 6, 4, 2, 1 };
        yield return new object[] { t4, s4, expected4 };

        var t5 = new List<int>() { 100, 90, 90, 80, 75, 60 };
        var s5 = new List<int>() { 50, 65, 77, 90, 102 };
        var expected5 = new List<int>() { 6, 5, 4, 2, 1 };
        yield return new object[] { t5, s5, expected5 };
    }
}