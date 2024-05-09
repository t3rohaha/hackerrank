namespace MaxMin;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(MaxMin(5, [4504, 1520, 5857, 4094, 4157, 3902, 822,
                                     6643, 2422, 7288, 8245, 9948, 2822, 1784,
                                     7802, 3142, 9739, 5629, 5413, 7232]));
    }

    static int MaxMin(int k, int[] arr)
    {
        var orderedArr = arr.OrderBy(_ => _).ToArray();

        var minUnfairness = int.MaxValue;
        var maxIndex = arr.Count() - k;
        for (int i = 0; i <= maxIndex; i++)
        {
            var min = orderedArr[i];
            var max = orderedArr[i+k-1];
            var unfairness = max - min;
            if (unfairness < minUnfairness)
            {
                minUnfairness = unfairness;
            }
        }

        return minUnfairness;
    }

    static void WhichPairEqualDiff(int[] arr, int diff)
    {
        for (int i = 0; i < arr.Count() - 1; i++)
        {
            for (int y = i+1; y < arr.Count(); y++)
            {
                var currentDiff = Math.Abs(arr[i] - arr[y]);
                if (currentDiff == diff)
                {
                    Console.WriteLine($"Abs: {arr[i]} - {arr[y]} = {diff}");
                    Environment.Exit(0);
                }
            }
        }

        Console.WriteLine("None");
    }
}