namespace Implementation;

public class ClimbingTheLeaderboard
{
    public static void Main()
    {
        var r1 = Solution([100, 90, 90, 80], [70, 80, 105]);
        Console.WriteLine(string.Join(" ", r1));

        var r2 = Solution([100, 100, 50, 40, 40, 20, 10], [5, 25, 50, 120]);
        Console.WriteLine(string.Join(" ", r2));
    }

    public static List<int> Solution(List<int> ranked, List<int> player)
    {
        var l = new Stack<int>(new HashSet<int>(ranked));
        var s = new Queue<int>(player);

        var results = new List<int>(ranked.Count);
        var p = l.Count + 1;
        while (l.Any() && s.Any())
        {
            if (l.Peek() > s.Peek())
            {
                results.Add(p);
                s.Dequeue();
            }
            else
            {
                p--;
                l.Pop();
            }
        }

        for (var i = 0; i < s.Count; i++)
            results.Add(1);

        return results;
    }
}