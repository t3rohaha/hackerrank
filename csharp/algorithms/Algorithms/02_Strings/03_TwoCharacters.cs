namespace Strings;

public class TwoCharacters
{
    public static void Main()
    {
        Solution("beabeefeab");
    }

    public static int Solution(string s)
    {
        var uniqueChars = new HashSet<char>(s).ToList();

        var combinations = new List<string>();
        for (var i = 0; i < uniqueChars.Count; i++)
            for (var y = i+1; y < uniqueChars.Count; y++)
                combinations.Add($"{uniqueChars[i]}{uniqueChars[y]}");

        var maxCount = 0;
        foreach (var comb in combinations)       
        {
            var temp = ' ';
            var count = 0;
            foreach (var c in s)
            {
                if (comb.Any(x => x == c))
                {
                    if (temp != c)
                    {
                        temp = c;
                        count++;
                        continue;
                    }
                    else
                    {
                        count = 0;
                        break;
                    }
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
            }
        }

        return maxCount;
    }
}