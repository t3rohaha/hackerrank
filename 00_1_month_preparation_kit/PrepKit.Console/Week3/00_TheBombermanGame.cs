namespace Week3;

public class TheBombermanGame
{
    public static void Main()
    {
        Solution(3, ["...",
                     ".O.",
                     "..."]);
        
        Solution(3, [".......",
                     "...O...",
                     "....O..",
                     ".......",
                     "OO.....",
                     "OO....."]);
    }

    public static List<string> Solution(int n, List<string> grid)
    {
        // 1 sec: return grid.
        var prePrev = new List<string>(grid);
        if (n == 1)
            return prePrev;

        // even sec: return grid filled with bombs.
        var prev = grid.Select(s => new string('O', s.Length)).ToList();
        if (n % 2 == 0)
            return prev;

        // detonate once to create result.
        var result = DetonateBombs(grid);
        if (n == 3)
            return result;

        // skip even sec and start detonating from 5,
        // as 4 secs passed already.
        var terminatedAt = -1;
        for (var s = 5; s <= n; s+=2)
        {
            prePrev = new List<string>(prev);
            prev = new List<string>(result);
            result = DetonateBombs(result);

            // if result equals prePrev,
            // we will have 2 grids repeating till the end.
            if (result.SequenceEqual(prePrev))
            {
                terminatedAt = s;
                break;
            };
        }

        // check if prev or result should be returned.
        if (terminatedAt > -1)
            if ((n - terminatedAt) % 4 != 0)
                return prev;

        return result;
    }

    public static List<string> DetonateBombs(List<string> grid)
    {
        var rows = grid.Count;
        var cols = grid[0].Length;
        var newGrid = new List<string>(rows);

        var inBombRange = (List<string> g, int r, int c) => 
        {
                var top = r-1;
                var right = c+1;
                var left = c-1;
                var down = r+1;
                var rowOutOfRange = (int i) => i < 0 || i > g.Count - 1;
                var colOutOfRange = (int i) => i < 0 || i > g[0].Length - 1;

                if (g[r][c] == 'O') return true;
                if (!rowOutOfRange(top) && g[top][c] == 'O') return true;
                if (!colOutOfRange(right) && g[r][right] == 'O') return true;
                if (!rowOutOfRange(down) && g[down][c] == 'O') return true;
                if (!colOutOfRange(left) && g[r][left] == 'O') return true;
                return false;
        };

        for (var r = 0; r < rows; r++)
        {
            var newRow = "";

            for (var c = 0; c < cols; c++)
            {
                if (inBombRange(grid, r, c))
                    newRow += ".";
                else
                    newRow += "O";
            }

            newGrid.Add(newRow);
        }

        return newGrid;
    }
}