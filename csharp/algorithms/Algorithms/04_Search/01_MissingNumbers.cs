namespace Search;

public class MissingNumbers
{
    public static void Main()
    {
        var r1 = Solution([7, 2, 5, 3, 5, 3], [7, 2, 5, 4, 6, 3, 5, 3]);
        Console.WriteLine(string.Join(", ", r1));

        var r2 = Solution([203, 204, 205, 206, 207, 208, 203, 204, 205, 206],
                          [203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204]);
        Console.WriteLine(string.Join(", ", r2));
    }

    public static List<int> Solution(List<int> arr, List<int> brr)
    {
        var result = new List<int>(brr);

        foreach (var a in arr)
            result.Remove(a);

        return new HashSet<int>(result).Order().ToList();
    }
}