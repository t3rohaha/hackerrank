namespace Week3;

public class SherlockAndTheValidString
{
    public static void Main()
    {
        Console.WriteLine(Solution("a"));
        Console.WriteLine(Solution("ab"));
        Console.WriteLine(Solution("abc"));
        Console.WriteLine(Solution("abcc"));
        Console.WriteLine(Solution("abccc"));
        Console.WriteLine(Solution("aabbcd"));
    }

    // TODO: Simplify
    public static string Solution(string s)
    {
        // Elements always appear the same number of times.
        if (s.Length == 1 || s.Length == 2) return "YES";

        var dict = s.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

        var a = dict.First();
        var b = dict.FirstOrDefault(x => x.Value == a.Value);

        // The char in 'a' do not appear the same number of times as others.
        if (b.Value == 0) 
        {
            if (!CanHandleInvalidChar(dict, b.Value, a.Key, a.Value))
            {
                return "NO";
            }
        }
        // The chars in 'a' and 'b' appear the same number of times.
        else
        {
            var c = dict.FirstOrDefault(x => x.Value != b.Value);

            // All elements appear the same number of times.
            if (c.Value == 0)
            {
                return "YES";
            }

            if (!CanHandleInvalidChar(dict, b.Value, c.Key, c.Value))
            {
                return "NO";
            }
        }

        return "NO";
    }

    public static bool CanHandleInvalidChar(Dictionary<char, int> dict, int validCount, char invalidChar, int invalidCount)
    {
        if (invalidCount-1 == 0)
        {
            dict.Remove(invalidChar);

            if (dict.Any(x => x.Value != validCount))
            {
                return false;
            }
        }
        else
        {
            if (dict.Any(x => x.Key != invalidChar && x.Value != invalidCount-1))
            {
                return false;
            }
        }

        return true;
    }
}