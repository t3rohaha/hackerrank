namespace Week1;

public class LonelyInteger
{
    public static void Main()
    {
        Console.WriteLine(Solution([1, 2, 3, 4, 3, 2, 1]));
    }

    static int Solution(List<int> a)
    {
        return a.GroupBy(x => x)
                .Where(x => x.Count() == 1)
                .FirstOrDefault()!
                .Key!;
    }
}