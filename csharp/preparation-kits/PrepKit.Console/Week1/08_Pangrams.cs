namespace Week1;
using System.Diagnostics;

public class Pangrams
{
    public static void Main()
    {
        string input = "We promptly judged antique ivory buckles for the " +
                       "next prize";

        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        for (int i = 0; i < 1000000; i++) Solution1(input);
        stopwatch.Stop();
        Console.WriteLine($"Solution1 execution time: {stopwatch.Elapsed}");

        stopwatch.Restart();
        for (int i = 0; i < 1000000; i++) Solution2(input);
        stopwatch.Stop();
        Console.WriteLine($"Solution2 execution time: {stopwatch.Elapsed}");
    }

    static string Solution1(string s)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string normalized = s.ToLower();

        foreach (char c in alphabet)
            if (!normalized.Contains(c))
                return "not pangram";

        return "pangram";
    }

    static string Solution2(string s)
    {
        var normalized = s.ToLower().Where(char.IsLetter);

        var counter = new int[26];
        foreach(byte c in normalized)
            counter[c-97]++;

        if (counter.Any(x => x == 0))
            return "not pangram";

        return "pangram";
    }
}