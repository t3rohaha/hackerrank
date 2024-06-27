namespace Search;

public class SherlockAndArray
{
    public static void Main()
    {
        Console.WriteLine(Solution([5, 6, 8, 11]));
        Console.WriteLine(Solution([1, 2, 3]));
        Console.WriteLine(Solution([1, 2, 3, 3]));
        Console.WriteLine(Solution([1, 1, 4, 1, 1]));
        Console.WriteLine(Solution([2, 0, 0, 0]));
        Console.WriteLine(Solution([0, 0, 2, 0]));
    }

    public static string Solution(List<int> arr)
    {
        var lSum = 0;
        var rSum = arr.Sum();

        for (var i = 0; i < arr.Count; i++)
        {
            if (lSum == rSum - arr[i])
                return "YES";

            lSum += arr[i];
            rSum -= arr[i];
        }

        return "NO";
    }
}