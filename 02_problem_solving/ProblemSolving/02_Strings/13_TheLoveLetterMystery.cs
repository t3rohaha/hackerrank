namespace Strings;

public class TheLoveLetterMystery
{
    public static void Main()
    {
        Console.WriteLine(Solution("abc"));
        Console.WriteLine(Solution("abcba"));
        Console.WriteLine(Solution("abcd"));
        Console.WriteLine(Solution("cba"));
    }

    public static int Solution(string s)
    {
        var n = s.Length;

        var arr = new char[n];
        for (var i = 0; i < n; i++)
            arr[i] = s[i];

        var count = 0;
        for (var i = 0; i < n / 2; i++)
            if (arr[i] != arr[n-1-i])
                count += Math.Abs(arr[i] - arr[n-1-i]);

        return count;
    }
}