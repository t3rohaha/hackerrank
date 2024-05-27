namespace Warmup;

public class PlusMinus
{
    public static void Main()
    {
        Solution([1, 1, 0, -1, -1]);
    }

    public static void Solution(List<int> arr)
    {
        decimal pos = 0, neg = 0, zero = 0;

        foreach (var n in arr)
        {
            if (n > 0) pos++;
            else if (n < 0) neg++;
            else zero++;
        }

        var all = arr.Count;

        Console.WriteLine($"{pos/all:F6}");
        Console.WriteLine($"{neg/all:F6}");
        Console.WriteLine($"{zero/all:F6}");
    }
}