namespace Implementation;

public class SalesByMatch
{
    public static void Main()
    {
        Console.WriteLine(Solution(7, [10, 20, 20, 10, 10, 30, 50, 10, 20]));
    }

    public static int Solution(int n, List<int> ar)
    {
        var socks = new Dictionary<int, int>();
        var pairs = 0;
        foreach (var a in ar)
        {
            if (!socks.ContainsKey(a))
            {
                socks[a] = 0;
            }

            socks[a]++;

            if (socks[a] == 2)
            {
                pairs++;
                socks[a] = 0;
            }
        }

        return pairs;
    }

    public static int Solution2(int n, List<int> ar)
    {
        var socks = new Dictionary<int, int>();
        foreach (var a in new HashSet<int>(ar))
            socks[a] = 0;

        var pairs = 0;
        foreach (var a in ar)
        {
            socks[a]++;

            if (socks[a] == 2)
            {
                pairs++;
                socks[a] = 0;
            }
        }

        return pairs;
    }
}