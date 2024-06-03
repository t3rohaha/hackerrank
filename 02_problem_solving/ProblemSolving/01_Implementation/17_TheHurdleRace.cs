namespace Implementation;

public class TheHurdleRace
{
    public static void Main()
    {
        Console.WriteLine(Solution(4, [1, 6, 3, 5, 2]));
        Console.WriteLine(Solution(7, [2, 5, 4, 5, 2]));
    }

    public static int Solution(int k, List<int> height)
    {
        var max = 0;
        foreach (var h in height)
            if (h > max)
                max = h;

        return max > k ? max - k : 0;
    }
}