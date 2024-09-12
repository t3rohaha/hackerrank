namespace Implementation;

public class EqualizeArray
{
    public static void Main()
    {
        Solution([1, 2, 2, 3]);
    }

    public static int Solution(List<int> arr)
    {
        var g = arr.GroupBy(x => x)
                   .Select(x => new
                   {
                        Num = x.Key,
                        Count = x.Count()
                   })
                   .ToList();

        var minCount = int.MaxValue;
        for (var i = 0; i < g.Count; i++)
        {
            var tempCount = 0;
            for (var j = 0; j < g.Count; j++)
                if (i != j) tempCount += g[j].Count;
            
            if (tempCount < minCount)
                minCount = tempCount;
        }

        return minCount;
    }
}