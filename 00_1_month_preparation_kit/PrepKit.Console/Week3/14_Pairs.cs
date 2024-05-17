namespace Week3;

public class Pairs
{
    public static void Main()
    {
        Console.WriteLine(Solution2(2, [1, 5, 3, 4, 2]));
    }

    // Time limit exceeded (5 tests).
    public static int Solution(int k, List<int> arr)
    {
        var count = 0;

        for (var i = 0; i < arr.Count; i++)
            for (var y = i; y < arr.Count; y++)
                if (Math.Abs(arr[i] - arr[y]) == k)
                    count++;

        return count;
    }

    // Success.
    public static int Solution2(int k, List<int> arr)
    {
        var og = arr
        .OrderBy(x => x)
        .GroupBy(x => x)
        .Select(x => new { number = x.Key, count = x.Count() })
        .ToList();

        var count = 0;
        for (var i = 0; i < arr.Count; i++)
        {
            for (var y = i; y < arr.Count; y++)
            {
                var diff = Math.Abs(og[i].number - og[y].number);

                if (diff > k) break;

                if (diff == k)
                {
                    count += og[i].count * og[y].count;
                    break;
                }
            }
        }

        return count;
    }
}