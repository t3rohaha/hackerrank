namespace Week3.Tests;

public class TheBombermanGameTests
{

    [Fact]
    public void Solution_ShouldReturnInitialGrid_WhenNEquals1()
    {
        var grid = CreateEmptyGrid(1, 1);

        var actual = TheBombermanGame.Solution(1, grid);
        var expected = CreateEmptyGrid(1, 1);
        var result = actual.SequenceEqual(expected);
        Assert.True(result);
    }

    [Theory]
    [InlineData(2, 2, 2)]
    [InlineData(200, 200, 1_000_000_000)]
    public void Solution_ShouldReturnFullGrid_WhenNIsEven(int rows, int cols, int n)
    {
        var grid = CreateEmptyGrid(rows, cols);

        var actual = TheBombermanGame.Solution(n, grid);
        var expected = CreateFullGrid(rows, cols);
        var result = actual.SequenceEqual(expected);
        Assert.True(result);
    }

    [Theory]
    [InlineData(3, new string[3] {"O.O", "...", "O.O"})]
    [InlineData(5, new string[3] {"...", ".O.", "..."})]
    public void Solution_ShouldReturnExpected(int n, string[] expected)
    {
        List<string> grid = ["...",
                             ".O.",
                             "..."];

        var result = TheBombermanGame.Solution(n, grid);
        Assert.True(result.SequenceEqual(expected)); 
    }

    [Theory]
    [InlineData(3, new string[6] {"OOO.OOO", "OO...OO", "OOO...O", "..OO.OO", "...OOOO", "...OOOO"})]
    public void Solution_ShouldReturnExpected2(int n, string[] expected)
    {
        List<string> grid = [".......",
                             "...O...",
                             "....O..",
                             ".......",
                             "OO.....",
                             "OO....."];

        var result = TheBombermanGame.Solution(n, grid);
        Assert.True(result.SequenceEqual(expected)); 
    }

    [Theory]
    [InlineData(3, new string[3] {"....", "O...", "...O"})]
    [InlineData(5, new string[3] {".OOO", "..O.", ".O.."})]
    [InlineData(7, new string[3] {"....", "O...", "...O"})]
    [InlineData(9, new string[3] {".OOO", "..O.", ".O.."})]
    public void Solution_ShouldReturnExpected3(int n, string[] expected)
    {
        List<string> grid = [".O.O",
                             "..O.",
                             ".O.."];

        var result = TheBombermanGame.Solution(n, grid);
        Assert.True(result.SequenceEqual(expected));
    }

    List<string> CreateEmptyGrid(int rows, int cols)
    {
        var grid = new List<string>(rows);

        for (var i = 0; i < rows; i++)
            grid.Add(new string('.', cols));

        return grid;
    }


    List<string> CreateFullGrid(int rows, int cols)
    {
        var grid = new List<string>(rows);

        for (var i = 0; i < rows; i++)
            grid.Add(new string('O', cols));

        return grid;
    }
}