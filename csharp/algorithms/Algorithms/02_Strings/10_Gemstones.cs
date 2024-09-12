namespace Strings;

public class Gemstones
{
    public static void Main()
    {
        Console.WriteLine(Solution(["abcdde", "baccd", "eeabg"]));
    }

    public static int Solution(List<string> arr)
    {
        var gems = new HashSet<char>(arr[0]);

        foreach (var r in arr)
            foreach (var g in gems)
                if (!r.Contains(g))
                    gems.Remove(g);

        return gems.Count;
    }
}