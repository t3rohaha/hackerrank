namespace DiagonalDifference;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(DiagonalDifference([
            [11, 2, 4],
            [4, 5, 6],
            [10, 8, -12]
        ]));
    }

    static int DiagonalDifference(int[][] arr)
    {
        int length = arr.Count();
        int d1 = 0, d2 = 0;

        for (int i = 0; i < length; i++)
        {
            d1 += arr[i][i];
            d2 += arr[i][length - i - 1];
        }

        return Math.Abs(d1 - d2);
    }
}

// 00 01 02 03
// 10 11 12 13
// 20 21 22 23
// 30 31 32 33

// 00 11 22 33
// 03 12 21 30