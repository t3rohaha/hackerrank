namespace Week3;

public class BigSorting
{
    public static void Main()
    {
        Console.WriteLine(string.Join("\n", Solution(["4", "3", "100", "1"])));
    }

    public static List<string> Solution(List<string> unsorted)
    {
        unsorted.Sort(Compare);

        return unsorted;
    }

    public static int Compare(string a, string b)
    {
        if (a.Length > b.Length) return 1;

        if (a.Length < b.Length) return -1;

        if (a == b) return 0;

        for (var i = 0; i < a.Length; i++)
        {
            if (a[i] == b[i]) continue;

            if (a[i] > b[i]) return 1;

            if (a[i] < b[i]) return -1;
        }

        throw new InvalidOperationException("Should not be reached!");
    }
}