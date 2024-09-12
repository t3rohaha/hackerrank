namespace Week4;

public class TheMaximumSubarray
{
    public static void Main()
    {
        Console.WriteLine(string.Join(" ", Solution([-1, 2, 3, -4, 5, 10])));
        Console.WriteLine(string.Join(" ", Solution([1, 2, 3, 4])));
        Console.WriteLine(string.Join(" ", Solution([2, -1, 2, 3, 4, -5])));
    }

    public static List<int> Solution(List<int> arr)
    {
        var maxSubarraySum = FindSubarrayMaxSum(arr);
        var maxSubsequenceSum = FindSubsequenceMaxSum(arr);
        return [maxSubarraySum, maxSubsequenceSum];
    }

    public static int FindSubarrayMaxSum(List<int> arr)
    {
        var maxSum = 0;
        var max = int.MinValue;

        for (var i = 0; i < arr.Count; i++)
        {
            var current = arr[i];

            if (max < current) max = current;

            if (current > 0)
            {
                var tempSum = current;
                for (var y = i+1; y < arr.Count; y++)
                {
                    if (tempSum + arr[y] > 0)
                    {
                        tempSum += arr[y];
                        if (tempSum > maxSum)
                            maxSum = tempSum;
                    }
                    else break;
                }
            }
        }

        if (max <= 0 || max > maxSum) return max;

        return maxSum;
    }

    public static int FindSubsequenceMaxSum(List<int> arr)
    {
        var maxSum = 0;
        var max = int.MinValue;

        for (var i = 0; i < arr.Count; i++)
        {
            if (max < arr[i]) max = arr[i];

            if (arr[i] > 0) maxSum += arr[i];
        }

        if (max <= 0) return max;

        return maxSum;
    }
}