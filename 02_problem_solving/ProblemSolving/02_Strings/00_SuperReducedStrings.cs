namespace Strings;

public class SuperReducedStrings
{
    public static void Main()
    {
        Console.WriteLine(Solution("baab"));
        Console.WriteLine(Solution("aaabccddd"));
        Console.WriteLine(Solution("aa"));
    }

    public static string Solution(string s)
    {
        var list = new List<char>(s);

        var i = 0;
        while (list.Count > 1)
        {
            if (list[i] == list[i+1])
            {
                list.RemoveRange(i, 2);
                i = 0;
            }
            else
            {
                i++;
                if (i == list.Count - 1)
                    return string.Join("", list);
            }
        }

        return "Empty String";
    }
}