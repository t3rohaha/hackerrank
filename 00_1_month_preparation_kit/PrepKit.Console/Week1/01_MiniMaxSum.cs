namespace MiniMaxSum;

public class Program
{
    public static void Main()
    {
        MiniMax([1, 3, 5, 7, 9]);
    }

    static void MiniMax(List<int> arr)
    {
        int min = int.MaxValue;
        int max = int.MinValue;
        decimal sum = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            int n = arr[i];
            sum += n;
            if (min > n) min = n;
            if (max < n) max = n;
        }

        Console.WriteLine($"{sum - max} {sum - min}");
    }
}