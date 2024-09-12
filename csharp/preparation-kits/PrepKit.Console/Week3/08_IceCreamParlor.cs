namespace Week3;

public class IceCreamParlor
{
    public static void Main()
    {
        var res = Solution(3, [1, 2]);
        Console.WriteLine(string.Join(", ", res));
    }

    public static List<int> Solution(int m, List<int> arr)
    {
        var bought = new List<int>(2);

        for (var i = 0; i < arr.Count-1; i++)
        {
            if (arr[i] >= m) continue;

            for (var y = i+1; y < arr.Count; y++)
            {
                if (arr[i] + arr[y] == m)
                {
                    bought = new List<int>(2) {i+1, y+1};
                    goto END;
                }
            }
        }
        END:

        return bought;
    }
}