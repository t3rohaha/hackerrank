namespace Week3;

public class NewYearChaos
{
    public static void Main()
    {
        Solution([2, 1]);
        Solution([2, 1, 5, 3, 4]);
        Solution([2, 5, 1, 3, 4]);
        Solution([4, 1, 2, 3]);
        Solution([1, 2, 5, 3, 7, 8, 6, 4]);
    }

    // Time limit exceeded.
    public static void Solution2(List<int> q)
    {
        var totalBribes = 0;

        for (var i = 0; i < q.Count; i++)
        {
            var a = q[i];
            var offset = a - (i+1);

            if (offset > 2)
            {
                Console.WriteLine("Too chaotic");
                return;
            }

            for (var y = i+1; y < q.Count; y++)
            {
                var b = q[y];
                if (a > b) totalBribes++;
            }
        }

        Console.WriteLine(totalBribes);
    }

    public static void Solution(List<int> q)
    {
        var bribes = 0;

        for (var i = q.Count-1; i >= 2; i--)
        {
            if (q[i-2] > q[i-1])
            {
                var temp = q[i-1];
                q[i-1] = q[i-2];
                q[i-2] = temp;
                bribes++;
            }

            if (q[i-1] > q[i])
            {
                var temp = q[i];
                q[i] = q[i-1];
                q[i-1] = temp;
                bribes++;
            }

            if (q[i] != i+1)
            {
                Console.WriteLine("Too chaotic");
                return;
            }
        }

        Console.WriteLine(bribes);
    }
}