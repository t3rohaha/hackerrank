namespace Warmup;

public class MiniMaxSum
{
    public static void Main()
    {
        Solution([1, 3, 5, 7, 9]);
    }

    public static void Solution(List<int> arr)
    {
        var min = int.MaxValue;
        var max = int.MinValue;
        long sum = 0;

        foreach (var n in arr)
        {
            sum += n;
            if (n < min) min = n;
            if (n > max) max = n;
        }

        Console.WriteLine($"{sum-max} {sum-min}");
    }
}