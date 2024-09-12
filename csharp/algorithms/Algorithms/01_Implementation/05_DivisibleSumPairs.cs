namespace Implementation;

public class DivisibleSumPairs
{
    public static void Main()
    {
        Console.WriteLine(Solution(6, 3, [1, 3, 2, 6, 1, 2]));
    }

    public static int Solution(int n, int k, List<int> ar)
    {
        var count = 0;

        for (var i = 0; i < n; i++)
            for (var j = i+1; j < n; j++)
                if ((ar[i] + ar[j]) % k == 0)
                    count++;

        return count;
    }
}