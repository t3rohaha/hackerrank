namespace Strings;

public class CamelCase
{
    public static void Main()
    {
        Console.WriteLine(Solution("one"));
        Console.WriteLine(Solution("oneTwoThree"));
    }

    public static int Solution(string s)
    {
        var count = 1;

        foreach (var c in s)
            if (char.IsUpper(c))
                count++;

        return count;
    }
}