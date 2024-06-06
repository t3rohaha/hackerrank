namespace Implementation;

public class SequenceEquation
{
    public static void Main()
    {
        var r1 = Solution([2, 3, 1]);
        Console.WriteLine(string.Join(", ", r1));
        var r2 = Solution([4, 3, 5, 1, 2]);
        Console.WriteLine(string.Join(", ", r2));
    }

    public static List<int> Solution(List<int> p)
    {
        var result = new List<int>(p.Count);

        for (var i = 0; i < p.Count; i++)
        {
            var x = i+1;
            var y = p.IndexOf(x)+1;
            var z = p.IndexOf(y)+1;
            result.Add(z);
        }

        return result;
    }
}