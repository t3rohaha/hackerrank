namespace Strings;

public class AternatingChars
{
    public static void Main()
    {

    }

    public static int Solution(string s)
    {
        var count = 0;

        for (var i = 0; i < s.Length - 1; i++)
            if (s[i] == s[i+1])
                count++;

        return count;
    }
}