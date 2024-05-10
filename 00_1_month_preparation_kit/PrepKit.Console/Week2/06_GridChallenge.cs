namespace Week2;

public class GridChallenge
{
    public static void Main()
    {
        Console.WriteLine(string.Join(" ", Solution(["abc",
                                                     "ade",
                                                     "efg"])));

        Console.WriteLine(string.Join(" ", Solution(["abc",
                                                     "lmp",
                                                     "qrt"])));

        Console.WriteLine(string.Join(" ", Solution(["mpxz",
                                                     "abcd",
                                                     "wlmf"])));

        Console.WriteLine(string.Join(" ", Solution(["abc",
                                                     "hjk",
                                                     "mpq",
                                                     "rtv"])));
    }

    static string Solution(string[] grid)
    {
        var rows = grid.Count();
        var cols = grid[0].Count();
        var orderedGrid = new string[rows];

        // Order rows.
        for (var i = 0; i < rows; i++)
        {
            orderedGrid[i] = string.Join("", grid[i].Order());
        }

        // Check if cols are ascending.
        for (var c = 0; c < cols; c++)
        {
            for (var r = 0; r < rows - 1; r++)
            {
                var a = orderedGrid[r][c];
                var b = orderedGrid[r+1][c];
                if (a > b)
                {
                    return "NO";
                }
            }
        }

        return "YES";
    }
}