namespace Strings;

public class MarsExploration
{
    public static void Main()
    {
        Console.WriteLine(Solution("SOSSPSSQSSOR"));
        Console.WriteLine(Solution("SOSSOT"));
    }

    public static int Solution(string s)
    {
        var counter = 0;
        for (var i = 0; i < s.Length; i+=3)
        {
            if (s[i] != 'S') counter++;
            if (s[i+1] != 'O') counter++;
            if (s[i+2] != 'S') counter++;
        }
        return counter;
    }
}