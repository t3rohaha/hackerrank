namespace Sorting;

public class RunningTime
{
    public static void Main()
    {
        Console.WriteLine(Solution([2, 1, 3, 1, 2]));
    }

    public static int Solution(List<int> arr)
    {
        var n = arr.Count;
        var count = 0;

        for (var i = 1; i < n; i++)
        {
            var key = arr[i];
            var y = i-1;

            while (y >= 0 && arr[y] > key)
            {
                arr[y+1] = arr[y];
                y--;
                count++;
            }
            arr[y+1] = key;
        }

        return count;
    }
}