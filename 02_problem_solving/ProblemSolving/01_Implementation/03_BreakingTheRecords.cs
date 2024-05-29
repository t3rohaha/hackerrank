namespace Implementation;

public class BreakingTheRecords
{
    public static void Main()
    {
        var r1 = Solution([12, 24, 10, 24]);
        Console.WriteLine(string.Join(", ", r1));

        var r2 = Solution([10, 5, 20, 20, 4, 5, 2, 25, 1]);
        Console.WriteLine(string.Join(", ", r2));
    }

    public static List<int> Solution(List<int> scores)
    {
        var q = new Queue<int>(scores);
        var min = q.Peek();
        var max = q.Dequeue();
        var result = new List<int>(2) {0, 0};

        while (q.Any())
        {
            var points = q.Dequeue();

            if (max < points)
            {
                max = points;
                result[0]++;
                continue;
            }

            if (min > points)
            {
                min = points;
                result[1]++;
                continue;
            }
        }

        return result;
    }
}