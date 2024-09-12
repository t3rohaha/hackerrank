namespace Implementation;

public class CutTheSticks
{
    public static void Main()
    {
        var r1 = Solution([1, 2, 3]);
        Console.WriteLine(string.Join(", ", r1));

        var r2 = Solution([5, 4, 4, 2, 2, 8]);
        Console.WriteLine(string.Join(", ", r2));
    }

    public static List<int> Solution(List<int> arr)
    {
        var a = arr.GroupBy(x => x)
                   .OrderBy(x => x.Key)
                   .ToDictionary(x => x.Key, x => x.Count());

        var result = new List<int>() { a.Sum(x => x.Value) };
        var min = a.FirstOrDefault()!;
        while (a.Any(x => x.Key != min.Key))
        {
            a.Remove(min.Key);
            result.Add(result.Last() - min.Value);
            min = a.FirstOrDefault()!;
        }

        return result;
    }
}