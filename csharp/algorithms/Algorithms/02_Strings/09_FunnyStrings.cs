namespace Strings;

public class FunnyString
{
    public static void Main()
    {
        Console.WriteLine(Solution("acxz"));
        Console.WriteLine(Solution("bcxz"));
    }

    public static string Solution(string s)
    {
        var diffs = new List<int>(s.Length - 1);
        for (var i = 0; i < s.Length-1; i++)
            diffs.Add(Math.Abs(s[i] - s[i+1]));

        for (var i = 0; i < diffs.Count; i++)
            if (diffs[i] != diffs[diffs.Count-1-i])
                return "Not Funny";

        return "Funny";
    }
}