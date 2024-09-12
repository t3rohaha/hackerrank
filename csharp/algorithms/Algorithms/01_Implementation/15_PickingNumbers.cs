namespace Implementation;

public class PickingNumbers
{
    public static void Main()
    {
        Console.WriteLine(Solution([4, 6, 5, 3, 3, 1]));
    }

    public static int Solution(List<int> a)
    {
        var b = a.OrderBy(x => x).ToList();

        var maxCount = 0;

        for (var i = 0; i < a.Count; i++)
        {
            var count = 1;
            for (var y = i+1; y < a.Count; y++)
            {
                if (Math.Abs(b[i] - b[y]) <= 1)
                    count++;
                else break;
            }
            if (count > maxCount) maxCount = count;
        }

        return maxCount;
    }
}