namespace Implementation;

public class CircularArrayRotation
{
    public static void Main()
    {
        var a = Solution([3, 4, 5], 2, [1, 2]);
        Console.WriteLine(string.Join(", ", a));
    }

    public static List<int> Solution(List<int> a, int k, List<int> queries)
    {
        var b = new int[a.Count];
        for (var i = 0; i < a.Count; i++)
        {
            var idx = (i+k) % a.Count;
            b[idx] = a[i];
        }

        var result = new List<int>(queries.Count);
        foreach(var q in queries)
            result.Add(b[q]);

        return result;
    }
}