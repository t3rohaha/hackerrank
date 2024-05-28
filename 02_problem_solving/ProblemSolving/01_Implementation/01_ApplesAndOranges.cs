namespace Implementation;

public class ApplesAndOranges
{
    public static void Main()
    {
        Solution(7, 10, 4, 12, [2, 3, -4], [3, -2, -4]);
    }

    public static void Solution(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        var aCount = 0;
        foreach (var n in apples)
            if (a+n >= s && a+n <= t)
                aCount++;

        var bCount = 0;
        foreach (var n in oranges)
            if (b+n >= s && b+n <= t)
                bCount++;

        Console.WriteLine(aCount);
        Console.WriteLine(bCount);
    }
}