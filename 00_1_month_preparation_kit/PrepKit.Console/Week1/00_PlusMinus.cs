namespace Week1;

public class PlusMinus
{
    public static void Main()
    {
        Solution([-4, 3, -9, 0, 4, 1]);
    }

    static void Solution(List<int> arr)
    {
        decimal positive = 0, negative = 0, zero = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] < 0) negative++;
            else if (arr[i] > 0) positive++;
            else zero++;
        }

        Console.WriteLine($"{positive / arr.Count:F6}");
        Console.WriteLine($"{negative / arr.Count:F6}");
        Console.WriteLine($"{zero / arr.Count:F6}");
    }
}