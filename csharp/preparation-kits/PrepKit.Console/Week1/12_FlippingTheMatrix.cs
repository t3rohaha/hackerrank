namespace Week1;

public class FlippingTheMatrix 
{
    public static void Main()
    {
        Console.WriteLine(Solution([[1, 2],
                                    [3, 4]]));

        Console.WriteLine(Solution([[112, 42, 83, 119],
                                    [56, 125, 56, 49],
                                    [15, 78, 101, 43],
                                    [62, 98, 114, 108]]));
    }

    public static int Solution(List<List<int>> matrix)
    {
        var subLength = matrix.Count / 2;

        var maxSum = 0;

        for (var r = 0; r < subLength; r++)
            for (var c = 0; c < subLength; c++)
                maxSum += FindMax(r, c, matrix);

        return maxSum;
    }

    public static int FindMax(int row, int col, List<List<int>> matrix)
    {
        var length = matrix.Count;
        var mirrorRow = length - 1 - row;
        var mirrorCol = length - 1 - col;

        var a = matrix[row][col];
        var b = matrix[row][mirrorCol];
        var c = matrix[mirrorRow][col];
        var d = matrix[mirrorRow][mirrorCol];

        return new int[] {a, b, c, d}.Max();
    }
}

/*
A B C C B A
D E F F E D
G H I I H G
G H I I H G
D E F F E D
A B C C B A

n 6
A [0][0] [0][5] [5][0] [5][5] 
B [0][1] [0][4] [5][1] [5][4]
C [0][2] [0][3] [5][2] [5][3]

[row][col] [row][n-1-col] [n-1-row][col] [n-1-row][n-1-col]
*/
