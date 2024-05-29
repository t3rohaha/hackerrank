namespace Implementation;

public class SubarrayDivision
{
    public static void Main()
    {
        Console.WriteLine(Solution([2, 2, 1, 3, 2], 4, 2));
        Console.WriteLine(Solution([1, 2, 1, 3, 2], 3, 2));
        Console.WriteLine(Solution([1, 1, 1, 1, 1, 1], 3, 2));
    }

    public static int Solution(List<int> s, int d, int m)
    {
        var count = 0;

        for (var i = 0; i <= s.Count - m; i++)
        {
            var sum = 0;
            for (var y = 0; y < m; y++)
                sum += s[i+y];
            
            if (sum == d) count++;
        }

        return count;
    }
}