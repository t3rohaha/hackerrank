namespace Week1;

public class SparseArrays
{
    public static void Main()
    {
        Console.WriteLine(string.Join("\n", Solution(["ab", "ab", "abc"],
                                                     ["ab", "abc", "bc"])));

        Console.WriteLine();

        Console.WriteLine(string.Join("\n", Solution(["def", "de", "fgh"],
                                                     ["de", "lmn", "fgh"])));
    }

    static List<int> Solution(List<string> strings, List<string> queries)
    {
        var group = strings.GroupBy(x => x);

        var results = new List<int>();

        foreach (var q in queries)
        {
            var g = group.FirstOrDefault(x => x.Key == q);

            if (g == null)
            {
                results.Add(0);
            }
            else
            {
                results.Add(g.Count());
            }
        }

        return results;
    }
}