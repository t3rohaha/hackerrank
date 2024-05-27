namespace Warmup;

public class CompareTheTriplets
{
    public static void Main()
    {
        Console.WriteLine(string.Join(", ", Solution([1, 2, 3], [3, 2, 1])));
    }

    public static List<int> Solution(List<int> a, List<int> b)
    {
        var points = new List<int>(2) {0, 0};

        for (var i = 0; i < 3; i++)
        {
            if (a[i] > b[i]) points[0]++;
            if (a[i] < b[i]) points[1]++;
        }

        return points;
    }
}