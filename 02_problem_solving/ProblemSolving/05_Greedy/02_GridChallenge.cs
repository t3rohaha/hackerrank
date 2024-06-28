namespace Greedy;

public class GridChallenge
{
    public static void Main()
    {
        var r1 = Solution(["abc", "ade", "efg"]);
        Console.WriteLine(r1);

        var r2 = Solution(["ebacd", "fghij", "olmkn", "trpqs", "xywuv"]);
        Console.WriteLine(r2);

        var r3 = Solution(["mpxz", "abcd", "wlmf"]);
        Console.WriteLine(r3);
    }

    public static string Solution(List<string> grid)
    {
        var orderedGrid = new List<string>();

        foreach(var str in grid)
            orderedGrid.Add(string.Join("", str.Order()));

        for (var i = 0; i < orderedGrid[0].Length; i++)
            for (var j = 1; j < orderedGrid.Count; j++)
                if (orderedGrid[j-1][i] > orderedGrid[j][i])
                    return "NO";

        return "YES";
    }
}