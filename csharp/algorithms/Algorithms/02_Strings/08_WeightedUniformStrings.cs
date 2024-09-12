namespace Strings;

public class WeightedUniformStrings
{
    public static void Main()
    {
        var r1 = Solution2("abccddde", [1, 3, 12, 5, 9, 10]);
        Console.WriteLine(string.Join(" ", r1));
    }

    // TimeLimit exceeded.
    public static List<string> Solution(string s, List<int> queries)
    {
        var weights = new Dictionary<char, List<int>>();
        foreach (var c in s)
        {
            if (!weights.ContainsKey(c))
                weights.Add(c, new List<int>() {c-96});
            else
                weights[c].Add(weights[c].Last() + (c-96));
        }

        var result = new List<string>(queries.Count);
        foreach (var q in queries)
        {
            if (weights.Values.Any(x => x.Any(y => y == q)))
                result.Add("Yes");
            else
                result.Add("No");
        }

        return result;
    }

    // Success
    public static List<string> Solution2(string s, List<int> queries)
    {
        var weights = new List<int>();

        for (var i = 0; i < s.Length; i++)
        {
            var w = s[i] - 96;

            if (!weights.Contains(w))
                weights.Add(w);

            var counter = 1;
            for (var y = i+1; y < s.Length; y++)
            {
                if (s[i] != s[y])
                    break;

                counter++;
                i = y;

                if (!weights.Contains(counter * w))
                    weights.Add(counter*w);
            }
        }

        var result = new List<string>();
        foreach (var q in queries)
        {
            if (weights.Contains(q))
                result.Add("Yes");
            else
                result.Add("No");
        }
        return result;
    }
}