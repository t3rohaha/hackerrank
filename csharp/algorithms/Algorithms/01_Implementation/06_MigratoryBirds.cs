namespace Implementation;

public class MigratoryBirds
{
    public static void Main()
    {
        Console.WriteLine(Solution([1, 1, 2, 2, 3]));
        Console.WriteLine(Solution([1, 4, 4, 4, 5, 3]));
        Console.WriteLine(Solution([1, 2, 3, 4, 5]));
    }

    public static int Solution(List<int> arr)
    {
        var group = arr.GroupBy(x => x)
                       .OrderByDescending(x => x.Count())
                       .ThenBy(x => x.Key);

        return group.First().Key;
    }
}