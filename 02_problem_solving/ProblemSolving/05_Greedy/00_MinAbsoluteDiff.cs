namespace Greedy;

public class MinAbsoluteDiff
{
    public static void Main()
    {
        var r1 = Solution([3, -7, 0]);
        Console.WriteLine(r1);
        var r2 = Solution([-59, -36, -13, 1, -53, -92, -2, -96, -54, 75]);
        Console.WriteLine(r2);
        var r3 = Solution([1, -3, 71, 68, 17]);
        Console.WriteLine(r3);
    }

    public static int Solution(List<int> arr)
    {
        var ordered = arr.OrderBy(x => x).ToList();
        var minDiff = int.MaxValue;

        for (var i = 0; i < ordered.Count - 1; i++)
        {
            var diff = Math.Abs(ordered[i] - ordered[i+1]);
            if (diff < minDiff) minDiff = diff;
        }

        return minDiff;
    }
}