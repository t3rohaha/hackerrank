namespace Week3;

public class BalancedBrackets
{
    public static void Main()
    {
        Console.WriteLine(Solution("{{[[(())]]}}"));
    }

    public static string Solution(string s)
    {
        if (s.Length % 2 != 0) return "NO";

        var opening = new Stack<char>(s.Length/2);
        var p = new Dictionary<char, char> {{'(', ')'},
                                            {'[', ']'},
                                            {'{', '}'}};

        foreach (var b in s)
        {
            if (p.Keys.Contains(b))
            {
                opening.Push(b);
            }
            else
            {
                if (!opening.Any()) return "NO";
                if (p[opening.Pop()] != b) return "NO";
            }
        }

        if (opening.Any()) return "NO";

        return "YES";
    }
}