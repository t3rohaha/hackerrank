namespace Warmup;

public class DiagonalDiff
{
    public static void Main()
    {
        Console.WriteLine(Solution([[1, 2, 3], [4, 5, 6], [9, 8, 9]]));
    }

    public static int Solution(List<List<int>> arr)
    {
        var c = arr.Count;
        var d1 = 0;
        var d2 = 0;

        for (var i = 0; i < c; i++)
        {
            for (var y = 0; y < c; y++)
            {
                if (i == y) d1 += arr[i][y];
                if (i + y == c-1) d2 += arr[i][y];
            }
        }

        return Math.Abs(d1 - d2);
    }
}