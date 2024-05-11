namespace Week1.Tests;

public class FlippingTheMatrixTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void FindMax_ShouldReturnHighestMirrorNumber(int row, int col, List<List<int>> matrix, int expected)
    {
        var result = FlippingTheMatrix.FindMax(row, col, matrix);
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> Data()
    {
        List<List<int>> m1 = [[1, 2], [3, 4]];
        yield return new object[] {0, 0, m1, 4};

        List<List<int>> m2 = [[112, 42, 83, 119],
                              [56, 125, 56, 49],
                              [15, 78, 101, 43],
                              [62, 98, 114, 108]];
        yield return new object[] {0, 0, m2, 119};
        yield return new object[] {0, 1, m2, 114};
        yield return new object[] {1, 0, m2, 56};
        yield return new object[] {1, 1, m2, 125};
    }
}