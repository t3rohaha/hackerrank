namespace Greedy;

public class LuckBalance
{
    public static void Main()
    {
        Console.WriteLine(Solution2(3, [[5, 1], [2, 1], [1, 1], [8, 1], [10, 0], [5, 0]]));
    }

    public static int Solution1(int k, List<List<int>> contests)
    {
        var luck = new List<int>();
        var importantLuck = new List<int>();

        foreach (var c in contests)
        {
            var l = c[0];
            var isImportant = c[1];
            if (isImportant == 1)
                importantLuck.Add(l);
            else luck.Add(l);
        }

        var maxLuck = 0;

        foreach (var l in luck)
            maxLuck += l;

        importantLuck = importantLuck.OrderByDescending(x => x).ToList();

        foreach (var l in importantLuck)
        {
            if (k > 0) maxLuck += l;
            else maxLuck -= l;
            k--;
        }

        return maxLuck;
    }

    public static int Solution2(int k, List<List<int>> contests)
    {
        var contestsCopy = contests.OrderByDescending(x => x[1])
                          .ThenByDescending(x => x[0])
                          .ToList();

        var maxLuck = 0;
        foreach (var c in contestsCopy)
        {
            if (c[1] == 1 && k <= 0)
                maxLuck -= c[0];
            else
            {
                maxLuck += c[0];
                k--;
            }
        }

        return maxLuck;
    }
}