namespace SparseArrays;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(string.Join("\n",
                MatchingStrings(
                    ["ab", "ab", "abc"],
                    ["ab", "abc", "bc"])));

        Console.WriteLine();

        Console.WriteLine(string.Join("\n",
                MatchingStrings(
                    ["def", "de", "fgh"],
                    ["de", "lmn", "fgh"])));
    }

    static List<int> MatchingStrings(List<string> strings, List<string> queries)
    {
        var group = strings.GroupBy(x => x);

        var results = new List<int>();

        foreach (var q in queries)
        {
            var grouping = group.FirstOrDefault(x => x.Key == q);
            if (grouping == null) results.Add(0);
            else results.Add(grouping.Count());
        }

        return results;
    }
}