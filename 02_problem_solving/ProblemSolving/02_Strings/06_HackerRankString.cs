namespace Strings;

public class HackerRankString
{
    public static void Main()
    {
        Console.WriteLine(Solution("hereiamstackerrank"));
        Console.WriteLine(Solution("hackerworld"));
    }

    public static string Solution(string s)
    {
        var q = new Queue<char>("hackerrank");

        foreach (var c in s)
        {
            if (c == q.Peek())
                q.Dequeue();

            if (!q.Any()) return "YES";
        }

        return "NO";
    }
}