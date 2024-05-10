namespace Week1;

public class PermutingTwoArrays
{
    public static void Main()
    {
        Console.WriteLine(Solution(1, [0, 1], [0, 2]));
        Console.WriteLine(Solution(10, [2, 1, 3], [7, 8, 9]));
        Console.WriteLine(Solution(5, [1, 2, 2, 1], [3, 3, 3, 4]));
    }

    static string Solution(int k, int[] A, int[] B)
    {
        var orderedA = A.Order().ToArray();
        var orderedB = B.Order().ToArray();
        var length = A.Count();

        for (var i = 0; i < length; i++)
            if (orderedA[i] + orderedB[length - i - 1] < k)
                return "NO";

        return "YES";
    }
}