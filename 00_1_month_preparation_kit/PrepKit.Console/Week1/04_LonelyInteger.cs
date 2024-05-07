namespace LonelyInteger;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(LonelyInteger([1, 2, 3, 4, 3, 2, 1]));
    }

    static int LonelyInteger(List<int> a)
    {
        return a.GroupBy(x => x)
                .Where(x => x.Count() == 1)
                .FirstOrDefault()!
                .Key!;
    }
}