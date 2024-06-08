namespace Implementation;

public class RepeatedString
{
    public static void Main()
    {
        Solution("a", 10);
    }

    public static long Solution(string s, long n)
    {
        long count = 0;

        foreach (var c in s)
            if (c == 'a')
                count++;

        var rem = n % s.Length;

        if (rem == 0)
        {
            count *= n / s.Length;
        }
        else
        {

            long remCount = 0;
            for (var i = 0; i < rem; i++)
                if (s[i] == 'a')
                    remCount++;

            if (n < s.Length)
            {
                count = remCount;
            }
            else
            {
                count *= n / s.Length;
                count += remCount;
            }
        }

        return count;
    }
}