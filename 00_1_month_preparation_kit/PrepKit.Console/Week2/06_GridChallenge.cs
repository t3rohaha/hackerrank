namespace GridChallenge;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(string.Join(" ", GridChallenge(["abc",
                                                          "ade",
                                                          "efg"])));

        Console.WriteLine(string.Join(" ", GridChallenge(["abc",
                                                          "lmp",
                                                          "qrt"])));

        Console.WriteLine(string.Join(" ", GridChallenge(["mpxz",
                                                          "abcd",
                                                          "wlmf"])));

        Console.WriteLine(string.Join(" ", GridChallenge(["abc",
                                                          "hjk",
                                                          "mpq",
                                                          "rtv"])));
    }

    static string GridChallenge(string[] grid)
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