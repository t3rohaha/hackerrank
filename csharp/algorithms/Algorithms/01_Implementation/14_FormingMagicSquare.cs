namespace Implementation;

public class FormingMagicSquare
{
    public static void Main()
    {
        Console.WriteLine(Solution([[5, 3, 4], [1, 5, 8], [6, 4, 2]]));
    }

    // 's' is 3x3 matrix.
    public static int Solution(List<List<int>> s)
    {
        // For n x n matrix there is a formula for calculating magic const,
        // which is the magic sum that will make the square magic.
        // For 3 x 3 matrix there are 8 possible variants for the square to
        // be magic.
        var ms = new int[8, 3, 3]
        {
            { {8, 1, 6}, {3, 5, 7}, {4, 9, 2} },
            { {6, 1, 8}, {7, 5, 3}, {2, 9, 4} },
            { {4, 9, 2}, {3, 5, 7}, {8, 1, 6} },
            { {2, 9, 4}, {7, 5, 3}, {6, 1, 8} },
            { {8, 3, 4}, {1, 5, 9}, {6, 7, 2} },
            { {4, 3, 8}, {9, 5, 1}, {2, 7, 6} },
            { {6, 7, 2}, {1, 5, 9}, {8, 3, 4} },
            { {2, 7, 6}, {9, 5, 1}, {4, 3, 8} }
        };

        // Compare every possible magic square with the input square to find
        // min cost.
        int minCost = int.MaxValue;
        for (int i = 0; i < 8; i++)
        {
            var cost = 0;

            for (var r = 0; r < 3; r++)
                for (var c = 0; c < 3; c++)
                    cost += Math.Abs(ms[i, r, c] - s[r][c]);

            if (minCost > cost) minCost = cost;
        }
        return minCost;
    }
}