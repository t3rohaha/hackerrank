namespace Strings;

public class Pangrams
{
    public static void Main()
    {

    }

    public static string Solution(string s)
    {
        var alphabet = "abcdefghijklmnopqrstuvwxyz";
        s = s.ToLower();

        foreach (var c in alphabet)
            if (!s.Contains(c))
                return "not pangram";

        return "pangram";
    }
}